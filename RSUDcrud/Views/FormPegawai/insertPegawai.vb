Public Class insertPegawai
	Dim pegawai As New Pegawai

	Private Sub Save()
		With pegawai
			.kd_pegawai = txtKDPEGAWAI.Text
			.nama_pegawai = txtNAMA.Text
			.alamat = txtALAMAT.Text
			.tempat_lahir = txtNOTELP.Text
			.tanggal_lahir = txtUNIT.Text
			.nip = cbJABATAN.Text
			If .Insert() Then
				Me.Dispose()
				MainPegawai.btnCONTEXMENU.PerformClick()
			End If
		End With
	End Sub

	Private Sub btnBATAL_Click(sender As Object, e As EventArgs) Handles btnBATAL.Click
		Me.Dispose()
	End Sub

	Private Sub btnSIMPAN_Click(sender As Object, e As EventArgs) Handles btnSIMPAN.Click
		Save()
	End Sub

	Private Sub insertPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class