<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestPasien
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
		Me.txtRM = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnGET = New System.Windows.Forms.Button()
		Me.txtTEMPATLAHIR = New System.Windows.Forms.TextBox()
		Me.txtALAMAT = New System.Windows.Forms.TextBox()
		Me.txtTANGGALLAHIR = New System.Windows.Forms.TextBox()
		Me.txtNOTELP = New System.Windows.Forms.TextBox()
		Me.txtJENISKELAMIN = New System.Windows.Forms.TextBox()
		Me.txtJENISPASIEN = New System.Windows.Forms.TextBox()
		Me.txtNAMA = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtRM
		'
		Me.txtRM.Location = New System.Drawing.Point(12, 50)
		Me.txtRM.Name = "txtRM"
		Me.txtRM.Size = New System.Drawing.Size(162, 20)
		Me.txtRM.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(232, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "COBA REST API"
		'
		'btnGET
		'
		Me.btnGET.Location = New System.Drawing.Point(180, 50)
		Me.btnGET.Name = "btnGET"
		Me.btnGET.Size = New System.Drawing.Size(75, 23)
		Me.btnGET.TabIndex = 2
		Me.btnGET.Text = "Get"
		Me.btnGET.UseVisualStyleBackColor = True
		'
		'txtTEMPATLAHIR
		'
		Me.txtTEMPATLAHIR.Location = New System.Drawing.Point(96, 60)
		Me.txtTEMPATLAHIR.Name = "txtTEMPATLAHIR"
		Me.txtTEMPATLAHIR.Size = New System.Drawing.Size(162, 20)
		Me.txtTEMPATLAHIR.TabIndex = 3
		'
		'txtALAMAT
		'
		Me.txtALAMAT.Location = New System.Drawing.Point(372, 63)
		Me.txtALAMAT.Name = "txtALAMAT"
		Me.txtALAMAT.Size = New System.Drawing.Size(170, 20)
		Me.txtALAMAT.TabIndex = 4
		'
		'txtTANGGALLAHIR
		'
		Me.txtTANGGALLAHIR.Location = New System.Drawing.Point(96, 102)
		Me.txtTANGGALLAHIR.Name = "txtTANGGALLAHIR"
		Me.txtTANGGALLAHIR.Size = New System.Drawing.Size(162, 20)
		Me.txtTANGGALLAHIR.TabIndex = 5
		'
		'txtNOTELP
		'
		Me.txtNOTELP.Location = New System.Drawing.Point(372, 102)
		Me.txtNOTELP.Name = "txtNOTELP"
		Me.txtNOTELP.Size = New System.Drawing.Size(170, 20)
		Me.txtNOTELP.TabIndex = 6
		'
		'txtJENISKELAMIN
		'
		Me.txtJENISKELAMIN.Location = New System.Drawing.Point(95, 143)
		Me.txtJENISKELAMIN.Name = "txtJENISKELAMIN"
		Me.txtJENISKELAMIN.Size = New System.Drawing.Size(162, 20)
		Me.txtJENISKELAMIN.TabIndex = 7
		'
		'txtJENISPASIEN
		'
		Me.txtJENISPASIEN.Location = New System.Drawing.Point(372, 24)
		Me.txtJENISPASIEN.Name = "txtJENISPASIEN"
		Me.txtJENISPASIEN.Size = New System.Drawing.Size(170, 20)
		Me.txtJENISPASIEN.TabIndex = 9
		'
		'txtNAMA
		'
		Me.txtNAMA.Location = New System.Drawing.Point(96, 24)
		Me.txtNAMA.Name = "txtNAMA"
		Me.txtNAMA.Size = New System.Drawing.Size(162, 20)
		Me.txtNAMA.TabIndex = 10
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label8)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.txtNAMA)
		Me.Panel1.Controls.Add(Me.txtJENISPASIEN)
		Me.Panel1.Controls.Add(Me.txtTEMPATLAHIR)
		Me.Panel1.Controls.Add(Me.txtALAMAT)
		Me.Panel1.Controls.Add(Me.txtJENISKELAMIN)
		Me.Panel1.Controls.Add(Me.txtTANGGALLAHIR)
		Me.Panel1.Controls.Add(Me.txtNOTELP)
		Me.Panel1.Location = New System.Drawing.Point(12, 106)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(558, 188)
		Me.Panel1.TabIndex = 11
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(289, 105)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(45, 13)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "No Telp"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(289, 63)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(39, 13)
		Me.Label7.TabIndex = 16
		Me.Label7.Text = "Alamat"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(289, 24)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(66, 13)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Jenis Pasien"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(18, 146)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "Jenis Kelamin"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(18, 105)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 13)
		Me.Label4.TabIndex = 13
		Me.Label4.Text = "Tanggal Lahir"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(18, 63)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 13)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Tempat Lahir"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(18, 24)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Nama"
		'
		'frmRestPasien
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(582, 305)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnGET)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtRM)
		Me.Name = "frmRestPasien"
		Me.Text = "frmRestPasien"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtRM As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnGET As Button
	Friend WithEvents txtTEMPATLAHIR As TextBox
	Friend WithEvents txtALAMAT As TextBox
	Friend WithEvents txtTANGGALLAHIR As TextBox
	Friend WithEvents txtNOTELP As TextBox
	Friend WithEvents txtJENISKELAMIN As TextBox
	Friend WithEvents txtJENISPASIEN As TextBox
	Friend WithEvents txtNAMA As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
End Class
