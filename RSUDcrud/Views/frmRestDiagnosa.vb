Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmRestDiagnosa
	Dim diagnosa As New Diagnosa
	Dim dt As New DataTable
	Dim ds As New DataSet
	Dim db As New BindingSource
	Dim client As RestClient = New RestClient("http://10.10.11.15/")

	Private Class hasilDiagnosa
		Public Property kode As String
		Public Property nama As String
	End Class

	Sub getDataDiagnosa()
		Try
			'request method get
			Dim request = New RestRequest("referensi/diagnosa/" & txtKDDiagnosa.Text & "", Method.GET)
			Dim result = client.Execute(request)
			'jika tidak ada response maka ouput pesan
			If Not result.IsSuccessful Then
				MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
			Else
				Dim content = result.Content

				'convert data array json to object json
				'Dim hasil = JsonConvert.DeserializeObject(Of Response)(content)
				Dim hasilObj As JObject = JObject.Parse(content)
				'Dim data As JObject = JObject.Parse(hasilObj.SelectToken("response"))
				Dim data As String = hasilObj.SelectToken("response").ToString
				ds = JsonConvert.DeserializeObject(Of DataSet)(data)

				dt = ds.Tables("diagnosa")
				dgDiagnosa.DataSource = dt
				Dim r As DataRow

				'txtKDDiagnosa.AutoCompleteCustomSource.Clear()

				'Dim autoComp As New AutoCompleteStringCollection()
				'For Each r In dt.Rows
				'autoComp.Add(r.Item(1).ToString)
				'Next
				'With txtKDDiagnosa
				'.AutoCompleteMode = AutoCompleteMode.SuggestAppend
				'.AutoCompleteSource = AutoCompleteSource.CustomSource
				'.AutoCompleteCustomSource = autoComp
				'.Clear()
				'.Focus()
				'End With

				'txtKDDiagnosa.AutoCompleteSource = AutoCompleteSource.CustomSource
				'txtKDDiagnosa.AutoCompleteCustomSource = autoComp
				'Console.WriteLine("diagnosa:" & hasilObj.SelectToken("response")("diagnosa").ToString)

				'MsgBox(hasilObj.SelectToken("response")("diagnosa").ToString)

				'Dim isiDataDiagnosa As List(Of hasilDiagnosa) = JsonConvert.DeserializeObject(Of List(Of hasilDiagnosa))(content)


			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txtKDDiagnosa_TextChanged(sender As Object, e As EventArgs) Handles txtKDDiagnosa.TextChanged
		If Len(txtKDDiagnosa.Text) = 3 Then
			diagnosa.getDiagnosa(dgDiagnosa, txtKDDiagnosa)
		End If
	End Sub

	Private Sub frmRestDiagnosa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Me.Dispose()
	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub dgDiagnosa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDiagnosa.CellContentClick

	End Sub
End Class