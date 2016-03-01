<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLySP))
        Me.TabQLSP = New System.Windows.Forms.TabControl()
        Me.TabTTSP = New System.Windows.Forms.TabPage()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.cboXuatXu = New System.Windows.Forms.ComboBox()
        Me.btnLuuNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoaSP = New System.Windows.Forms.Button()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.txtLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSp = New System.Windows.Forms.TextBox()
        Me.dgvSp = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabSP = New System.Windows.Forms.TabPage()
        Me.grbHinhSP = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblAsus = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblBlac = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSs = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblHtc = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLg5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.ptbHtcA9 = New System.Windows.Forms.PictureBox()
        Me.ptbLG5 = New System.Windows.Forms.PictureBox()
        Me.ptbAsus = New System.Windows.Forms.PictureBox()
        Me.ptbBkac = New System.Windows.Forms.PictureBox()
        Me.ptbSS = New System.Windows.Forms.PictureBox()
        Me.ptbIphone = New System.Windows.Forms.PictureBox()
        Me.grbTimKiem = New System.Windows.Forms.GroupBox()
        Me.btnSamSung = New System.Windows.Forms.Button()
        Me.btnIP = New System.Windows.Forms.Button()
        Me.btnThoate = New System.Windows.Forms.Button()
        Me.btnWiko = New System.Windows.Forms.Button()
        Me.btnXiaomi = New System.Windows.Forms.Button()
        Me.btnBlacberry = New System.Windows.Forms.Button()
        Me.btnLg = New System.Windows.Forms.Button()
        Me.btnHtc = New System.Windows.Forms.Button()
        Me.btnAsus = New System.Windows.Forms.Button()
        Me.ofdLuu = New System.Windows.Forms.OpenFileDialog()
        Me.bsSP = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabQLSP.SuspendLayout()
        Me.TabTTSP.SuspendLayout()
        CType(Me.dgvSp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSP.SuspendLayout()
        Me.grbHinhSP.SuspendLayout()
        CType(Me.ptbHtcA9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbLG5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbAsus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBkac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbIphone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTimKiem.SuspendLayout()
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabQLSP
        '
        Me.TabQLSP.Controls.Add(Me.TabTTSP)
        Me.TabQLSP.Controls.Add(Me.TabSP)
        Me.TabQLSP.Location = New System.Drawing.Point(1, 1)
        Me.TabQLSP.Name = "TabQLSP"
        Me.TabQLSP.SelectedIndex = 0
        Me.TabQLSP.Size = New System.Drawing.Size(795, 440)
        Me.TabQLSP.TabIndex = 0
        '
        'TabTTSP
        '
        Me.TabTTSP.BackColor = System.Drawing.Color.SeaShell
        Me.TabTTSP.Controls.Add(Me.btnHuy)
        Me.TabTTSP.Controls.Add(Me.cboXuatXu)
        Me.TabTTSP.Controls.Add(Me.btnLuuNhap)
        Me.TabTTSP.Controls.Add(Me.btnThoat)
        Me.TabTTSP.Controls.Add(Me.btnSua)
        Me.TabTTSP.Controls.Add(Me.btnXoaSP)
        Me.TabTTSP.Controls.Add(Me.btnThemSP)
        Me.TabTTSP.Controls.Add(Me.txtLoaiSP)
        Me.TabTTSP.Controls.Add(Me.txtTenSP)
        Me.TabTTSP.Controls.Add(Me.txtMaSp)
        Me.TabTTSP.Controls.Add(Me.dgvSp)
        Me.TabTTSP.Controls.Add(Me.Label4)
        Me.TabTTSP.Controls.Add(Me.Label3)
        Me.TabTTSP.Controls.Add(Me.Label2)
        Me.TabTTSP.Controls.Add(Me.Label1)
        Me.TabTTSP.Location = New System.Drawing.Point(4, 22)
        Me.TabTTSP.Name = "TabTTSP"
        Me.TabTTSP.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTTSP.Size = New System.Drawing.Size(787, 414)
        Me.TabTTSP.TabIndex = 0
        Me.TabTTSP.Text = "Thông Tin Sản Phẩm"
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(460, 143)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(146, 43)
        Me.btnHuy.TabIndex = 45
        Me.btnHuy.Text = "Hủy Bỏ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'cboXuatXu
        '
        Me.cboXuatXu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboXuatXu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboXuatXu.FormattingEnabled = True
        Me.cboXuatXu.Items.AddRange(New Object() {"Canada", "Trung Quốc", "Đài Loan", "Hàn Quốc", "Mỹ", "Nhật Bản", "Việt Nam"})
        Me.cboXuatXu.Location = New System.Drawing.Point(83, 116)
        Me.cboXuatXu.Name = "cboXuatXu"
        Me.cboXuatXu.Size = New System.Drawing.Size(129, 21)
        Me.cboXuatXu.TabIndex = 14
        '
        'btnLuuNhap
        '
        Me.btnLuuNhap.Location = New System.Drawing.Point(460, 6)
        Me.btnLuuNhap.Name = "btnLuuNhap"
        Me.btnLuuNhap.Size = New System.Drawing.Size(146, 38)
        Me.btnLuuNhap.TabIndex = 13
        Me.btnLuuNhap.Text = "Lưu Nháp"
        Me.btnLuuNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(460, 320)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(146, 34)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(541, 98)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(65, 34)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoaSP
        '
        Me.btnXoaSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaSP.Location = New System.Drawing.Point(460, 98)
        Me.btnXoaSP.Name = "btnXoaSP"
        Me.btnXoaSP.Size = New System.Drawing.Size(64, 34)
        Me.btnXoaSP.TabIndex = 10
        Me.btnXoaSP.Text = "Xóa"
        Me.btnXoaSP.UseVisualStyleBackColor = True
        '
        'btnThemSP
        '
        Me.btnThemSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSP.Location = New System.Drawing.Point(460, 50)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.Size = New System.Drawing.Size(146, 33)
        Me.btnThemSP.TabIndex = 9
        Me.btnThemSP.Text = "Thêm "
        Me.btnThemSP.UseVisualStyleBackColor = True
        '
        'txtLoaiSP
        '
        Me.txtLoaiSP.BackColor = System.Drawing.Color.MistyRose
        Me.txtLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoaiSP.Location = New System.Drawing.Point(83, 82)
        Me.txtLoaiSP.Multiline = True
        Me.txtLoaiSP.Name = "txtLoaiSP"
        Me.txtLoaiSP.Size = New System.Drawing.Size(129, 20)
        Me.txtLoaiSP.TabIndex = 4
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(83, 49)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(217, 20)
        Me.txtTenSP.TabIndex = 3
        '
        'txtMaSp
        '
        Me.txtMaSp.BackColor = System.Drawing.Color.MistyRose
        Me.txtMaSp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaSp.Location = New System.Drawing.Point(83, 11)
        Me.txtMaSp.Multiline = True
        Me.txtMaSp.Name = "txtMaSp"
        Me.txtMaSp.Size = New System.Drawing.Size(129, 20)
        Me.txtMaSp.TabIndex = 2
        '
        'dgvSp
        '
        Me.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSp.Location = New System.Drawing.Point(7, 158)
        Me.dgvSp.Name = "dgvSp"
        Me.dgvSp.Size = New System.Drawing.Size(447, 196)
        Me.dgvSp.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Xuất xứ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã loại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'TabSP
        '
        Me.TabSP.BackColor = System.Drawing.Color.Honeydew
        Me.TabSP.Controls.Add(Me.grbHinhSP)
        Me.TabSP.Controls.Add(Me.grbTimKiem)
        Me.TabSP.Location = New System.Drawing.Point(4, 22)
        Me.TabSP.Name = "TabSP"
        Me.TabSP.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSP.Size = New System.Drawing.Size(787, 414)
        Me.TabSP.TabIndex = 1
        Me.TabSP.Text = "Danh Sách Điện Thoại"
        '
        'grbHinhSP
        '
        Me.grbHinhSP.BackColor = System.Drawing.Color.LightCyan
        Me.grbHinhSP.Controls.Add(Me.Label17)
        Me.grbHinhSP.Controls.Add(Me.lblAsus)
        Me.grbHinhSP.Controls.Add(Me.Label15)
        Me.grbHinhSP.Controls.Add(Me.lblBlac)
        Me.grbHinhSP.Controls.Add(Me.Label13)
        Me.grbHinhSP.Controls.Add(Me.lblSs)
        Me.grbHinhSP.Controls.Add(Me.Label11)
        Me.grbHinhSP.Controls.Add(Me.lblHtc)
        Me.grbHinhSP.Controls.Add(Me.Label9)
        Me.grbHinhSP.Controls.Add(Me.lblLg5)
        Me.grbHinhSP.Controls.Add(Me.Label6)
        Me.grbHinhSP.Controls.Add(Me.lblIp)
        Me.grbHinhSP.Controls.Add(Me.ptbHtcA9)
        Me.grbHinhSP.Controls.Add(Me.ptbLG5)
        Me.grbHinhSP.Controls.Add(Me.ptbAsus)
        Me.grbHinhSP.Controls.Add(Me.ptbBkac)
        Me.grbHinhSP.Controls.Add(Me.ptbSS)
        Me.grbHinhSP.Controls.Add(Me.ptbIphone)
        Me.grbHinhSP.Location = New System.Drawing.Point(118, 7)
        Me.grbHinhSP.Name = "grbHinhSP"
        Me.grbHinhSP.Size = New System.Drawing.Size(490, 347)
        Me.grbHinhSP.TabIndex = 1
        Me.grbHinhSP.TabStop = False
        Me.grbHinhSP.Text = "Sản Phẩm"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(378, 317)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "6.500.000₫ "
        '
        'lblAsus
        '
        Me.lblAsus.AutoSize = True
        Me.lblAsus.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblAsus.Location = New System.Drawing.Point(361, 296)
        Me.lblAsus.Name = "lblAsus"
        Me.lblAsus.Size = New System.Drawing.Size(115, 15)
        Me.lblAsus.TabIndex = 1
        Me.lblAsus.Text = "Asus Z002 Zenfone 6"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(196, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "12.900.000₫ "
        '
        'lblBlac
        '
        Me.lblBlac.AutoSize = True
        Me.lblBlac.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlac.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblBlac.Location = New System.Drawing.Point(176, 296)
        Me.lblBlac.Name = "lblBlac"
        Me.lblBlac.Size = New System.Drawing.Size(131, 15)
        Me.lblBlac.TabIndex = 1
        Me.lblBlac.Text = "Blackberry PP SQW100"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(30, 317)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "17.490.000₫ "
        '
        'lblSs
        '
        Me.lblSs.AutoSize = True
        Me.lblSs.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblSs.Location = New System.Drawing.Point(7, 296)
        Me.lblSs.Name = "lblSs"
        Me.lblSs.Size = New System.Drawing.Size(116, 15)
        Me.lblSs.TabIndex = 1
        Me.lblSs.Text = "SamSung Galazy S6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(378, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "11.590.000₫ "
        '
        'lblHtc
        '
        Me.lblHtc.AutoSize = True
        Me.lblHtc.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHtc.Location = New System.Drawing.Point(378, 119)
        Me.lblHtc.Name = "lblHtc"
        Me.lblHtc.Size = New System.Drawing.Size(75, 15)
        Me.lblHtc.TabIndex = 1
        Me.lblHtc.Text = "HTC One A9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(196, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "13.990.000₫ "
        '
        'lblLg5
        '
        Me.lblLg5.AutoSize = True
        Me.lblLg5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLg5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLg5.Location = New System.Drawing.Point(196, 119)
        Me.lblLg5.Name = "lblLg5"
        Me.lblLg5.Size = New System.Drawing.Size(85, 15)
        Me.lblLg5.TabIndex = 1
        Me.lblLg5.Text = "LG G4 Leather"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(30, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "24.790.000₫ "
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblIp.Location = New System.Drawing.Point(7, 119)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(120, 15)
        Me.lblIp.TabIndex = 1
        Me.lblIp.Text = " IPhone 6 Plus 128GB"
        '
        'ptbHtcA9
        '
        Me.ptbHtcA9.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.hero_htc_one_a9_400x534
        Me.ptbHtcA9.Location = New System.Drawing.Point(355, 18)
        Me.ptbHtcA9.Name = "ptbHtcA9"
        Me.ptbHtcA9.Size = New System.Drawing.Size(121, 95)
        Me.ptbHtcA9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbHtcA9.TabIndex = 0
        Me.ptbHtcA9.TabStop = False
        '
        'ptbLG5
        '
        Me.ptbLG5.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.lg_g4_leather2_new_400x436
        Me.ptbLG5.Location = New System.Drawing.Point(179, 18)
        Me.ptbLG5.Name = "ptbLG5"
        Me.ptbLG5.Size = New System.Drawing.Size(121, 95)
        Me.ptbLG5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbLG5.TabIndex = 0
        Me.ptbLG5.TabStop = False
        '
        'ptbAsus
        '
        Me.ptbAsus.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.ASUS_ZENFONE_6_VANG
        Me.ptbAsus.Location = New System.Drawing.Point(355, 194)
        Me.ptbAsus.Name = "ptbAsus"
        Me.ptbAsus.Size = New System.Drawing.Size(121, 93)
        Me.ptbAsus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbAsus.TabIndex = 0
        Me.ptbAsus.TabStop = False
        '
        'ptbBkac
        '
        Me.ptbBkac.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.BB_PASSPORT_Ð
        Me.ptbBkac.Location = New System.Drawing.Point(179, 194)
        Me.ptbBkac.Name = "ptbBkac"
        Me.ptbBkac.Size = New System.Drawing.Size(121, 93)
        Me.ptbBkac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbBkac.TabIndex = 0
        Me.ptbBkac.TabStop = False
        '
        'ptbSS
        '
        Me.ptbSS.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.smartaccessories
        Me.ptbSS.Location = New System.Drawing.Point(7, 194)
        Me.ptbSS.Name = "ptbSS"
        Me.ptbSS.Size = New System.Drawing.Size(121, 93)
        Me.ptbSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbSS.TabIndex = 0
        Me.ptbSS.TabStop = False
        '
        'ptbIphone
        '
        Me.ptbIphone.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.iphone_6_plus_128gb
        Me.ptbIphone.Location = New System.Drawing.Point(7, 20)
        Me.ptbIphone.Name = "ptbIphone"
        Me.ptbIphone.Size = New System.Drawing.Size(121, 93)
        Me.ptbIphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbIphone.TabIndex = 0
        Me.ptbIphone.TabStop = False
        '
        'grbTimKiem
        '
        Me.grbTimKiem.BackColor = System.Drawing.Color.LightCyan
        Me.grbTimKiem.Controls.Add(Me.btnSamSung)
        Me.grbTimKiem.Controls.Add(Me.btnIP)
        Me.grbTimKiem.Controls.Add(Me.btnThoate)
        Me.grbTimKiem.Controls.Add(Me.btnWiko)
        Me.grbTimKiem.Controls.Add(Me.btnXiaomi)
        Me.grbTimKiem.Controls.Add(Me.btnBlacberry)
        Me.grbTimKiem.Controls.Add(Me.btnLg)
        Me.grbTimKiem.Controls.Add(Me.btnHtc)
        Me.grbTimKiem.Controls.Add(Me.btnAsus)
        Me.grbTimKiem.Location = New System.Drawing.Point(8, 6)
        Me.grbTimKiem.Name = "grbTimKiem"
        Me.grbTimKiem.Size = New System.Drawing.Size(104, 348)
        Me.grbTimKiem.TabIndex = 0
        Me.grbTimKiem.TabStop = False
        Me.grbTimKiem.Text = "Tìm Kiếm"
        '
        'btnSamSung
        '
        Me.btnSamSung.Location = New System.Drawing.Point(7, 225)
        Me.btnSamSung.Name = "btnSamSung"
        Me.btnSamSung.Size = New System.Drawing.Size(88, 27)
        Me.btnSamSung.TabIndex = 9
        Me.btnSamSung.Text = "SamSung"
        Me.btnSamSung.UseVisualStyleBackColor = True
        '
        'btnIP
        '
        Me.btnIP.Location = New System.Drawing.Point(7, 258)
        Me.btnIP.Name = "btnIP"
        Me.btnIP.Size = New System.Drawing.Size(88, 26)
        Me.btnIP.TabIndex = 8
        Me.btnIP.Text = "Iphone"
        Me.btnIP.UseVisualStyleBackColor = True
        '
        'btnThoate
        '
        Me.btnThoate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnThoate.Location = New System.Drawing.Point(6, 318)
        Me.btnThoate.Name = "btnThoate"
        Me.btnThoate.Size = New System.Drawing.Size(89, 24)
        Me.btnThoate.TabIndex = 7
        Me.btnThoate.Text = "Thoát"
        Me.btnThoate.UseVisualStyleBackColor = True
        '
        'btnWiko
        '
        Me.btnWiko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnWiko.Location = New System.Drawing.Point(6, 190)
        Me.btnWiko.Name = "btnWiko"
        Me.btnWiko.Size = New System.Drawing.Size(89, 29)
        Me.btnWiko.TabIndex = 6
        Me.btnWiko.Text = "Wiko"
        Me.btnWiko.UseVisualStyleBackColor = True
        '
        'btnXiaomi
        '
        Me.btnXiaomi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnXiaomi.Location = New System.Drawing.Point(6, 155)
        Me.btnXiaomi.Name = "btnXiaomi"
        Me.btnXiaomi.Size = New System.Drawing.Size(89, 29)
        Me.btnXiaomi.TabIndex = 5
        Me.btnXiaomi.Text = "Xiaomi"
        Me.btnXiaomi.UseVisualStyleBackColor = True
        '
        'btnBlacberry
        '
        Me.btnBlacberry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBlacberry.Location = New System.Drawing.Point(6, 120)
        Me.btnBlacberry.Name = "btnBlacberry"
        Me.btnBlacberry.Size = New System.Drawing.Size(89, 29)
        Me.btnBlacberry.TabIndex = 4
        Me.btnBlacberry.Text = "Blackberry"
        Me.btnBlacberry.UseVisualStyleBackColor = True
        '
        'btnLg
        '
        Me.btnLg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLg.Location = New System.Drawing.Point(6, 85)
        Me.btnLg.Name = "btnLg"
        Me.btnLg.Size = New System.Drawing.Size(89, 29)
        Me.btnLg.TabIndex = 3
        Me.btnLg.Text = "LG"
        Me.btnLg.UseVisualStyleBackColor = True
        '
        'btnHtc
        '
        Me.btnHtc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHtc.Location = New System.Drawing.Point(6, 52)
        Me.btnHtc.Name = "btnHtc"
        Me.btnHtc.Size = New System.Drawing.Size(89, 27)
        Me.btnHtc.TabIndex = 2
        Me.btnHtc.Text = "HTC"
        Me.btnHtc.UseVisualStyleBackColor = True
        '
        'btnAsus
        '
        Me.btnAsus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAsus.Location = New System.Drawing.Point(6, 19)
        Me.btnAsus.Name = "btnAsus"
        Me.btnAsus.Size = New System.Drawing.Size(89, 27)
        Me.btnAsus.TabIndex = 1
        Me.btnAsus.Text = "ASUS"
        Me.btnAsus.UseVisualStyleBackColor = True
        '
        'ofdLuu
        '
        Me.ofdLuu.FileName = "OpenFileDialog1"
        '
        'frmQuanLySP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 389)
        Me.Controls.Add(Me.TabQLSP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLySP"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.TabQLSP.ResumeLayout(False)
        Me.TabTTSP.ResumeLayout(False)
        Me.TabTTSP.PerformLayout()
        CType(Me.dgvSp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSP.ResumeLayout(False)
        Me.grbHinhSP.ResumeLayout(False)
        Me.grbHinhSP.PerformLayout()
        CType(Me.ptbHtcA9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbLG5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbAsus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBkac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbIphone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTimKiem.ResumeLayout(False)
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabQLSP As System.Windows.Forms.TabControl
    Friend WithEvents TabTTSP As System.Windows.Forms.TabPage
    Friend WithEvents txtLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSp As System.Windows.Forms.TextBox
    Friend WithEvents dgvSp As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabSP As System.Windows.Forms.TabPage
    Friend WithEvents btnLuuNhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoaSP As System.Windows.Forms.Button
    Friend WithEvents btnThemSP As System.Windows.Forms.Button
    Friend WithEvents cboXuatXu As System.Windows.Forms.ComboBox
    Friend WithEvents bsSP As System.Windows.Forms.BindingSource
    Friend WithEvents ofdLuu As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbHinhSP As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblAsus As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblBlac As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSs As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblHtc As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblLg5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents ptbHtcA9 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbLG5 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbAsus As System.Windows.Forms.PictureBox
    Friend WithEvents ptbBkac As System.Windows.Forms.PictureBox
    Friend WithEvents ptbSS As System.Windows.Forms.PictureBox
    Friend WithEvents ptbIphone As System.Windows.Forms.PictureBox
    Friend WithEvents grbTimKiem As System.Windows.Forms.GroupBox
    Friend WithEvents btnSamSung As System.Windows.Forms.Button
    Friend WithEvents btnIP As System.Windows.Forms.Button
    Friend WithEvents btnThoate As System.Windows.Forms.Button
    Friend WithEvents btnWiko As System.Windows.Forms.Button
    Friend WithEvents btnXiaomi As System.Windows.Forms.Button
    Friend WithEvents btnBlacberry As System.Windows.Forms.Button
    Friend WithEvents btnLg As System.Windows.Forms.Button
    Friend WithEvents btnHtc As System.Windows.Forms.Button
    Friend WithEvents btnAsus As System.Windows.Forms.Button
    Friend WithEvents btnHuy As System.Windows.Forms.Button
End Class
