Imports RestSharp
Imports Newtonsoft.Json

Public Class frmRestPasien
	'Base_Url
	Dim client As RestClient = New RestClient("http://10.10.11.15/")

	Private Class hasilDataPasien
		Public Property nama_pasien As String
		Public Property tempat_lahir As String
		Public Property tanggal_lahir As DateTime
		Public Property jenis_kelamin As Integer
		Public Property jenis_pasien As String
		Public Property alamat As String
		Public Property no_telp As String
	End Class

	Sub getDataPasien()
		Try
			'request method get
			Dim request = New RestRequest("getpasien/" & txtRM.Text & "", Method.GET)
			Dim result = client.Execute(request)
			'jika tidak ada response maka ouput pesan
			If Not result.IsSuccessful Then
				MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
			Else
				Dim content = result.Content

				' convert data array json to object json
				'Dim isiDataPasien = JsonConvert.DeserializeObject(Of hasilDataPasien)(content)
				Dim isiDataPasien As List(Of hasilDataPasien) = JsonConvert.DeserializeObject(Of List(Of hasilDataPasien))(content)
				Dim data As hasilDataPasien = isiDataPasien.First
				txtNAMA.Text = data.nama_pasien
				txtTEMPATLAHIR.Text = data.tempat_lahir
				txtTANGGALLAHIR.Text = data.tanggal_lahir.ToString("dd MMMM yyyy")
				txtJENISKELAMIN.Text = If(data.jenis_kelamin = 0, "Perempuan", "Laki Laki")
				txtJENISPASIEN.Text = If(data.jenis_pasien = 1, "Umum", "Penjamin")
				txtALAMAT.Text = data.alamat
				txtNOTELP.Text = data.no_telp
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btnGET_Click(sender As Object, e As EventArgs) Handles btnGET.Click
		getDataPasien()
	End Sub

	Private Sub txtRM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRM.KeyPress
		If Len(txtRM.Text) = 6 Then
			getDataPasien()
		End If
	End Sub
End Class