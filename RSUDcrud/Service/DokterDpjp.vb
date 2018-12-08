Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class DokterDpjp
	Dim dt As New DataTable
	Dim ds As New DataSet
	Dim client As RestClient = New RestClient("http://10.10.11.15/")

	Public Function getDpjp(ByVal grid As DataGridView, ByVal kdDpjp As TextBox, ByVal tglSep As DateTimePicker)
		Try
			'request method get
			Dim tanggalSep As String = Format(tglSep.Value, "yyyy-MM-dd")
			Dim request = New RestRequest("referensi/dokter/pelayanan/2/tglpelayanan/" & tanggalSep & "/spesialis/" & kdDpjp.Text & "", Method.GET)
			Dim result = client.Execute(request)
			'jika tidak ada response maka ouput pesan
			If Not result.IsSuccessful Then
				MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
			Else
				Dim content = result.Content

				'convert data array json to object json
				Dim hasilObj As JObject = JObject.Parse(content)
				Dim data As String = hasilObj.SelectToken("response").ToString
				ds = JsonConvert.DeserializeObject(Of DataSet)(data)
				dt = ds.Tables("list")
				grid.DataSource = dt
				settingColumn(grid)

			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Function

	Private Sub settingColumn(ByVal grid As DataGridView)
		Dim aksi As New DataGridViewButtonColumn
		Try
			grid.Columns(0).HeaderText = "Kode"
			grid.Columns(1).HeaderText = "Nama Dokter"
			grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		Catch ex As Exception
		End Try
	End Sub
End Class
