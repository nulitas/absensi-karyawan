
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

    Sub addDataAbsen(id_karyawan As String,
                     tanngal As Date,
                     waktu_absen_masuk As DateTime,
                     waktu_absen_keluar As DateTime)
        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                  + "; password =" + password + "; database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO absensi(id_karyawan, tanggal, waktu_absen_masuk, waktu_absen_keluar) 
                        VALUE(' " &
                        id_karyawan & "', '" &
                        tanngal & "', '" & waktu_absen_masuk & "', '" &
                        waktu_absen_keluar & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub

    Public Function checkEmployee(id_karyawan As Integer, nama As String) As Boolean
        Try
            dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                 + "; password =" + password + "; database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT nik FROM karyawan WHERE nama='" & nama &
                                     "' AND id_karyawan=" & id_karyawan
            sqlRead = sqlCommand.ExecuteReader

            If Not sqlRead.HasRows Then
                MsgBox("ID Karyawan dengan nama tidak sesuai!")
                Return False
            End If

            sqlRead.Close()
            dbConn.Close()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function getEmployeesName() As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                 + "; password =" + password + "; database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT nama FROM karyawan"

        sqlRead = sqlCommand.ExecuteReader()
        Do While sqlRead.Read
            result.Add(sqlRead.Item(0))
        Loop
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

End Class
