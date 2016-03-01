<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKhachHang
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLKhachHang))
        Me.lblTenKH = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnHuyBo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnPhai = New System.Windows.Forms.Button()
        Me.btnTrai = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.bsKH = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLuutxt = New System.Windows.Forms.Button()
        Me.ofdLuuKH = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTenKH
        '
        Me.lblTenKH.AutoSize = True
        Me.lblTenKH.Location = New System.Drawing.Point(366, -17)
        Me.lblTenKH.Name = "lblTenKH"
        Me.lblTenKH.Size = New System.Drawing.Size(92, 13)
        Me.lblTenKH.TabIndex = 24
        Me.lblTenKH.Text = "Tên Khách Hàng:"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(162, -17)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(88, 13)
        Me.lblMaKH.TabIndex = 22
        Me.lblMaKH.Text = "Mã Khách Hàng:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(174, 141)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(495, 30)
        Me.txtDiaChi.TabIndex = 34
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(174, 121)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(44, 13)
        Me.lblDiaChi.TabIndex = 33
        Me.lblDiaChi.Text = "Địa Chỉ:"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(174, 88)
        Me.txtSDT.Multiline = True
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(178, 26)
        Me.txtSDT.TabIndex = 32
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(171, 71)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(78, 13)
        Me.lblSDT.TabIndex = 31
        Me.lblSDT.Text = "Số Điện Thoại:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(378, 88)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(291, 26)
        Me.txtEmail.TabIndex = 30
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(375, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 29
        Me.lblEmail.Text = "Email:"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(378, 33)
        Me.txtTenKH.Multiline = True
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(291, 25)
        Me.txtTenKH.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tên Khách Hàng:"
        '
        'txtMaKH
        '
        Me.txtMaKH.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaKH.Location = New System.Drawing.Point(174, 33)
        Me.txtMaKH.Multiline = True
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(178, 25)
        Me.txtMaKH.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Mã Khách Hàng:"
        '
        'dgvKH
        '
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(34, 206)
        Me.dgvKH.MultiSelect = False
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKH.Size = New System.Drawing.Size(635, 204)
        Me.dgvKH.TabIndex = 35
        '
        'btnHuyBo
        '
        Me.btnHuyBo.Location = New System.Drawing.Point(687, 149)
        Me.btnHuyBo.Name = "btnHuyBo"
        Me.btnHuyBo.Size = New System.Drawing.Size(77, 28)
        Me.btnHuyBo.TabIndex = 44
        Me.btnHuyBo.Text = "Hủy Bỏ"
        Me.btnHuyBo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.Add_Male_User_icon
        Me.PictureBox1.Location = New System.Drawing.Point(33, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(687, 76)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(77, 32)
        Me.btnXoa.TabIndex = 42
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(687, 43)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(77, 27)
        Me.btnSua.TabIndex = 41
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(687, 8)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(77, 29)
        Me.btnThem.TabIndex = 40
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCuoi
        '
        Me.btnCuoi.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.slide_10___Copy__3_
        Me.btnCuoi.Location = New System.Drawing.Point(687, 364)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(77, 46)
        Me.btnCuoi.TabIndex = 39
        Me.btnCuoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCuoi.UseVisualStyleBackColor = True
        '
        'btnPhai
        '
        Me.btnPhai.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.slide_10___Copy__2_
        Me.btnPhai.Location = New System.Drawing.Point(687, 308)
        Me.btnPhai.Name = "btnPhai"
        Me.btnPhai.Size = New System.Drawing.Size(77, 50)
        Me.btnPhai.TabIndex = 38
        Me.btnPhai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPhai.UseVisualStyleBackColor = True
        '
        'btnTrai
        '
        Me.btnTrai.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.slide_10___Copy__4_
        Me.btnTrai.Location = New System.Drawing.Point(687, 252)
        Me.btnTrai.Name = "btnTrai"
        Me.btnTrai.Size = New System.Drawing.Size(77, 50)
        Me.btnTrai.TabIndex = 37
        Me.btnTrai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnTrai.UseVisualStyleBackColor = True
        '
        'btnDau
        '
        Me.btnDau.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.slide_10___Copy
        Me.btnDau.Location = New System.Drawing.Point(687, 196)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(77, 50)
        Me.btnDau.TabIndex = 36
        Me.btnDau.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnDau.UseVisualStyleBackColor = True
        '
        'btnLuutxt
        '
        Me.btnLuutxt.Location = New System.Drawing.Point(687, 114)
        Me.btnLuutxt.Name = "btnLuutxt"
        Me.btnLuutxt.Size = New System.Drawing.Size(77, 29)
        Me.btnLuutxt.TabIndex = 45
        Me.btnLuutxt.Text = "Lưu Nháp"
        Me.btnLuutxt.UseVisualStyleBackColor = True
        '
        'ofdLuuKH
        '
        Me.ofdLuuKH.FileName = "OpenFileDialog1"
        '
        'frmQLKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 423)
        Me.Controls.Add(Me.btnLuutxt)
        Me.Controls.Add(Me.btnHuyBo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCuoi)
        Me.Controls.Add(Me.btnPhai)
        Me.Controls.Add(Me.btnTrai)
        Me.Controls.Add(Me.btnDau)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTenKH)
        Me.Controls.Add(Me.lblMaKH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLKhachHang"
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTenKH As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    Friend WithEvents btnPhai As System.Windows.Forms.Button
    Friend WithEvents btnTrai As System.Windows.Forms.Button
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents lblSDT As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHuyBo As System.Windows.Forms.Button
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents bsKH As System.Windows.Forms.BindingSource
    Friend WithEvents btnLuutxt As System.Windows.Forms.Button
    Friend WithEvents ofdLuuKH As System.Windows.Forms.OpenFileDialog
End Class
