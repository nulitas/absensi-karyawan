Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class GSAbsensi




    Private jabatan As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"



    Public Property GSJabatan() As String
        Get
            Return jabatan
        End Get
        Set(value As String)
            jabatan = value
        End Set
    End Property


End Class
