Imports MySql.Data.MySqlClient

Public Class KaryawanClass


    Private foto As String
    Private nik As String
    Private nama As String
    Private alamat As String
    Private jabatan As Integer
    Private db As Database
    Public Sub New()
        db = New Database()
    End Sub





    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String


    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSJabatan() As Integer
        Get
            Return jabatan
        End Get
        Set(value As Integer)
            jabatan = value
        End Set
    End Property

    Public Property GSNik() As String
        Get
            Return nik
        End Get
        Set(value As String)
            nik = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(value As String)
            alamat = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property

    Public Function GetDataKaryawanDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan AS 'ID',
                                  nik as 'NIK',
                                  nama AS 'Nama Karyawan',
                                  alamat AS 'Alamat',
                                  id_jabatan AS 'ID Jabatan'
                                  FROM karyawan"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKaryawanDatabase(nik_karyawan As String, nama_karyawan As String, alamat_karyawan As String, jabatan As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO karyawan (nik, nama, alamat,id_jabatan ) VALUE('" _
                        & nik_karyawan & "', '" _
                        & nama_karyawan & "', '" _
                        & alamat_karyawan & "', '" _
                        & jabatan & "')"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function



    Public Function DeleteDataKaryawanDatabase(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM karyawan " &
                "WHERE id_karyawan='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                  nik_karyawan As String, nama_karyawan As String, alamat_karyawan As String, jabatan As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE karyawan SET " &
                        "nik = '" & nik_karyawan & "',  " &
                        "nama = '" & nama_karyawan & "',  " &
                        "alamat = '" & alamat_karyawan & "',  " &
                        "WHERE id_koleksi= '" & ID & "'"
            Debug.Print(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function



End Class
