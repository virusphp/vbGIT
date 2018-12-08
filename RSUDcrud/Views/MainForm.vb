Public Class MainForm
	Private Sub btnPASIEN_Click(sender As Object, e As EventArgs) Handles btnPASIEN.Click
		MainPasien.ShowDialog()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		MainPegawai.ShowDialog()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Application.Exit()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		frmRestPasien.ShowDialog()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDIAGNOSA.Click
		frmRestDiagnosa.ShowDialog()
	End Sub

	Private Sub btnSEP_Click(sender As Object, e As EventArgs) Handles btnSEP.Click
		MainCreateSEP.ShowDialog()
	End Sub

	Private Sub btnPOLI_Click(sender As Object, e As EventArgs) Handles btnPOLI.Click
		frmRestPoli.ShowDialog()
	End Sub

	Private Sub btnDPJP_Click(sender As Object, e As EventArgs) Handles btnDPJP.Click
		frmRestDpjp.ShowDialog()
	End Sub
End Class