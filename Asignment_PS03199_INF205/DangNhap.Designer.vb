<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnHuyBo = New System.Windows.Forms.Button()
        Me.chkGhiNho = New System.Windows.Forms.CheckBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.lblGhiNho = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.ptbHinhdn = New System.Windows.Forms.PictureBox()
        CType(Me.ptbHinhdn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(231, 41)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 16
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(231, 15)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 15
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(268, 98)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(75, 23)
        Me.btnHuyBo.TabIndex = 14
        Me.btnHuyBo.Text = "Hủy Bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'chkGhiNho
        '
        Me.chkGhiNho.AutoSize = True
        Me.chkGhiNho.Location = New System.Drawing.Point(222, 68)
        Me.chkGhiNho.Name = "chkGhiNho"
        Me.chkGhiNho.Size = New System.Drawing.Size(15, 14)
        Me.chkGhiNho.TabIndex = 13
        Me.chkGhiNho.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.Location = New System.Drawing.Point(180, 98)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(82, 23)
        Me.btnDangNhap.TabIndex = 12
        Me.btnDangNhap.Text = "Đăng Nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'lblGhiNho
        '
        Me.lblGhiNho.AutoSize = True
        Me.lblGhiNho.Location = New System.Drawing.Point(240, 69)
        Me.lblGhiNho.Name = "lblGhiNho"
        Me.lblGhiNho.Size = New System.Drawing.Size(91, 13)
        Me.lblGhiNho.TabIndex = 9
        Me.lblGhiNho.Text = "Ghi nhớ tài khoản"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(170, 44)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(56, 13)
        Me.lblPass.TabIndex = 10
        Me.lblPass.Text = "Password:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(193, 18)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(32, 13)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "User:"
        '
        'ptbHinhdn
        '
        Me.ptbHinhdn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhdn.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.login_icon
        Me.ptbHinhdn.Location = New System.Drawing.Point(12, 12)
        Me.ptbHinhdn.Name = "ptbHinhdn"
        Me.ptbHinhdn.Size = New System.Drawing.Size(152, 114)
        Me.ptbHinhdn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbHinhdn.TabIndex = 8
        Me.ptbHinhdn.TabStop = False
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(387, 133)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.chkGhiNho)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.lblGhiNho)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.ptbHinhdn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng Nhập"
        CType(Me.ptbHinhdn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents chkGhiNho As System.Windows.Forms.CheckBox
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents lblGhiNho As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents ptbHinhdn As System.Windows.Forms.PictureBox

End Class
