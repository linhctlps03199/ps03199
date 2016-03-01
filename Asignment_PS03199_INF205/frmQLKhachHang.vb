Imports System.Data.SqlClient
Imports System.IO
Public Class frmQLKhachHang
    Private Sub frmQLKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillQLKhachHang()
    End Sub
    Private Sub FillQLKhachHang()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG_PS03199
            </sql>
        Fill(Sql, "QLKhachHang")
        bsKH.DataSource = ds.Tables("QLKhachHang")
        dgvKH.DataSource = bsKH
        bsKH.ResetBindings(False)
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
            btnThem.Enabled = True
            btnLuutxt.Enabled = True
            btnHuyBo.Enabled = True
            btnSua.Enabled = True
            btnXoa.Enabled = True
            Return True ' chỉ ra rằng file văn bản đã được chọn
        End If
    End Function 'CheckValidity
    'xóa nội dung trên các textbox
    Private Sub ClearUserInput()
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtSDT.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub btnDau_Click(sender As Object, e As EventArgs) Handles btnDau.Click
        bsKH.MoveFirst()
    End Sub

    Private Sub btnTrai_Click(sender As Object, e As EventArgs) Handles btnTrai.Click
        bsKH.MovePrevious()
    End Sub

    Private Sub btnPhai_Click(sender As Object, e As EventArgs) Handles btnPhai.Click
        bsKH.MoveNext()
    End Sub

    Private Sub btnCuoi_Click(sender As Object, e As EventArgs) Handles btnCuoi.Click
        bsKH.MoveLast()
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String = <sql>
                INSERT INTO KHACHHANG_PS03199 (MaKH, TenKH, DiaChi, SoDT, Email)
               VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')
         </sql>
        Sql = String.Format(Sql, txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text)
        Executenonquery(Sql)

        FillQLKhachHang()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String = <sql>
            UPDATE       KHACHHANG_PS03199
            SET TenKH = N'{1}', DiaChi = N'{2}', SoDT = N'{3}', Email= N'{4}'
            WHERE        (MaKH = N'{0}')
                            </sql>
        Sql = String.Format(Sql, txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text)
        ExecuteNonQuery(Sql)

        FillQLKhachHang()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String = <sql>
                                DELETE FROM KHACHHANG_PS03199
                                WHERE        (MaKH = N'{0}')
                            </sql>
        Sql = String.Format(Sql, txtMaKH.Text)
        ExecuteNonQuery(Sql)
        FillQLKhachHang()
    End Sub

    Private Sub btnHuyBo_Click(sender As Object, e As EventArgs) Handles btnHuyBo.Click
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtSDT.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub dgvKH_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKH.SelectionChanged
        Try
            Dim RowView As DataRowView = bsKH.Current
            Dim Row As DataRow = RowView.Row

            txtMaKH.Text = Row("MaKH")
            txtTenKH.Text = Row("TenKH")
            txtDiaChi.Text = Row("DiaChi")
            txtSDT.Text = Row("SoDT")
            txtEmail.Text = Row("Email")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLuutxt_Click(sender As Object, e As EventArgs) Handles btnLuutxt.Click
        'Khai báo biến ofd 
        Dim r As DialogResult = ofdLuuKH.ShowDialog()
        'mở file được chọn nếu người dùng không nhấn vào button cancel
        If r <> Windows.Forms.DialogResult.Cancel Then
            'lấy tên của file được chọn
            Dim filename As String = ofdLuuKH.FileName
            'kiểm tra tên file có hợp lệ không
            If CheckValidity(filename) = True Then
                'cho phép người dùng thêm dữ liệu vào file thông qua StreamWriter
                output = New StreamWriter(filename, True)
            End If
        End If
        'sử dung StreamWriter để ghi dữ liệu vào file
        output.Write(txtMaKH.Text & ControlChars.Tab)
        output.Write(txtTenKH.Text & ControlChars.Tab)
        output.Write(txtDiaChi.Text & ControlChars.Tab)
        output.Write(txtSDT.Text & ControlChars.Tab)
        output.WriteLine(txtEmail.Text)
        output.Close()
        ClearUserInput() 'chuẩn bị cho người dùng nhoutput.Close()ập thông tin
        MsgBox("Bạn đã Lưu Nháp thành công!")
    End Sub
End Class