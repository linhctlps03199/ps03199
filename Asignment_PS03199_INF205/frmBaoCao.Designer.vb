<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaoCao))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvTK1 = New System.Windows.Forms.DataGridView()
        Me.bsMaKH = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboMKH = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTK1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã Khách Hàng:"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(588, 46)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 9
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvTK1
        '
        Me.dgvTK1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTK1.Location = New System.Drawing.Point(12, 75)
        Me.dgvTK1.Name = "dgvTK1"
        Me.dgvTK1.Size = New System.Drawing.Size(651, 204)
        Me.dgvTK1.TabIndex = 6
        '
        'cboMKH
        '
        Me.cboMKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMKH.FormattingEnabled = True
        Me.cboMKH.Location = New System.Drawing.Point(118, 33)
        Me.cboMKH.Name = "cboMKH"
        Me.cboMKH.Size = New System.Drawing.Size(130, 21)
        Me.cboMKH.TabIndex = 12
        '
        'frmBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 291)
        Me.Controls.Add(Me.cboMKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvTK1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBaoCao"
        Me.Text = "Báo Cáo - Thống Kê"
        CType(Me.dgvTK1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvTK1 As System.Windows.Forms.DataGridView
    Friend WithEvents bsMaKH As System.Windows.Forms.BindingSource
    Friend WithEvents cboMKH As System.Windows.Forms.ComboBox
End Class
