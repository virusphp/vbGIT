Public Class createSep
	Dim sep As New Sep
	Public Sub New(noReg As String)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		MsgBox(noReg)
		sep.dataReg(noReg)
		txtNOREG.Text = noReg
		txtNOKARTU.Text = sep.noKartu
		txtTANGGALREG.Text = Format(sep.tanggalReg, "yyyy-MM-dd")
		txtJNSPELAYANAN.Text = sep.jenisRawat
	End Sub

End Class