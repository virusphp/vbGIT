<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPasien
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
		Me.dgPASIEN = New System.Windows.Forms.DataGridView()
		Me.txtCARI = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.dgPASIEN, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgPASIEN
		'
		Me.dgPASIEN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgPASIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgPASIEN.Location = New System.Drawing.Point(12, 89)
		Me.dgPASIEN.Name = "dgPASIEN"
		Me.dgPASIEN.Size = New System.Drawing.Size(796, 215)
		Me.dgPASIEN.TabIndex = 17
		'
		'txtCARI
		'
		Me.txtCARI.Location = New System.Drawing.Point(12, 63)
		Me.txtCARI.Name = "txtCARI"
		Me.txtCARI.Size = New System.Drawing.Size(190, 20)
		Me.txtCARI.TabIndex = 18
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.RSUDcrud.My.Resources.Resources.logo
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 32)
		Me.PictureBox1.TabIndex = 19
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.UseWaitCursor = True
		Me.PictureBox1.WaitOnLoad = True
		'
		'MainPasien
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(820, 317)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.dgPASIEN)
		Me.Controls.Add(Me.txtCARI)
		Me.Name = "MainPasien"
		Me.Text = "MainPasien"
		CType(Me.dgPASIEN, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Private WithEvents dgPASIEN As DataGridView
	Friend WithEvents txtCARI As TextBox
End Class
