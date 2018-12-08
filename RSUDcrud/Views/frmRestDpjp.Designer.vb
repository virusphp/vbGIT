<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestDpjp
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
		Me.dgDpjp = New System.Windows.Forms.DataGridView()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtKDDPJP = New System.Windows.Forms.TextBox()
		Me.dtTGLSEP = New System.Windows.Forms.DateTimePicker()
		CType(Me.dgDpjp, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgDpjp
		'
		Me.dgDpjp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgDpjp.Location = New System.Drawing.Point(12, 90)
		Me.dgDpjp.Name = "dgDpjp"
		Me.dgDpjp.Size = New System.Drawing.Size(452, 150)
		Me.dgDpjp.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(133, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(39, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Dokter"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(132, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(178, 20)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "CARI DOKTER DPJP"
		'
		'txtKDDPJP
		'
		Me.txtKDDPJP.Location = New System.Drawing.Point(178, 54)
		Me.txtKDDPJP.Name = "txtKDDPJP"
		Me.txtKDDPJP.Size = New System.Drawing.Size(286, 20)
		Me.txtKDDPJP.TabIndex = 5
		'
		'dtTGLSEP
		'
		Me.dtTGLSEP.CustomFormat = "yyyy-MM-dd"
		Me.dtTGLSEP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtTGLSEP.Location = New System.Drawing.Point(12, 54)
		Me.dtTGLSEP.Name = "dtTGLSEP"
		Me.dtTGLSEP.Size = New System.Drawing.Size(94, 20)
		Me.dtTGLSEP.TabIndex = 9
		'
		'frmRestDpjp
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 253)
		Me.Controls.Add(Me.dtTGLSEP)
		Me.Controls.Add(Me.dgDpjp)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtKDDPJP)
		Me.Name = "frmRestDpjp"
		Me.Text = "frmRestDpjp"
		CType(Me.dgDpjp, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgDpjp As DataGridView
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtKDDPJP As TextBox
	Friend WithEvents dtTGLSEP As DateTimePicker
End Class
