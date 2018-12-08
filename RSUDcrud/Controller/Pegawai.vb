Public Class Pegawai
	Public Property kd_pegawai As String
	Public Property nama_pegawai As String
	Public Property alamat As String
	Public Property tempat_lahir As String
	Public Property tanggal_lahir As DateTime
	Public Property nip As String
	Public Property no_ktp As String
	Public Property foto As Byte()

	Dim strQuery As String
	Dim dt As New DataTable
	Dim db As New BindingSource
	Dim data As Array

	Public Function Insert() As Boolean
		strQuery = "insert into pegawai(kd_pegawai,nama,alamat,no_telp,unit,jabatan)"
		strQuery += "value('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
		strQuery = String.Format(strQuery, kd_pegawai, nama_pegawai, alamat, tempat_lahir, tanggal_lahir, no_ktp)
		Return AksiQuery(strQuery)
	End Function

	Public Function Update() As Boolean
		strQuery = "update pegawai set nama='{0}', alamat='{1}', no_telp='{2}', unit='{3}', jabatan='{4}' where kd_pegawai='{5}'"
		strQuery = String.Format(strQuery, nama_pegawai, alamat, tempat_lahir, tanggal_lahir, no_ktp, kd_pegawai)
		Return AksiQuery(strQuery)
	End Function

	Public Function Delete() As Boolean
		strQuery = "delete from pegawai where kd_pegawai='{0}'"
		strQuery = String.Format(strQuery, kd_pegawai)
		Return AksiQuery(strQuery)
	End Function

	Public Sub LoadData(ByVal grid As DataGridView)
		strQuery = "select kd_pegawai,nip,nama_pegawai,tempat_lahir,tgl_lahir,alamat,no_ktp from pegawai where kd_jns_pegawai='1' and len(kd_pegawai) > '3'"
		dt = BukaTabel(strQuery)
		grid.DataSource = dt
		'grid.Columns(0).Visible = False
		db.DataSource = dt
	End Sub

	Public Sub CariData(ByVal text As TextBox)
		db.Filter = "nama_pegawai like '%" + text.Text + "%' or tempat_lahir like '%" + text.Text + "%'"
	End Sub

	Public Function detail(ByVal kdPegawai As String) As String
		strQuery = "select kd_pegawai,nip,nama_pegawai,tempat_lahir,tgl_lahir,no_ktp,foto,alamat from pegawai where kd_pegawai='" + kdPegawai + "'"
		strQuery = String.Format(strQuery, kd_pegawai)
		dt = BukaTabel(strQuery)

		kd_pegawai = dt.Rows(0)(0).ToString
		nip = dt.Rows(0)(1).ToString
		nama_pegawai = dt.Rows(0)(2).ToString
		tempat_lahir = dt.Rows(0)(3).ToString
		tanggal_lahir = dt.Rows(0)(4).ToString
		no_ktp = dt.Rows(0)(5).ToString
		foto = dt.Rows(0).Item("foto")
		alamat = dt.Rows(0)(7).ToString

	End Function

	Public Sub Read()
		strQuery = "select * from pegawai where kd_pegawai='{0}'"
		strQuery = String.Format(strQuery, kd_pegawai)
		dt = BukaTabel(strQuery)
		kd_pegawai = dt.Rows(0)(0).ToString
		'nama = dt.Rows(0)(1).ToString
		'alamat = dt.Rows(0)(2).ToString
		'no_telp = dt.Rows(0)(3).ToString
		'unit = dt.Rows(0)(4).ToString
		'jabatan = dt.Rows(0)(5).ToString

	End Sub
End Class
