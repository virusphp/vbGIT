Public Class frmRestPoli
	Dim poli As New Poli

	Private Sub txtKDPOLI_TextChanged(sender As Object, e As EventArgs) Handles txtKDPOLI.TextChanged
		If Len(txtKDPOLI.Text) = 3 Then
			poli.getPoli(dgPOLI, txtKDPOLI)
		End If
	End Sub

	Private Sub frmRestPoli_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Me.Dispose()
	End Sub
End Class