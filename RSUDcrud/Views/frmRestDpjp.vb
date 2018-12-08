Public Class frmRestDpjp
	Dim dokterDpjp As New DokterDpjp
	Private Sub txtKDDiagnosa_TextChanged(sender As Object, e As EventArgs) Handles txtKDDPJP.TextChanged
		If Len(txtKDDPJP.Text) = 3 Then
			dokterDpjp.getDpjp(dgDpjp, txtKDDPJP, dtTGLSEP)
		End If
	End Sub

End Class