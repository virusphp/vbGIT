Imports System.IO

Public Class detailPegawai
	Dim pegawai As New Pegawai

	Public Sub New(kdPegawai As String)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		pegawai.detail(kdPegawai)
		Dim photo As New MemoryStream
		For Each ar As Byte In pegawai.foto
			photo.WriteByte(ar)
		Next
		txtNIP.Text = pegawai.nip
		txtNIP.ReadOnly = True
		txtNIP.Font = New Font("verdana", 8.5, FontStyle.Bold)
		txtNIP.BackColor = Color.Aqua

		txtNOKTP.Text = pegawai.no_ktp
		txtNOKTP.TabIndex = 0
		txtNAMAPEGAWAI.Text = pegawai.nama_pegawai
		txtTEMPATLAHIR.Text = pegawai.tempat_lahir
		txtTANGGALLAHIR.Text = pegawai.tanggal_lahir

		rtALAMAT.Text = pegawai.alamat
		pcbFOTO.BackgroundImage = Image.FromStream(photo)
	End Sub

End Class