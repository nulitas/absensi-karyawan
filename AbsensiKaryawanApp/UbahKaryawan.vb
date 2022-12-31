Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class UbahKaryawan

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared da As New MySqlDataAdapter

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtNama.Text = Karyawan.karyawan.GSNama
        TxtNik.Text = Karyawan.karyawan.GSNik
        TxtAlamat.Text = Karyawan.karyawan.GSAlamat
        CBJabatan.Text = Karyawan.karyawan.GSJabatan
        'TxtJabatan.Text = Karyawan.karyawan.GSJabatan


    End Sub

    Private Sub BtnUbahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnUbahKaryawan.Click
        AbsensiKaryawan.karyawan.GSJabatan = CBJabatan.SelectedValue
        'AbsensiKaryawan.karyawan.GSJabatan = TxtJabatan.Text
        AbsensiKaryawan.karyawan.GSNama = TxtNama.Text
        AbsensiKaryawan.karyawan.GSNik = TxtNik.Text
        AbsensiKaryawan.karyawan.GSAlamat = TxtAlamat.Text


        AbsensiKaryawan.karyawan.UpdateDataKaryawanByIDDatabase(Karyawan.selectedTableKaryawan, AbsensiKaryawan.karyawan.GSNik, AbsensiKaryawan.karyawan.GSNama, AbsensiKaryawan.karyawan.GSAlamat, AbsensiKaryawan.karyawan.GSJabatan)
        Me.Close()
    End Sub
    Private Sub UbahKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + Database + ";" + "Convert Zero Datetime=True"
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_jabatan, nama_jabatan from jabatan"

            da.SelectCommand = sqlCommand

            Dim table1 As New DataTable

            da.Fill(table1)


            CBJabatan.DataSource = table1
            CBJabatan.DisplayMember = "nama_jabatan"
            CBJabatan.ValueMember = "id_jabatan"

        Catch ex As Exception

        Finally
            dbConn.Dispose()
        End Try
    End Sub
End Class