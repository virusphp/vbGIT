﻿Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Diagnosa
	Dim dt As New DataTable
	Dim ds As New DataSet
	Dim client As RestClient = New RestClient("http://10.10.11.15/")

	Public Function getDiagnosa(ByVal grid As DataGridView, ByVal kdDiagnosa As TextBox)
		Try
			'request method get
			Dim request = New RestRequest("referensi/diagnosa/" & kdDiagnosa.Text & "", Method.GET)
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
				dt = ds.Tables("diagnosa")
				grid.DataSource = dt
				settingColumn(grid)

				'Dim r As DataRow
				'Dim autoComp As New AutoCompleteStringCollection()
				'For Each r In dt.Rows
				'autoComp.Add(r.Item(1).ToString)
				'Next
				'With kdDiagnosa
				'.AutoCompleteMode = AutoCompleteMode.SuggestAppend
				'.AutoCompleteSource = AutoCompleteSource.CustomSource
				'.AutoCompleteCustomSource = autoComp
				'.Focus()
				'End With

			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Function

	Private Sub settingColumn(ByVal grid As DataGridView)
		Dim aksi As New DataGridViewButtonColumn
		Try
			grid.Columns(0).HeaderText = "Kode"
			grid.Columns(1).HeaderText = "Nama Diagnosa"
			grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		Catch ex As Exception
		End Try
	End Sub

End Class
