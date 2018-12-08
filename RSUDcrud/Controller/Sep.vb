
Public Class Sep
	Public Property noReg As String
	Public Property noRm As String
	Public Property namaPasien As String
	Public Property tanggalReg As DateTime
	Public Property jenisRawat As String
	Public Property jenisPasien As String
	Public Property noSep As String
	Public Property noKartu As String

	Dim strQuery As String
	Dim dt As New DataTable
	Dim db As New BindingSource

	Public Sub LoadData(ByVal grid As DataGridView, ByVal dtTglSep As DateTimePicker)
		Dim tglSep As String = Format(dtTglSep.Value, "yyyy-MM-dd")
		Dim aksi As DataGridViewButtonColumn = New DataGridViewButtonColumn()
		aksi.HeaderText = "Aksi"
		aksi.Text = "Cetak"
		aksi.Name = "btnAksi"
		strQuery = "select r.no_reg, r.no_rm, p.nama_pasien, r.tgl_reg, r.jns_rawat, r.kd_cara_bayar, r.no_sjp  from registrasi as r inner join pasien as p on r.no_rm=p.no_rm where r.tgl_reg='" + tglSep + "'"
		dt = BukaTabelRegister(strQuery)
		With grid
			.DataSource = dt
			.Columns(1).HeaderText = "No Reg"
			.Columns(2).HeaderText = "No RM"
			.Columns(3).HeaderText = "Nama Pasien"
			.Columns(4).HeaderText = "Tanggal Reg"
			.Columns(5).HeaderText = "Jenis Rawat"
			.Columns(6).HeaderText = "Jenis Pasien"
			.Columns(7).HeaderText = "No SEP"
			.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		End With

		db.DataSource = dt
    End Sub

	Public Sub LoadCombobox(ByVal combo As ComboBox)
		strQuery = "select kd_cara_bayar, keterangan from cara_bayar where kd_cara_bayar!='0'"
		dt = BukaTabelRegister(strQuery)
		combo.DataSource = dt
		combo.DisplayMember = "keterangan"
		combo.ValueMember = "kd_cara_bayar"
		combo.AutoCompleteSource = AutoCompleteSource.ListItems
		combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
	End Sub

	Public Sub CariData(ByVal text As TextBox)
		db.Filter = "no_rm like '%" + text.Text + "%' or nama_pasien like '%" + text.Text + "%'"
	End Sub

	Public Sub cariJenisPasien(ByVal combo As ComboBox)
		Dim cmb As String = combo.SelectedValue.ToString
		db.Filter = "kd_cara_bayar ='" & cmb & "'"
	End Sub

	Public Sub cariJenisRawat(ByVal jnsRawat As String)
		'MsgBox(jnsRawat)
		db.Filter = "jns_rawat ='" & jnsRawat & "'"
	End Sub

	Public Sub Read()
		strQuery = "Select * from pasien where no_rm='{0}'"
		strQuery = String.Format(strQuery, noRm)
		dt = BukaTabelRegister(strQuery)
	End Sub

	Public Function dataReg(ByVal noReg As String)
		Dim jnsRwt As String = Left(noReg, 2)
		Dim dtPasien As DataTable
		strQuery = "select r.tgl_reg, r.no_sjp, pp.no_kartu from registrasi as r inner join penjamin_pasien as pp on (r.no_rm=pp.no_rm and r.kd_penjamin=pp.kd_penjamin) where r.no_reg='" + noReg + "'"

		If jnsRwt = "01" Then
			Left(noReg, 2)
			Dim strQueryRJ = ""
			dtPasien = BukaTabelRegister(strQueryRJ)
		End If

		strQuery = String.Format(strQuery, noReg)
		dt = BukaTabelRegister(strQuery)

		tanggalReg = dt.Rows(0)(0).ToString
		noSep = dt.Rows(0)(1).ToString
		noKartu = dt.Rows(0)(2).ToString
		jenisRawat = If(jnsRwt = "01" Or jnsRwt = "03", "Rawat Jalan", "Rawat Inap")

	End Function


	Public Sub settingColumn(ByVal grid As DataGridView)
		Try
			grid.Columns(1).HeaderText = "No Reg"
			grid.Columns(2).HeaderText = "No RM"
			grid.Columns(3).HeaderText = "Nama Pasien"
			grid.Columns(4).HeaderText = "Tanggal Reg"
			grid.Columns(5).HeaderText = "Jenis Rawat"
			grid.Columns(6).HeaderText = "Jenis Pasien"
			grid.Columns(7).HeaderText = "No SEP"
			grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
		Catch ex As Exception
		End Try
	End Sub

	Public Sub addButton(ByVal grid As DataGridView)
		Dim aksi As DataGridViewButtonColumn = New DataGridViewButtonColumn()
		aksi.HeaderText = "Aksi"
		aksi.Text = "Cetak"
		aksi.Name = "btnAksi"
		aksi.UseColumnTextForButtonValue = True
		grid.Columns.Insert(7, aksi)
	End Sub

End Class
