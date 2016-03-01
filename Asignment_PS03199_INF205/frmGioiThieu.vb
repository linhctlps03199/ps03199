Public Class frmGioiThieu

    Private Sub ptbLanLinh_Click(sender As Object, e As EventArgs) Handles ptbLanLinh.Click
        Process.Start("https://www.facebook.com/lanlinh.chau")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://www.facebook.com")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://plus.google.com")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://twitter.com/")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.youtube.com/")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://www.facebook.com/lanlinh.chau")
    End Sub
End Class