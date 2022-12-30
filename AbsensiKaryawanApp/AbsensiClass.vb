
Imports System.Data.SqlTypes
Imports MySql.Data.MySqlClient
Public Class AbsensiClass

    Public Shared isLogin As Boolean = False

    Private id_absensi As Integer
    Private id_karyawan As Integer
    Private tanggal As Date
    Private waktu_masuk As String = "NULL"
    Private waktu_keluar As String = "NULL"

    Private absensiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Public Property GSwaktu_masuk As String
        Get
            Return waktu_masuk
        End Get
        Set(value As String)
            waktu_masuk = value
        End Set
    End Property

    Public Property GSwaktu_keluar As String
        Get
            Return waktu_keluar
        End Get
        Set(value As String)
            waktu_keluar = value
        End Set
    End Property

    Public Property GSid_karyawan As Integer
        Get
            Return id_karyawan
        End Get
        Set(value As Integer)
            id_karyawan = value
        End Set
    End Property

    Public Property GStanggal As Date
        Get
            Return tanggal
        End Get
        Set(value As Date)
            tanggal = value
        End Set
    End Property

    Public Property GSid_absensi As Integer
        Get
            Return id_absensi
        End Get
        Set(value As Integer)
            id_absensi = value
        End Set
    End Property

    Public Function GetDataAbsensi() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                  + ";password =" + password + ";database=" + database
        Try
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

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function getDataAbsensiByID(Id As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                  + "; password =" + password + "; database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_karyawan, tanggal, waktu_absen_masuk, waktu_absen_keluar 
                                  FROM absensi
                                  WHERE id_absensi=" & Id & ";"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                Dim i = 0
                While i < 4
                    Try
                        result.Add(sqlRead.GetString(i))
                    Catch ex As SqlNullValueException
                        result.Add("NULL")
                    End Try
                    i += 1
                End While
            End While


            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            dbConn.Dispose()
        End Try

    End Function

    Sub addDataAbsen(id_karyawan As String,
                     tanngal As Date,
                     waktu_absen_masuk As String,
                     waktu_absen_keluar As String)
        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                      + ";password =" + password + ";database =" + database
        Try

            dbConn.Open()
            sqlCommand.Connection = dbConn
            Dim stringTanggal = tanngal.Year & "-" & tanngal.Month & "-" & tanngal.Day


            sqlQuery = "INSERT INTO absensi(id_karyawan, tanggal, waktu_absen_masuk, waktu_absen_keluar) 
                        VALUE(' " &
                        id_karyawan & "', '" &
                        stringTanggal & "', " &
                        waktu_absen_masuk & ", " &
                        waktu_absen_keluar & ")"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)

            'MsgBox(sqlQuery)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub

    Sub updateDataAbsensi(id_karyawan As Integer,
                          tanggal As Date,
                          absen_masuk As String,
                          absen_keluar As String)
        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                     + ";password =" + password + ";database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim stringTanggal = tanggal.Year & "-" & tanggal.Month & "-" & tanggal.Day

            sqlQuery = "UPDATE absensi 
                        SET id_karyawan=" & id_karyawan &
                        ", tanggal='" & stringTanggal &
                        "', waktu_absen_masuk=" & absen_masuk &
                        ", waktu_absen_keluar=" & absen_keluar & " " &
                        "WHERE id_absensi=" & id_absensi & ";"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)

            'MsgBox(sqlQuery)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function checkEmployee(id_karyawan As Integer, nama As String) As Boolean
        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                 + ";password =" + password + ";database =" + database
        Try

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

    Public Function getEmployeeNameByID(id As Integer) As String
        Dim result As String
        dbConn.ConnectionString = "server =" + server + "; user id =" + username _
                                 + "; password =" + password + "; database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT nama FROM karyawan WHERE id_karyawan=" & id & ";"

            sqlRead = sqlCommand.ExecuteReader()
            sqlRead.Read()
            result = sqlRead.GetString(0)
            'Do While sqlRead.Read
            'Loop
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Function getEmployyeIDByName(nama As String) As Integer
        Dim id As Integer
        dbConn.ConnectionString = "server =" + server + ";user id =" + username _
                                    + ";password =" + password + ";database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "SELECT id_karyawan FROM karyawan WHERE nama='" & nama & "';"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)

            'MsgBox(sqlQuery)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Read()
            id = sqlRead.GetInt32(0)

            dbConn.Close()
            sqlRead.Close()

            Return id
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try
    End Function


End Class
