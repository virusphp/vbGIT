Public Class MainCreateSEP
	Dim sep As New Sep

	Private Sub MainCreateSEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sep.LoadData(dgSEP, dtTANGGALSEP)
		sep.LoadCombobox(cbCARABAYAR)
	End Sub

	Sub kosongkan()
		cbCARABAYAR.Text = ""
	End Sub

	Private Sub txtCARI_TextChanged(sender As Object, e As EventArgs) Handles txtCARI.TextChanged
		sep.CariData(txtCARI)
	End Sub

	Private Sub MainCreateSEP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Me.Dispose()
	End Sub

	Private Sub dgSEP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSEP.CellContentClick
		Dim aksi As String = dgSEP.Columns(e.ColumnIndex).Name
		If aksi = "btnAksi" Then
			Dim noReg As String
			noReg = dgSEP.Rows(e.RowIndex).Cells(1).Value
			Dim createSep As New createSep(noReg)
			createSep.ShowDialog()
		End If
	End Sub

	Private Sub dgSEP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgSEP.CellFormatting
		editColumnGrid(e)
	End Sub

	Private Sub cbCARABAYAR_Validated(sender As Object, e As EventArgs) Handles cbCARABAYAR.Validated
		sep.cariJenisPasien(cbCARABAYAR)
	End Sub

	Private Sub rbRJ_CheckedChanged(sender As Object, e As EventArgs) Handles rbRJ.CheckedChanged
		pilihRadio()
	End Sub

	Private Sub rbRI_CheckedChanged(sender As Object, e As EventArgs) Handles rbRI.CheckedChanged
		pilihRadio()
	End Sub

	Sub pilihRadio()
		Dim jnsRawat As String
		If rbRJ.Checked Then
			jnsRawat = "1"
		ElseIf rbRI.Checked Then
			jnsRawat = "2"
		Else
			jnsRawat = "3"
		End If
		sep.cariJenisRawat(jnsRawat)
	End Sub

	Sub editColumnGrid(e)
		If Me.dgSEP.Columns(e.ColumnIndex).HeaderText _
				= "Jenis Rawat" Then
			If (CType(e.Value, Integer) = 1) Then
				e.Value = "Rawat Jalan"
			ElseIf (CType(e.Value, Integer) = 2) Then
				e.Value = "Rawat Inap"
			ElseIf (CType(e.Value, Integer) = 3) Then
				e.Value = "Rawat Darurat"
			Else
				e.Value = ""
			End If
			e.FormattingApplied = True
		End If

		If Me.dgSEP.Columns(e.ColumnIndex).HeaderText _
				= "Jenis Pasien" Then
			If (CType(e.Value, Integer) = 1 Or CType(e.Value, Integer) = 9) Then
				e.Value = "UMUM"
			ElseIf (CType(e.Value, Integer) = 3) Then
				e.Value = "Asuransi Lain"
			ElseIf (CType(e.Value, Integer) = 4) Then
				e.Value = "Keringangan Dispensasi"
			ElseIf (CType(e.Value, Integer) = 5) Then
				e.Value = "Keringangan Tidak Mampu"
			ElseIf (CType(e.Value, Integer) = 6) Then
				e.Value = "Gratis Dispensasi"
			ElseIf (CType(e.Value, Integer) = 7) Then
				e.Value = "Gratis Tidak Mampu"
			ElseIf (CType(e.Value, Integer) = 8) Then
				e.Value = "BPJS"
			Else
				e.Value = ""
			End If
			e.FormattingApplied = True
		End If
	End Sub

	Private Sub dtTANGGALSEP_ValueChanged(sender As Object, e As EventArgs) Handles dtTANGGALSEP.ValueChanged
		sep.LoadData(dgSEP, dtTANGGALSEP)
	End Sub
End Class