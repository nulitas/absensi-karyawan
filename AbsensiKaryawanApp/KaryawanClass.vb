Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class KaryawanClass

    Private foto As String
    Private nik As String
    Private nama As String
    Private alamat As String
    Private jabatan As String



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

    Public Property GSJabatan() As String
        Get
            Return jabatan
        End Get
        Set(value As String)
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

    Public Function GetDataKaryawan() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan AS 'ID',
                                  foto as 'Foto',
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

    Public Function GetDataKaryawanByID(ID As Integer) As List(Of String)

        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan AS 'ID',
                                  foto as 'Foto',
                                  nik as 'NIK',
                                  nama AS 'Nama Karyawan',
                                  alamat AS 'Alamat',
                                  id_jabatan AS 'ID Jabatan'
                                  FROM karyawan  WHERE id_karyawan='" & ID & "' "
        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function AddDataKaryawan(foto_karyawan As String, nik_karyawan As String, nama_karyawan As String, alamat_karyawan As String, jabatan_id As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO karyawan (foto, nik, nama, alamat,id_jabatan ) VALUE('" _
                        & foto_karyawan & "', '" _
                        & nik_karyawan & "', '" _
                        & nama_karyawan & "', '" _
                        & alamat_karyawan & "', '" _
                        & jabatan_id & "')"


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



    Public Function DeleteDataKaryawan(ID As Integer)

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

    Public Function UpdateDataKaryawanByID(id_karyawan As Integer, foto_karyawan As String,
                                  nik_karyawan As String, nama_karyawan As String, alamat_karyawan As String, jabatan_id As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn


            sqlQuery = "UPDATE karyawan
                        SET id_karyawan=" & id_karyawan &
                        ", foto='" & foto_karyawan &
                        "', nik='" & nik_karyawan &
                        "', nama= '" & nama_karyawan &
                         "',alamat='" & alamat_karyawan &
                        "', id_jabatan= '" & jabatan_id & "' " &
                        "WHERE id_karyawan= " & id_karyawan & ";"

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
