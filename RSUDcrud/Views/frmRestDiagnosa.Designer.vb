﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestDiagnosa
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
		Me.txtKDDiagnosa = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dgDiagnosa = New System.Windows.Forms.DataGridView()
		CType(Me.dgDiagnosa, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtKDDiagnosa
		'
		Me.txtKDDiagnosa.Location = New System.Drawing.Point(97, 49)
		Me.txtKDDiagnosa.Name = "txtKDDiagnosa"
		Me.txtKDDiagnosa.Size = New System.Drawing.Size(367, 20)
		Me.txtKDDiagnosa.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(166, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(151, 20)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "CARI DIAGNOSA"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(70, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "KD Diagnosa"
		'
		'dgDiagnosa
		'
		Me.dgDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgDiagnosa.Location = New System.Drawing.Point(12, 85)
		Me.dgDiagnosa.Name = "dgDiagnosa"
		Me.dgDiagnosa.Size = New System.Drawing.Size(452, 150)
		Me.dgDiagnosa.TabIndex = 4
		'
		'frmRestDiagnosa
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(476, 252)
		Me.Controls.Add(Me.dgDiagnosa)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtKDDiagnosa)
		Me.Name = "frmRestDiagnosa"
		Me.Text = "Diagnosa"
		CType(Me.dgDiagnosa, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtKDDiagnosa As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dgDiagnosa As DataGridView
End Class
