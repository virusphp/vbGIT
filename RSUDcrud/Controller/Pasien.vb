Public Class Pasien
	Public Property No_rm As String
	Public Property Nama_pasien As String
	Public Property Tempat_lahir As String
	Public Property Tgl_lahir As String
	Public Property Alamat As String
	Public Property Jns_kel As String

	Dim strQuery As String
	Dim dt As New DataTable
	Dim db As New BindingSource

	Public Function Insert() As Boolean
		strQuery = "insert into pasien(no_rm, nama_pasien, alamat, tempat_lahir, tgl_lahir, jns_kel)"
		strQuery += "value('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
		strQuery = String.Format(strQuery, No_rm, Nama_pasien, Alamat, Tempat_lahir, Tgl_lahir, Jns_kel)
		Return AksiQueryPasien(strQuery)
	End Function

	Public Function Update() As Boolean
		strQuery = "update pasien set nama='{0}', nama_pasien='{1}', alamat='{2}', tempat_lahir='{3}', tgl_lahir='{4}', jns_kel='{5}' where no_rm='{5}'"
		strQuery = String.Format(strQuery, Nama_pasien, Alamat, Tempat_lahir, Tgl_lahir, Alamat, Jns_kel, No_rm)
		Return AksiQueryPasien(strQuery)
	End Function

	Public Function Delete() As Boolean
		strQuery = "delete from pasien where no_rm='{0}'"
		strQuery = String.Format(strQuery, No_rm)
		Return AksiQueryPasien(strQuery)
	End Function

	Public Sub LoadData(ByVal grid As DataGridView)
		strQuery = "select p.no_rm, p.nama_pasien, p.alamat, p.tempat_lahir, p.tgl_lahir, p.jns_kel, pp.no_kartu from pasien as p inner join penjamin_pasien as pp on p.no_rm=pp.no_rm where len(pp.no_kartu) > '3' "
		dt = BukaTabelPasien(strQuery)
		grid.DataSource = dt
		'grid.Columns(0).Visible = False
		db.DataSource = dt
	End Sub

	Public Sub CariData(ByVal text As TextBox)
		db.Filter = "no_rm like '%" + text.Text + "%'"
	End Sub

	Public Sub Read()
		strQuery = "select * from pasien where no_rm='{0}'"
		strQuery = String.Format(strQuery, No_rm)
		dt = BukaTabelPasien(strQuery)
		No_rm = dt.Rows(0)(1).ToString
		Nama_pasien = dt.Rows(0)(2).ToString
		Alamat = dt.Rows(0)(3).ToString
		Tempat_lahir = dt.Rows(0)(4).ToString
		Tgl_lahir = dt.Rows(0)(5).ToString
		Jns_kel = dt.Rows(0)(6).ToString
	End Sub
End Class
