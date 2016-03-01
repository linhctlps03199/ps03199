<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLy))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnQLHD = New System.Windows.Forms.Button()
        Me.btnGioiThieu = New System.Windows.Forms.Button()
        Me.btnBaoCao = New System.Windows.Forms.Button()
        Me.btnQLKH = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblClock})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(678, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(212, 17)
        Me.ToolStripStatusLabel1.Text = "Design By Chau Thi Lan Linh - PS03199"
        '
        'lblClock
        '
        Me.lblClock.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.cl
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(53, 17)
        Me.lblClock.Text = "Clock"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnSanPham
        '
        Me.btnSanPham.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.shop_1
        Me.btnSanPham.Location = New System.Drawing.Point(409, 225)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(126, 133)
        Me.btnSanPham.TabIndex = 10
        Me.btnSanPham.Text = "QUẢN LÝ SẢN PHẨM"
        Me.btnSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnQLHD
        '
        Me.btnQLHD.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.bill_of_document
        Me.btnQLHD.Location = New System.Drawing.Point(277, 225)
        Me.btnQLHD.Name = "btnQLHD"
        Me.btnQLHD.Size = New System.Drawing.Size(126, 133)
        Me.btnQLHD.TabIndex = 9
        Me.btnQLHD.Text = "QUẢN LÝ HÓA ĐƠN"
        Me.btnQLHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQLHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQLHD.UseMnemonic = False
        Me.btnQLHD.UseVisualStyleBackColor = True
        '
        'btnGioiThieu
        '
        Me.btnGioiThieu.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.Capture
        Me.btnGioiThieu.Location = New System.Drawing.Point(13, 225)
        Me.btnGioiThieu.Name = "btnGioiThieu"
        Me.btnGioiThieu.Size = New System.Drawing.Size(126, 133)
        Me.btnGioiThieu.TabIndex = 8
        Me.btnGioiThieu.Text = "GIỚI THIỆU"
        Me.btnGioiThieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGioiThieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnGioiThieu.UseVisualStyleBackColor = True
        '
        'btnBaoCao
        '
        Me.btnBaoCao.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.chart_icon
        Me.btnBaoCao.Location = New System.Drawing.Point(542, 225)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Size = New System.Drawing.Size(126, 133)
        Me.btnBaoCao.TabIndex = 7
        Me.btnBaoCao.Text = "BÁO CÁO - THỐNG KÊ"
        Me.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBaoCao.UseVisualStyleBackColor = True
        '
        'btnQLKH
        '
        Me.btnQLKH.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.nhan_su
        Me.btnQLKH.Location = New System.Drawing.Point(145, 225)
        Me.btnQLKH.Name = "btnQLKH"
        Me.btnQLKH.Size = New System.Drawing.Size(126, 133)
        Me.btnQLKH.TabIndex = 2
        Me.btnQLKH.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.btnQLKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQLKH.UseMnemonic = False
        Me.btnQLKH.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Asignment_PS03199_INF205.My.Resources.Resources.banner
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(655, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmQuanLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(678, 392)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnQLHD)
        Me.Controls.Add(Me.btnGioiThieu)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.btnQLKH)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLy"
        Me.Text = "Quản Lý Điện Thoại"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblClock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnQLKH As System.Windows.Forms.Button
    Friend WithEvents btnBaoCao As System.Windows.Forms.Button
    Friend WithEvents btnGioiThieu As System.Windows.Forms.Button
    Friend WithEvents btnQLHD As System.Windows.Forms.Button
    Friend WithEvents btnSanPham As System.Windows.Forms.Button
End Class
