Public Class frmDangNhap

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'nếu chưa nhập tên người dùng hoặc mật khẩu thì hiển thị thông báo
        If txtUser.Text = "admin" And txtPass.Text = "admin" Then
            ' hiển thị thông báo
            MsgBox("Đăng nhập thành công!")
            frmQuanLy.Show()
        ElseIf txtUser.Text = "" Then
            MsgBox("Chưa nhập tên người dùng!")
        ElseIf txtPass.Text = "" Then
            MsgBox("Chưa nhập Password!")
        Else
            MsgBox("Đăng nhập thất bại!")
        End If
    End Sub

    Private Sub lblGhiNho_Click(sender As Object, e As EventArgs) Handles lblGhiNho.Click

    End Sub

    Private Sub btnHuyBo_Click(sender As Object, e As EventArgs) Handles btnHuyBo.Click
        Environment.Exit(0)
    End Sub

    Private Sub chkGhiNho_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkGhiNho_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkGhiNho.CheckedChanged
        If chkGhiNho.Checked = True Then
            txtPass.Text = "admin"
            txtUser.Text = "admin"
        ElseIf chkGhiNho.Checked = False Then
            txtUser.Text = ""
            txtPass.Text = ""
        End If
    End Sub
End Class