Imports System.Data.SqlClient
Public Class frmQLHoaDon
    Private Sub frmQLHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillQLHoaDon()

        Dim sql1 As String = <sql>
                                select * from sanpham_ps03199
                            </sql>
        fill(sql1, "ct_hoadon_ps03199")
        cboMaSP.DataSource = ds.Tables("ct_hoadon_ps03199")
        'cboMaSP.ValueMember = "tensp"
        cboMaSP.DisplayMember = "masp"
    End Sub
    Private Sub FillQLHoaDon()
        Dim Sql As String =
            <sql>
                Select *
                FROM HOADON_PS03199 INNER JOIN CT_HOADON_PS03199 
                ON HOADON_PS03199.SoHD = CT_HOADON_PS03199.SoHD
            </sql>
       
        fill(Sql, "QLHoaDon")
        bsHD.DataSource = ds.Tables("QLHoaDon")
        dgvHD.DataSource = bsHD
        bsHD.ResetBindings(False)

    End Sub
    'vampire
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            Dim sql As String = <sql>
                                insert into hoadon_ps03199
                                values ('{0}','{1}','{2}','{3}')
                                insert into ct_hoadon_ps03199
                                values ('{4}','{5}','{6}','{7}')
                            </sql>
            sql = String.Format(sql, txtSoHD.Text, txtNgayHD.Text, txtMkh.Text, txtThanhTien.Text, txtSoHD.Text, cboMaSP.Text, nudSoLuong.Text, txtDonGia.Text)
            Executenonquery(sql)
            FillQLHoaDon()
        Catch ex As Exception
        End Try



    End Sub

    Private Sub btnSuaHD_Click(sender As Object, e As EventArgs) Handles btnSuaHD.Click
        'Try
        Dim Sql As String =
            <sql>
                UPDATE HOADON_PS03199
                SET NgayHD = N'{0}', MaKH = N'{1}', TongTien = N'{2}'
                Where (SoHD = N'{3}')
                UPDATE CT_HOADON_PS03199
                SET MaSP = N'{4}', SoLuong = N'{5}', DonGia = N'{6}'
                Where (SoHD = N'{7}')
            </sql>
        Sql = String.Format(Sql, txtNgayHD.Text, txtMkh.Text, txtThanhTien.Text, txtSoHD.Text, cboMaSP.Text, nudSoLuong.Text, txtDonGia.Text, txtSoHD.Text)
        Executenonquery(Sql)

        FillQLHoaDon()
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnXoaHD_Click(sender As Object, e As EventArgs) Handles btnXoaHD.Click
        'Try
        Dim Sql As String = <sql> 
                                delete from ct_hoadon_ps03199
                                where sohd = '{0}'

                                DELETE FROM HOADON_PS03199
                                WHERE        (SoHD = N'{1}')
                               
                            </sql>

        Sql = String.Format(Sql, txtSoHD.Text, txtSoHD.Text)
        Executenonquery(Sql)
        'Dim sql1 As String = <sql>
        '                         delete from ct_hoadon_ps03199
        '                        where sohd = '{0}'

        '                     </sql>
        'sql1 = String.Format(sql1, txtSoHD.Text)
        'Executenonquery(sql1)
        FillQLHoaDon()
        'Catch ex As Exception
        'End Try

    End Sub

    Private Sub dgvHD_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHD.SelectionChanged
        Try
            Dim RowView As DataRowView = bsHD.Current
            Dim Row As DataRow = RowView.Row

            txtSoHD.Text = Row("SoHD")
            txtNgayHD.Text = Row("NgayHD")
            txtMkh.Text = Row("MaKH")
            txtDonGia.Text = Row("DonGia")
            txtThanhTien.Text = Row("TongTien")
            cboMaSP.Text = Row("MaSP")
            nudSoLuong.Text = Row("SoLuong")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        frmQuanLy.Show()
        Me.Hide()
    End Sub

    Private Sub cboMaSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaSP.SelectedIndexChanged

    End Sub
End Class