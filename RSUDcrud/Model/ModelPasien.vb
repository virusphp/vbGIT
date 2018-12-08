Imports System.Data.SqlClient

Module ModelPasien
	Public conn As SqlConnection
	Public cmd As SqlCommand
	Public dr As SqlDataReader

	Public strkoneksiSQL As String = "data source=10.10.11.17;initial catalog=DBSIMRS;user=sa;password=Serverapi2018"
	Public varTemp As String

	Public Function BukaTabelPasien(ByVal strQuery As String) As DataTable
		conn = New SqlConnection(strkoneksiSQL)
		conn.Open()
		Try
			cmd = New SqlCommand(strQuery, conn)
			dr = cmd.ExecuteReader
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Dim dt As New DataTable
		dt.Load(dr)
		conn.Close()
		Return dt
	End Function

	Public Function AksiQueryPasien(ByVal strQuery As String) As Boolean
		conn = New SqlConnection(strkoneksiSQL)
		conn.Open()
		cmd = New SqlCommand(strQuery, conn)
		cmd.ExecuteNonQuery()
		conn.Close()
		Return True
	End Function
End Module
