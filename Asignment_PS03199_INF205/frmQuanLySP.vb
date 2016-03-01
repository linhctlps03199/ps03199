Imports System.Data.SqlClient
Imports System.IO
Public Class frmQuanLySP
    Private Sub frmQuanLySP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillQuanLySP()
    End Sub

    Private Sub FillQuanLySP()
        Dim Sql As String =
            <sql>
                SELECT * FROM SanPham_PS03199
            </sql>
        fill(Sql, "QuanLySP")
        bsSP.DataSource = ds.Tables("QuanLySP")
        dgvSp.DataSource = bsSP
        bsSP.ResetBindings(False)
    End Sub

    Private output As StreamWriter
    'xác định xem kiểu file có hợp lệ không
    Private Function CheckValidity(ByVal name As String) As Boolean
        'hiển thị báo lỗi nếu người dùng chọn tên file không hợp lệ
        If name.EndsWith(".txt") = False Then
            MessageBox.Show( _
                "Tên File phải kết thúc bằng đuôi .txt", _
                "Dạng tập tin", MessageBoxButtons.OK, _
                MessageBoxIcon.Error)
            Return False 'chỉ ra kiểu file không hợp lệ
        Else
            ' chuyển trạng thái của button nếu tên file hợp lệ
            btnThemSP.Enabled = True
            btnLuuNhap.Enabled = True
            btnThoat.Enabled = True
            btnSua.Enabled = True
            btnXoaSP.Enabled = True
            Return True ' chỉ ra rằng file văn bản đã được chọn
        End If
    End Function 'CheckValidity

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmQuanLy.Show()
        Me.Hide()
    End Sub
   
    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        Dim Sql As String =
            <sql>
                INSERT INTO SanPham_PS03199(MaSP, TenSP, MaLoai, XuatXu)
                Values(N'{0}', N'{1}', N'{2}', N'{3}')
            </sql>
        Sql = String.Format(Sql, txtMaSp.Text, txtTenSP.Text, txtLoaiSP.Text, cboXuatXu.Text)
        Executenonquery(Sql)

        FillQuanLySP()
    End Sub
    'xóa nội dung trên các textbox
    Private Sub ClearUserInput()
        txtMaSp.Clear()
        txtTenSP.Clear()
        txtLoaiSP.Clear()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
            <sql>
            Update SANPHAM_PS03199
            Set TenSP = N'{1}', MaLoai = N'{2}', XuatXu = N'{3}'
            Where (MaSP = N'{0}')
            </sql>
        Sql = String.Format(Sql, txtMaSp.Text, txtTenSP.Text, txtLoaiSP.Text, cboXuatXu.Text)
        Executenonquery(Sql)

        FillQuanLySP()
    End Sub

    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        Dim Sql As String =
            <sql>
                Delete FROM SANPHAM_PS03199
                Where (MaSP = N'{0}')
            </sql>
        Sql = String.Format(Sql, txtMaSp.Text)
        Executenonquery(Sql)

        FillQuanLySP()
    End Sub

    Private Sub btnLuuNhap_Click(sender As Object, e As EventArgs) Handles btnLuuNhap.Click
        'Khai báo biến ofd 
        Dim r As DialogResult = ofdLuu.ShowDialog()
        'mở file được chọn nếu người dùng không nhấn vào button cancel
        If r <> Windows.Forms.DialogResult.Cancel Then
            'lấy tên của file được chọn
            Dim filename As String = ofdLuu.FileName
            'kiểm tra tên file có hợp lệ không
            If CheckValidity(filename) = True Then
                'cho phép người dùng thêm dữ liệu vào file thông qua StreamWriter
                output = New StreamWriter(filename, True)
            End If
        End If
        'sử dung StreamWriter để ghi dữ liệu vào file
        output.Write(txtMaSp.Text & ControlChars.Tab)
        output.Write(txtTenSP.Text & ControlChars.Tab)
        output.Write(cboXuatXu.Text & ControlChars.Tab)
        output.WriteLine(txtLoaiSP.Text)
        output.Close()
        ClearUserInput() 'chuẩn bị cho người dùng nhoutput.Close()ập thông tin
        MsgBox("Bạn đã Lưu Nháp thành công!")
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtMaSp.Clear()
        txtLoaiSP.Clear()
        txtTenSP.Clear()
    End Sub

    Private Sub btnIP_Click(sender As Object, e As EventArgs) Handles btnIP.Click
        Process.Start("https://www.thegioididong.com/tim-kiem?key=iphone")
    End Sub

    Private Sub ptbIphone_Click(sender As Object, e As EventArgs) Handles ptbIphone.Click
        Process.Start("https://www.thegioididong.com/dtdd/iphone-6-plus-128gb")
    End Sub

    Private Sub lblIp_Click(sender As Object, e As EventArgs) Handles lblIp.Click
        Process.Start("https://www.thegioididong.com/dtdd/iphone-6-plus-128gb")
    End Sub

    Private Sub btnSamSung_Click(sender As Object, e As EventArgs) Handles btnSamSung.Click
        Process.Start("http://www.nguyenkim.com/dien-thoai-di-dong-samsung/")
    End Sub

    Private Sub ptbSS_Click(sender As Object, e As EventArgs) Handles ptbSS.Click
        Process.Start("http://www.samsung.com/vn/consumer/mobile-devices/smartphones/galaxy-s/SM-G925FZDACAM/?cid=vn_ppc_google_longterms6_20160202&utm_source=Google&utm_medium=CPC&utm_content=s6&utm_campaign=lt_sem_2016&gclid=Cj0KEQiAuqC2BRDVxMSnpa-mhZoBEiQAFta8wSOUkcNCmbDr_bKUjD2uQm1rWBYNc4qqo3tsu_PY0h0aAo0p8P8HAQ")
    End Sub

    Private Sub lblSs_Click(sender As Object, e As EventArgs) Handles lblSs.Click
        Process.Start("http://www.samsung.com/vn/consumer/mobile-devices/smartphones/galaxy-s/SM-G925FZDACAM/?cid=vn_ppc_google_longterms6_20160202&utm_source=Google&utm_medium=CPC&utm_content=s6&utm_campaign=lt_sem_2016&gclid=Cj0KEQiAuqC2BRDVxMSnpa-mhZoBEiQAFta8wSOUkcNCmbDr_bKUjD2uQm1rWBYNc4qqo3tsu_PY0h0aAo0p8P8HAQ")
    End Sub

    Private Sub btnWiko_Click(sender As Object, e As EventArgs) Handles btnWiko.Click
        Process.Start("https://www.thegioididong.com/tim-kiem?key=wiko")
    End Sub

    Private Sub btnXiaomi_Click(sender As Object, e As EventArgs) Handles btnXiaomi.Click
        Process.Start("http://xtmobile.vn/san-pham/search/")
    End Sub

    Private Sub btnBlacberry_Click(sender As Object, e As EventArgs) Handles btnBlacberry.Click
        Process.Start("http://www.nguyenkim.com/tim-san-pham-theo-thuong-hieu?brand=BlackBerry")
    End Sub

    Private Sub lblBlac_Click(sender As Object, e As EventArgs) Handles lblBlac.Click
        Process.Start("http://www.nguyenkim.com/dtdd-blackberry-passport-sqw100-1-black.html")
    End Sub

    Private Sub ptbBkac_Click(sender As Object, e As EventArgs) Handles ptbBkac.Click
        Process.Start("http://www.nguyenkim.com/dtdd-blackberry-passport-sqw100-1-black.html")
    End Sub

    Private Sub btnLg_Click(sender As Object, e As EventArgs) Handles btnLg.Click
        Process.Start("https://www.thegioididong.com/tim-kiem?key=lg")
    End Sub

    Private Sub ptbLG5_Click(sender As Object, e As EventArgs) Handles ptbLG5.Click
        Process.Start("https://www.thegioididong.com/dtdd/lg-g4")
    End Sub

    Private Sub lblLg5_Click(sender As Object, e As EventArgs) Handles lblLg5.Click
        Process.Start("https://www.thegioididong.com/dtdd/lg-g4")
    End Sub

    Private Sub btnHtc_Click(sender As Object, e As EventArgs) Handles btnHtc.Click
        Process.Start("https://www.thegioididong.com/tim-kiem?key=htc")
    End Sub

    Private Sub ptbHtcA9_Click(sender As Object, e As EventArgs) Handles ptbHtcA9.Click
        Process.Start("https://www.thegioididong.com/dtdd/htc-one-a9")
    End Sub

    Private Sub lblHtc_Click(sender As Object, e As EventArgs) Handles lblHtc.Click
        Process.Start("https://www.thegioididong.com/dtdd/htc-one-a9")
    End Sub

    Private Sub btnAsus_Click(sender As Object, e As EventArgs) Handles btnAsus.Click
        Process.Start("http://xtmobile.vn/san-pham/search/")
    End Sub

    Private Sub ptbAsus_Click(sender As Object, e As EventArgs) Handles ptbAsus.Click
        Process.Start("http://xtmobile.vn/asus-zenfone-2")
    End Sub

    Private Sub lblAsus_Click(sender As Object, e As EventArgs) Handles lblAsus.Click
        Process.Start("http://xtmobile.vn/asus-zenfone-2")
    End Sub

    Private Sub btnThoate_Click(sender As Object, e As EventArgs) Handles btnThoate.Click
        frmQuanLy.Show()
        Me.Hide()
    End Sub

    Private Sub dgvSp_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSp.SelectionChanged
        Try
            Dim RowView As DataRowView = bsSP.Current
            Dim Row As DataRow = RowView.Row
            txtMaSp.Text = Row("MaSP")
            txtTenSP.Text = Row("TenSP")
            txtLoaiSP.Text = Row("MaLoai")
            cboXuatXu.Text = Row("XuatXu")
        Catch ex As Exception
        End Try
    End Sub
End Class