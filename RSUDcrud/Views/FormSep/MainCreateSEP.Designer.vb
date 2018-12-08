<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainCreateSEP
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtCARI = New System.Windows.Forms.TextBox()
		Me.dgSEP = New System.Windows.Forms.DataGridView()
		Me.dtTANGGALSEP = New System.Windows.Forms.DateTimePicker()
		Me.cbCARABAYAR = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rbIGD = New System.Windows.Forms.RadioButton()
		Me.rbRI = New System.Windows.Forms.RadioButton()
		Me.rbRJ = New System.Windows.Forms.RadioButton()
		Me.btnAksi = New System.Windows.Forms.DataGridViewButtonColumn()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgSEP, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.RSUDcrud.My.Resources.Resources.logo
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 30)
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.UseWaitCursor = True
		Me.PictureBox1.WaitOnLoad = True
		'
		'txtCARI
		'
		Me.txtCARI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtCARI.Location = New System.Drawing.Point(736, 49)
		Me.txtCARI.Name = "txtCARI"
		Me.txtCARI.Size = New System.Drawing.Size(143, 20)
		Me.txtCARI.TabIndex = 16
		'
		'dgSEP
		'
		Me.dgSEP.AllowUserToAddRows = False
		Me.dgSEP.AllowUserToDeleteRows = False
		Me.dgSEP.AllowUserToResizeColumns = False
		Me.dgSEP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgSEP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgSEP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnAksi})
		Me.dgSEP.Location = New System.Drawing.Point(12, 76)
		Me.dgSEP.Name = "dgSEP"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		Me.dgSEP.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
		Me.dgSEP.RowHeadersVisible = False
		Me.dgSEP.Size = New System.Drawing.Size(867, 268)
		Me.dgSEP.TabIndex = 18
		'
		'dtTANGGALSEP
		'
		Me.dtTANGGALSEP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dtTANGGALSEP.CustomFormat = "dd-MM-yyyy"
		Me.dtTANGGALSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtTANGGALSEP.Location = New System.Drawing.Point(580, 49)
		Me.dtTANGGALSEP.Name = "dtTANGGALSEP"
		Me.dtTANGGALSEP.Size = New System.Drawing.Size(92, 20)
		Me.dtTANGGALSEP.TabIndex = 19
		'
		'cbCARABAYAR
		'
		Me.cbCARABAYAR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.cbCARABAYAR.FormattingEnabled = True
		Me.cbCARABAYAR.Location = New System.Drawing.Point(339, 48)
		Me.cbCARABAYAR.Name = "cbCARABAYAR"
		Me.cbCARABAYAR.Size = New System.Drawing.Size(149, 21)
		Me.cbCARABAYAR.TabIndex = 20
		Me.cbCARABAYAR.Text = "Pilih Jenis Bayar"
		'
		'Label1
		'
		Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(682, 52)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 13)
		Me.Label1.TabIndex = 21
		Me.Label1.Text = "NO RM"
		'
		'Label2
		'
		Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(494, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 13)
		Me.Label2.TabIndex = 22
		Me.Label2.Text = "Tanggal Reg"
		'
		'Label3
		'
		Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(261, 50)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(72, 13)
		Me.Label3.TabIndex = 23
		Me.Label3.Text = "Jenis Bayar"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.rbIGD)
		Me.GroupBox1.Controls.Add(Me.rbRI)
		Me.GroupBox1.Controls.Add(Me.rbRJ)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(243, 22)
		Me.GroupBox1.TabIndex = 24
		Me.GroupBox1.TabStop = False
		'
		'rbIGD
		'
		Me.rbIGD.AutoSize = True
		Me.rbIGD.Location = New System.Drawing.Point(187, 2)
		Me.rbIGD.Name = "rbIGD"
		Me.rbIGD.Size = New System.Drawing.Size(44, 17)
		Me.rbIGD.TabIndex = 29
		Me.rbIGD.TabStop = True
		Me.rbIGD.Text = "IGD"
		Me.rbIGD.UseVisualStyleBackColor = True
		'
		'rbRI
		'
		Me.rbRI.AutoSize = True
		Me.rbRI.Location = New System.Drawing.Point(101, 2)
		Me.rbRI.Name = "rbRI"
		Me.rbRI.Size = New System.Drawing.Size(80, 17)
		Me.rbRI.TabIndex = 28
		Me.rbRI.TabStop = True
		Me.rbRI.Text = "Rawat Inap"
		Me.rbRI.UseVisualStyleBackColor = True
		'
		'rbRJ
		'
		Me.rbRJ.AutoSize = True
		Me.rbRJ.Checked = True
		Me.rbRJ.Location = New System.Drawing.Point(11, 3)
		Me.rbRJ.Name = "rbRJ"
		Me.rbRJ.Size = New System.Drawing.Size(84, 17)
		Me.rbRJ.TabIndex = 27
		Me.rbRJ.TabStop = True
		Me.rbRJ.Text = "Rawat Jalan"
		Me.rbRJ.UseVisualStyleBackColor = True
		'
		'btnAksi
		'
		Me.btnAksi.HeaderText = "Aksi"
		Me.btnAksi.Name = "btnAksi"
		Me.btnAksi.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.btnAksi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.btnAksi.Text = "Cetak"
		Me.btnAksi.UseColumnTextForButtonValue = True
		Me.btnAksi.Width = 50
		'
		'MainCreateSEP
		'
		Me.ClientSize = New System.Drawing.Size(895, 356)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cbCARABAYAR)
		Me.Controls.Add(Me.dtTANGGALSEP)
		Me.Controls.Add(Me.dgSEP)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.txtCARI)
		Me.Name = "MainCreateSEP"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form Pembuatan Sep"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgSEP, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtCARI As TextBox
	Private WithEvents dgSEP As DataGridView
	Friend WithEvents dtTANGGALSEP As DateTimePicker
	Friend WithEvents cbCARABAYAR As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rbIGD As RadioButton
	Friend WithEvents rbRI As RadioButton
	Friend WithEvents rbRJ As RadioButton
	Friend WithEvents btnAksi As DataGridViewButtonColumn
End Class
