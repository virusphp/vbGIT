<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPegawai
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
		Me.components = New System.ComponentModel.Container()
		Me.dgPEGAWAI = New System.Windows.Forms.DataGridView()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.InsertDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DeleteDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.txtCARI = New System.Windows.Forms.TextBox()
		Me.btnCONTEXMENU = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.dgPEGAWAI, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgPEGAWAI
		'
		Me.dgPEGAWAI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgPEGAWAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgPEGAWAI.Location = New System.Drawing.Point(12, 88)
		Me.dgPEGAWAI.Name = "dgPEGAWAI"
		Me.dgPEGAWAI.Size = New System.Drawing.Size(796, 215)
		Me.dgPEGAWAI.TabIndex = 10
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertDataToolStripMenuItem, Me.EditDataToolStripMenuItem, Me.DeleteDataToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 70)
		'
		'InsertDataToolStripMenuItem
		'
		Me.InsertDataToolStripMenuItem.Name = "InsertDataToolStripMenuItem"
		Me.InsertDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.InsertDataToolStripMenuItem.Text = "Insert Data"
		'
		'EditDataToolStripMenuItem
		'
		Me.EditDataToolStripMenuItem.Name = "EditDataToolStripMenuItem"
		Me.EditDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.EditDataToolStripMenuItem.Text = "Edit Data"
		'
		'DeleteDataToolStripMenuItem
		'
		Me.DeleteDataToolStripMenuItem.Name = "DeleteDataToolStripMenuItem"
		Me.DeleteDataToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
		Me.DeleteDataToolStripMenuItem.Text = "Delete Data"
		'
		'txtCARI
		'
		Me.txtCARI.Location = New System.Drawing.Point(12, 62)
		Me.txtCARI.Name = "txtCARI"
		Me.txtCARI.Size = New System.Drawing.Size(190, 20)
		Me.txtCARI.TabIndex = 12
		'
		'btnCONTEXMENU
		'
		Me.btnCONTEXMENU.Location = New System.Drawing.Point(290, 119)
		Me.btnCONTEXMENU.Name = "btnCONTEXMENU"
		Me.btnCONTEXMENU.Size = New System.Drawing.Size(75, 23)
		Me.btnCONTEXMENU.TabIndex = 13
		Me.btnCONTEXMENU.Text = "btnCONTEXMENU"
		Me.btnCONTEXMENU.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.RSUDcrud.My.Resources.Resources.logo
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 32)
		Me.PictureBox1.TabIndex = 16
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.UseWaitCursor = True
		Me.PictureBox1.WaitOnLoad = True
		'
		'MainPegawai
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(820, 317)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.dgPEGAWAI)
		Me.Controls.Add(Me.txtCARI)
		Me.Controls.Add(Me.btnCONTEXMENU)
		Me.Name = "MainPegawai"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Main Pegawai"
		CType(Me.dgPEGAWAI, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents dgPEGAWAI As DataGridView
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents InsertDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DeleteDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents txtCARI As TextBox
	Friend WithEvents btnCONTEXMENU As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
