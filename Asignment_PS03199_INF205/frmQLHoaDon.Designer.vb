<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLHoaDon))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvHD = New System.Windows.Forms.DataGridView()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnHuyHD = New System.Windows.Forms.Button()
        Me.btnXoaHD = New System.Windows.Forms.Button()
        Me.btnSuaHD = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cboMaSP = New System.Windows.Forms.ComboBox()
        Me.txtSoHD = New System.Windows.Forms.TextBox()
        Me.bsHD = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNgayHD = New System.Windows.Forms.TextBox()
        Me.txtMkh = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.nudSoLuong = New System.Windows.Forms.TextBox()
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số hóa đơn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ngày hóa đơn:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã khách hàng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Đơn giá:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số lượng:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mã sản phẩm:"
        '
        'dgvHD
        '
        Me.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHD.Location = New System.Drawing.Point(12, 141)
        Me.dgvHD.Name = "dgvHD"
        Me.dgvHD.Size = New System.Drawing.Size(594, 187)
        Me.dgvHD.TabIndex = 1
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(514, 343)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(93, 33)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnHuyHD
        '
        Me.btnHuyHD.Location = New System.Drawing.Point(285, 343)
        Me.btnHuyHD.Name = "btnHuyHD"
        Me.btnHuyHD.Size = New System.Drawing.Size(83, 33)
        Me.btnHuyHD.TabIndex = 2
        Me.btnHuyHD.Text = "Hủy"
        Me.btnHuyHD.UseVisualStyleBackColor = True
        '
        'btnXoaHD
        '
        Me.btnXoaHD.Location = New System.Drawing.Point(195, 343)
        Me.btnXoaHD.Name = "btnXoaHD"
        Me.btnXoaHD.Size = New System.Drawing.Size(84, 33)
        Me.btnXoaHD.TabIndex = 2
        Me.btnXoaHD.Text = "Xóa"
        Me.btnXoaHD.UseVisualStyleBackColor = True
        '
        'btnSuaHD
        '
        Me.btnSuaHD.Location = New System.Drawing.Point(103, 343)
        Me.btnSuaHD.Name = "btnSuaHD"
        Me.btnSuaHD.Size = New System.Drawing.Size(86, 33)
        Me.btnSuaHD.TabIndex = 2
        Me.btnSuaHD.Text = "Sửa"
        Me.btnSuaHD.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(12, 343)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(85, 33)
        Me.btnCapNhat.TabIndex = 2
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtDonGia
        '
        Me.txtDonGia.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDonGia.Location = New System.Drawing.Point(441, 42)
        Me.txtDonGia.Multiline = True
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(165, 25)
        Me.txtDonGia.TabIndex = 3
        '
        'cboMaSP
        '
        Me.cboMaSP.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaSP.FormattingEnabled = True
        Me.cboMaSP.Location = New System.Drawing.Point(441, 6)
        Me.cboMaSP.Name = "cboMaSP"
        Me.cboMaSP.Size = New System.Drawing.Size(136, 21)
        Me.cboMaSP.TabIndex = 4
        '
        'txtSoHD
        '
        Me.txtSoHD.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSoHD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSoHD.Location = New System.Drawing.Point(103, 6)
        Me.txtSoHD.Multiline = True
        Me.txtSoHD.Name = "txtSoHD"
        Me.txtSoHD.Size = New System.Drawing.Size(107, 20)
        Me.txtSoHD.TabIndex = 7
        '
        'txtNgayHD
        '
        Me.txtNgayHD.Location = New System.Drawing.Point(103, 42)
        Me.txtNgayHD.Name = "txtNgayHD"
        Me.txtNgayHD.Size = New System.Drawing.Size(141, 20)
        Me.txtNgayHD.TabIndex = 8
        '
        'txtMkh
        '
        Me.txtMkh.Location = New System.Drawing.Point(103, 75)
        Me.txtMkh.Name = "txtMkh"
        Me.txtMkh.Size = New System.Drawing.Size(107, 20)
        Me.txtMkh.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Thành tiền:"
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(441, 92)
        Me.txtThanhTien.Multiline = True
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(165, 29)
        Me.txtThanhTien.TabIndex = 3
        '
        'nudSoLuong
        '
        Me.nudSoLuong.Location = New System.Drawing.Point(103, 105)
        Me.nudSoLuong.Name = "nudSoLuong"
        Me.nudSoLuong.Size = New System.Drawing.Size(99, 20)
        Me.nudSoLuong.TabIndex = 10
        '
        'frmQLHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(619, 388)
        Me.Controls.Add(Me.nudSoLuong)
        Me.Controls.Add(Me.txtMkh)
        Me.Controls.Add(Me.txtNgayHD)
        Me.Controls.Add(Me.txtSoHD)
        Me.Controls.Add(Me.cboMaSP)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnSuaHD)
        Me.Controls.Add(Me.btnXoaHD)
        Me.Controls.Add(Me.btnHuyHD)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.dgvHD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQLHoaDon"
        Me.Text = "Quản Lý Hóa Đơn"
        CType(Me.dgvHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvHD As System.Windows.Forms.DataGridView
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnHuyHD As System.Windows.Forms.Button
    Friend WithEvents btnXoaHD As System.Windows.Forms.Button
    Friend WithEvents btnSuaHD As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents cboMaSP As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoHD As System.Windows.Forms.TextBox
    Friend WithEvents bsHD As System.Windows.Forms.BindingSource
    Friend WithEvents txtNgayHD As System.Windows.Forms.TextBox
    Friend WithEvents txtMkh As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtThanhTien As System.Windows.Forms.TextBox
    Friend WithEvents nudSoLuong As System.Windows.Forms.TextBox
End Class
