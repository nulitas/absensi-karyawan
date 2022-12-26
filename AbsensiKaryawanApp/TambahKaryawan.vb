Imports MySql.Data.MySqlClient

Public Class TambahKaryawan

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared da As New MySqlDataAdapter

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"
    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        AbsensiKaryawan.GSAbsensi.GSJabatan = CBJabatan.Text

        MessageBox.Show(CBJabatan.Text)



    End Sub

    Private Sub TambahKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jabatan, nama_jabatan from jabatan"

        da.SelectCommand = sqlCommand

        Dim table1 As New DataTable

        da.Fill(table1)


        CBJabatan.DataSource = table1
        CBJabatan.DisplayMember = "nama_jabatan"
        CBJabatan.ValueMember = "id_jabatan"



    End Sub
End Class