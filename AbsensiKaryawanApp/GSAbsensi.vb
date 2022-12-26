Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class GSAbsensi



    Private foto As String
    Private jabatan As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
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




End Class
