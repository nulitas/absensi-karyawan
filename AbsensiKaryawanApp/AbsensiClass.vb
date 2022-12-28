Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class AbsensiClass

    Private absensiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Public Function GetDataAbsensi() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                  + "; password =" + password + "; database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_absensi AS 'ID',
                                  id_karyawan AS 'ID KARYAWAN', 
                                  tanggal AS 'TANGGAL',
                                  waktu_absen_masuk AS 'ABSEN MASUK',
                                  waktu_absen_keluar AS 'ABSEN KELUAR'
                                  FROM absensi"

        sqlRead = sqlCommand.ExecuteReader()
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function addDataAbsen(id_karyawan As Integer,
                                 tanngal As Date,
                                 waktu_absen_masuk As Timestamp,
                                 waktu_absen_keluar As Timestamp)
        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                  + "; password =" + password + "; database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO "
        Catch ex As Exception

        End Try
    End Function

End Class
