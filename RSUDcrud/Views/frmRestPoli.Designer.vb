<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestPoli
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
		Me.dgPOLI = New System.Windows.Forms.DataGridView()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtKDPOLI = New System.Windows.Forms.TextBox()
		CType(Me.dgPOLI, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgPOLI
		'
		Me.dgPOLI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgPOLI.Location = New System.Drawing.Point(17, 85)
		Me.dgPOLI.Name = "dgPOLI"
		Me.dgPOLI.Size = New System.Drawing.Size(452, 150)
		Me.dgPOLI.TabIndex = 8
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(17, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(42, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "KD Poli"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(185, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(97, 20)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "CARI POLI"
		'
		'txtKDPOLI
		'
		Me.txtKDPOLI.Location = New System.Drawing.Point(102, 49)
		Me.txtKDPOLI.Name = "txtKDPOLI"
		Me.txtKDPOLI.Size = New System.Drawing.Size(367, 20)
		Me.txtKDPOLI.TabIndex = 5
		'
		'frmRestPoli
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(485, 252)
		Me.Controls.Add(Me.dgPOLI)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtKDPOLI)
		Me.Name = "frmRestPoli"
		Me.Text = "frmRestPoli"
		CType(Me.dgPOLI, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgPOLI As DataGridView
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtKDPOLI As TextBox
End Class
