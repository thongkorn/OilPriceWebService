<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOilPriceThai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOilPriceThai))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDieselPremium = New System.Windows.Forms.TextBox()
        Me.txtDieselB7 = New System.Windows.Forms.TextBox()
        Me.txtDiesel = New System.Windows.Forms.TextBox()
        Me.txtDieselB20 = New System.Windows.Forms.TextBox()
        Me.txtBenzine = New System.Windows.Forms.TextBox()
        Me.txtGasohol95 = New System.Windows.Forms.TextBox()
        Me.txtGasohol91 = New System.Windows.Forms.TextBox()
        Me.txtGasoholE20 = New System.Windows.Forms.TextBox()
        Me.txtGasoholE85 = New System.Windows.Forms.TextBox()
        Me.txtNGV = New System.Windows.Forms.TextBox()
        Me.dtpDateOilPrice = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAmphur = New System.Windows.Forms.ComboBox()
        Me.lblDateOilPrice = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 514)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtDieselPremium
        '
        Me.txtDieselPremium.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDieselPremium.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDieselPremium.Location = New System.Drawing.Point(114, 57)
        Me.txtDieselPremium.Name = "txtDieselPremium"
        Me.txtDieselPremium.Size = New System.Drawing.Size(123, 38)
        Me.txtDieselPremium.TabIndex = 1
        Me.txtDieselPremium.TabStop = False
        Me.txtDieselPremium.Text = "0.00"
        Me.txtDieselPremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDieselB7
        '
        Me.txtDieselB7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDieselB7.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDieselB7.Location = New System.Drawing.Point(114, 99)
        Me.txtDieselB7.Name = "txtDieselB7"
        Me.txtDieselB7.Size = New System.Drawing.Size(123, 38)
        Me.txtDieselB7.TabIndex = 2
        Me.txtDieselB7.TabStop = False
        Me.txtDieselB7.Text = "0.00"
        Me.txtDieselB7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiesel
        '
        Me.txtDiesel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiesel.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiesel.Location = New System.Drawing.Point(114, 140)
        Me.txtDiesel.Name = "txtDiesel"
        Me.txtDiesel.Size = New System.Drawing.Size(123, 38)
        Me.txtDiesel.TabIndex = 3
        Me.txtDiesel.TabStop = False
        Me.txtDiesel.Text = "0.00"
        Me.txtDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDieselB20
        '
        Me.txtDieselB20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDieselB20.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDieselB20.Location = New System.Drawing.Point(114, 180)
        Me.txtDieselB20.Name = "txtDieselB20"
        Me.txtDieselB20.Size = New System.Drawing.Size(123, 38)
        Me.txtDieselB20.TabIndex = 4
        Me.txtDieselB20.TabStop = False
        Me.txtDieselB20.Text = "0.00"
        Me.txtDieselB20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBenzine
        '
        Me.txtBenzine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBenzine.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBenzine.Location = New System.Drawing.Point(114, 220)
        Me.txtBenzine.Name = "txtBenzine"
        Me.txtBenzine.Size = New System.Drawing.Size(123, 38)
        Me.txtBenzine.TabIndex = 5
        Me.txtBenzine.TabStop = False
        Me.txtBenzine.Text = "0.00"
        Me.txtBenzine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGasohol95
        '
        Me.txtGasohol95.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGasohol95.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasohol95.Location = New System.Drawing.Point(114, 261)
        Me.txtGasohol95.Name = "txtGasohol95"
        Me.txtGasohol95.Size = New System.Drawing.Size(123, 38)
        Me.txtGasohol95.TabIndex = 6
        Me.txtGasohol95.TabStop = False
        Me.txtGasohol95.Text = "0.00"
        Me.txtGasohol95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGasohol91
        '
        Me.txtGasohol91.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGasohol91.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasohol91.Location = New System.Drawing.Point(115, 301)
        Me.txtGasohol91.Name = "txtGasohol91"
        Me.txtGasohol91.Size = New System.Drawing.Size(123, 38)
        Me.txtGasohol91.TabIndex = 7
        Me.txtGasohol91.TabStop = False
        Me.txtGasohol91.Text = "0.00"
        Me.txtGasohol91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGasoholE20
        '
        Me.txtGasoholE20.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGasoholE20.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasoholE20.Location = New System.Drawing.Point(114, 341)
        Me.txtGasoholE20.Name = "txtGasoholE20"
        Me.txtGasoholE20.Size = New System.Drawing.Size(123, 38)
        Me.txtGasoholE20.TabIndex = 8
        Me.txtGasoholE20.TabStop = False
        Me.txtGasoholE20.Text = "0.00"
        Me.txtGasoholE20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGasoholE85
        '
        Me.txtGasoholE85.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGasoholE85.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGasoholE85.Location = New System.Drawing.Point(114, 381)
        Me.txtGasoholE85.Name = "txtGasoholE85"
        Me.txtGasoholE85.Size = New System.Drawing.Size(123, 38)
        Me.txtGasoholE85.TabIndex = 9
        Me.txtGasoholE85.TabStop = False
        Me.txtGasoholE85.Text = "0.00"
        Me.txtGasoholE85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNGV
        '
        Me.txtNGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNGV.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNGV.Location = New System.Drawing.Point(115, 421)
        Me.txtNGV.Name = "txtNGV"
        Me.txtNGV.Size = New System.Drawing.Size(123, 38)
        Me.txtNGV.TabIndex = 10
        Me.txtNGV.TabStop = False
        Me.txtNGV.Text = "0.00"
        Me.txtNGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDateOilPrice
        '
        Me.dtpDateOilPrice.Location = New System.Drawing.Point(245, 32)
        Me.dtpDateOilPrice.Name = "dtpDateOilPrice"
        Me.dtpDateOilPrice.Size = New System.Drawing.Size(200, 26)
        Me.dtpDateOilPrice.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "เลือกวันที่"
        '
        'cmbProvince
        '
        Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.IntegralHeight = False
        Me.cmbProvince.Location = New System.Drawing.Point(245, 84)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(200, 26)
        Me.cmbProvince.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "เลือกจังหวัด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "เลือกอำเภอ"
        '
        'cmbAmphur
        '
        Me.cmbAmphur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAmphur.FormattingEnabled = True
        Me.cmbAmphur.IntegralHeight = False
        Me.cmbAmphur.Location = New System.Drawing.Point(245, 138)
        Me.cmbAmphur.Name = "cmbAmphur"
        Me.cmbAmphur.Size = New System.Drawing.Size(200, 26)
        Me.cmbAmphur.TabIndex = 2
        '
        'lblDateOilPrice
        '
        Me.lblDateOilPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblDateOilPrice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateOilPrice.Location = New System.Drawing.Point(2, 38)
        Me.lblDateOilPrice.Name = "lblDateOilPrice"
        Me.lblDateOilPrice.Size = New System.Drawing.Size(235, 17)
        Me.lblDateOilPrice.TabIndex = 16
        Me.lblDateOilPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(2, 481)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(235, 28)
        Me.lblLocation.TabIndex = 17
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(454, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(189, 17)
        Me.ToolStripStatusLabel1.Text = "ผู้พัฒนาโปรแกรม: นายสุรพล ยอดสง่า"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(171, 17)
        Me.ToolStripStatusLabel2.Text = "www.facebook.com/g2gnet"
        '
        'frmOilPriceThai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 537)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDateOilPrice)
        Me.Controls.Add(Me.cmbAmphur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProvince)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateOilPrice)
        Me.Controls.Add(Me.txtNGV)
        Me.Controls.Add(Me.txtGasoholE85)
        Me.Controls.Add(Me.txtGasoholE20)
        Me.Controls.Add(Me.txtGasohol91)
        Me.Controls.Add(Me.txtGasohol95)
        Me.Controls.Add(Me.txtBenzine)
        Me.Controls.Add(Me.txtDieselB20)
        Me.Controls.Add(Me.txtDiesel)
        Me.Controls.Add(Me.txtDieselB7)
        Me.Controls.Add(Me.txtDieselPremium)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOilPriceThai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oil Price PTT Station Thailand"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDieselPremium As System.Windows.Forms.TextBox
    Friend WithEvents txtDieselB7 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiesel As System.Windows.Forms.TextBox
    Friend WithEvents txtDieselB20 As System.Windows.Forms.TextBox
    Friend WithEvents txtBenzine As System.Windows.Forms.TextBox
    Friend WithEvents txtGasohol95 As System.Windows.Forms.TextBox
    Friend WithEvents txtGasohol91 As System.Windows.Forms.TextBox
    Friend WithEvents txtGasoholE20 As System.Windows.Forms.TextBox
    Friend WithEvents txtGasoholE85 As System.Windows.Forms.TextBox
    Friend WithEvents txtNGV As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateOilPrice As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAmphur As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateOilPrice As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

End Class
