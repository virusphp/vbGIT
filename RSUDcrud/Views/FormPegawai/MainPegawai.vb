Public Class MainPegawai
	Dim pegawai As New Pegawai
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		pegawai.LoadData(dgPEGAWAI)
		settingColumn()
	End Sub

	Private Sub InsertDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDataToolStripMenuItem.Click
		insertPegawai.ShowDialog()
	End Sub

	Private Sub EditDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDataToolStripMenuItem.Click
		If varTempPegawai = "" Then
			MsgBox("Harap pilih data yang akan di ubah!!")
		Else
			pegawai.LoadData(dgPEGAWAI)
			editPegawai.ShowDialog()
		End If
	End Sub

	Private Sub dgPEGAWAI_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPEGAWAI.CellClick
		If dgPEGAWAI.Rows.Count > 0 Then
			varTemp = dgPEGAWAI.CurrentRow.Cells(0).Value.ToString
		End If
	End Sub

	Private Sub DeleteDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDataToolStripMenuItem.Click
		'If varTemp = "" Then
		'MsgBox("Harap pilih data yang akan di ubah!!")
		'Else
		'pegawai.kd_pegawai = dgPEGAWAI.CurrentRow.Cells(0).Value.ToString
		'pegawai.Delete()
		'pegawai.LoadData(dgPEGAWAI)
		'End If
	End Sub

	Private Sub txtCARI_TextChanged(sender As Object, e As EventArgs) Handles txtCARI.TextChanged
		pegawai.CariData(txtCARI)
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCONTEXMENU.Click
		pegawai.LoadData(dgPEGAWAI)
	End Sub

	Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
		End If
	End Sub

	Private Sub dgPEGAWAI_MouseDown(sender As Object, e As MouseEventArgs) Handles dgPEGAWAI.MouseDown
		If e.Button = Windows.Forms.MouseButtons.Right Then
			ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
		End If
	End Sub

	Private Sub settingColumn()
		Dim aksi As New DataGridViewButtonColumn
		Try
			dgPEGAWAI.Columns(0).HeaderText = "KD Pegawai"
			dgPEGAWAI.Columns(1).HeaderText = "Nama Pegawai"
			dgPEGAWAI.Columns(2).HeaderText = "NIP"
			dgPEGAWAI.Columns(3).HeaderText = "Tempat Lahir"
			dgPEGAWAI.Columns(4).HeaderText = "Tanggal Lahir"
			dgPEGAWAI.Columns(5).HeaderText = "Alamat"
			dgPEGAWAI.Columns(6).HeaderText = "NO KTP"
			aksi.HeaderText = "Aksi"
			aksi.Text = "Detail"
			aksi.Name = "btnDETAIL"
			aksi.UseColumnTextForButtonValue = True
			dgPEGAWAI.Columns.Add(aksi)
			dgPEGAWAI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		Catch ex As Exception
		End Try
	End Sub

	Private Sub dgPEGAWAI_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPEGAWAI.CellContentClick
		Dim aksi As String = dgPEGAWAI.Columns(e.ColumnIndex).Name
		If aksi = "btnDETAIL" Then
			Dim kdPegawai As String
			kdPegawai = dgPEGAWAI.Rows(e.RowIndex).Cells(0).Value
			Dim detail As New detailPegawai(kdPegawai)
			detail.ShowDialog()
		End If
	End Sub

	Private Sub MainPegawai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Me.Dispose()
	End Sub
End Class
