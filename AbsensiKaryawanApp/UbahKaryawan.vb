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
        PictureBox1.Load(Karyawan.karyawan.GSFoto)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        TxtNama.Text = Karyawan.karyawan.GSNama
        TxtNik.Text = Karyawan.karyawan.GSNik
        TxtAlamat.Text = Karyawan.karyawan.GSAlamat
        CBJabatan.Text = Karyawan.karyawan.GSJabatan
        'TxtJabatan.Text = Karyawan.karyawan.GSJabatan


    End Sub

    Private Sub BtnUploadFoto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnUploadFoto_Click_1(sender As Object, e As EventArgs) Handles BtnUploadFoto.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "All Format|*.*"
        OpenFileDialog1.ShowDialog()



        Dim picKKaryawanDir As String = OpenFileDialog1.FileName

        PictureBox1.Load(picKKaryawanDir)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Karyawan.karyawan.GSFoto = picKKaryawanDir.ToString()
        Karyawan.karyawan.GSFoto = Karyawan.karyawan.GSFoto.Replace("\", "/")
    End Sub
    Private Sub UbahKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
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


    Private Sub BtnUbahKaryawan_Click_1(sender As Object, e As EventArgs) Handles BtnUbahKaryawan.Click
        Karyawan.karyawan.GSJabatan = CBJabatan.SelectedValue
        'AbsensiKaryawan.karyawan.GSJabatan = TxtJabatan.Text
        Karyawan.karyawan.GSNama = TxtNama.Text
        Karyawan.karyawan.GSNik = TxtNik.Text
        Karyawan.karyawan.GSAlamat = TxtAlamat.Text


        Karyawan.karyawan.UpdateDataKaryawanByID(Karyawan.selectedTableKaryawan, Karyawan.karyawan.GSFoto, Karyawan.karyawan.GSNik, Karyawan.karyawan.GSNama, Karyawan.karyawan.GSAlamat, Karyawan.karyawan.GSJabatan)
        Me.Close()
    End Sub
End Class