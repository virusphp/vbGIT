Public Class MainPasien
	Dim pasien As New Pasien
	Private Sub MainPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		pasien.LoadData(dgPASIEN)
		settingColumn()
	End Sub

	Private Sub dgPASIEN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

	End Sub

	Private Sub txtCARI_TextChanged(sender As Object, e As EventArgs)
		pasien.CariData(txtCARI)
	End Sub

	Private Sub settingColumn()
		Try
			dgPASIEN.Columns(0).HeaderText = "No RM"
			dgPASIEN.Columns(1).HeaderText = "Nama Pasien"
			dgPASIEN.Columns(2).HeaderText = "Tempat Lahir"
			dgPASIEN.Columns(3).HeaderText = "Tanggal Lahir"
			dgPASIEN.Columns(4).HeaderText = "Alamat"
			dgPASIEN.Columns(5).HeaderText = "Jenis Kelamin"
			dgPASIEN.Columns(6).HeaderText = "No Kartu"
			dgPASIEN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		Catch ex As Exception
		End Try
	End Sub
End Class