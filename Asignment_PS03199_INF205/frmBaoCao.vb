Imports System.Data.SqlClient
Public Class frmBaoCao
    Private Sub frmBaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillBaoCao()
        Dim sql1 As String = <sql>
                                select * from khachhang_ps03199
                            </sql>
        fill(sql1, "hoadon_ps03199")
        cboMKH.DataSource = ds.Tables("hoadon_ps03199")
        'cboMaSP.ValueMember = "TenKH"
        cboMKH.DisplayMember = "MaKH"
    End Sub
    Private Sub FillBaoCao()
        Dim Sql As String =
            <sql>
                SELECT KHACHHANG_PS03199.TenKH, SoHD, NgayHD, TongTien, DiaChi, SoDT, Email
                From KHACHHANG_PS03199 inner join HOADON_PS03199 on KHACHHANG_PS03199.MaKH = HOADON_PS03199.MaKH
               
            </sql>

        Sql = String.Format(Sql, cboMKH.SelectedValue)
        fill(Sql, "BaoCao")
        bsMaKH.DataSource = ds.Tables("BaoCao")
        dgvTK1.DataSource = bsMaKH
        bsMaKH.ResetBindings(False)
    End Sub
   
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        frmQuanLy.Show()
        Me.Hide()
    End Sub

    Private Sub cboMKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMKH.SelectedIndexChanged
        FillBaoCao()
    End Sub
End Class