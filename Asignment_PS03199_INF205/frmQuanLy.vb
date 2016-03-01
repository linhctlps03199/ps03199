Public Class frmQuanLy

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnGioiThieu_Click(sender As Object, e As EventArgs) Handles btnGioiThieu.Click
        frmGioiThieu.Show()
    End Sub

    Private Sub btnQLKH_Click(sender As Object, e As EventArgs) Handles btnQLKH.Click
        frmQLKhachHang.Show()
    End Sub

    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmQuanLySP.Show()
    End Sub

    Private Sub btnQLHD_Click(sender As Object, e As EventArgs) Handles btnQLHD.Click
        frmQLHoaDon.Show()
    End Sub

    Private Sub btnBaoCao_Click(sender As Object, e As EventArgs) Handles btnBaoCao.Click
        frmBaoCao.Show()
    End Sub
End Class