Imports MySql.Data.MySqlClient

Public Class TambahKaryawan

    Public Shared FotoKaryawan

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared da As New MySqlDataAdapter

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"
    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        'AbsensiKaryawan.GSAbsensi.GSJabatan = CBJabatan.Text


        AbsensiKaryawan.karyawan.GSJabatan = CBJabatan.SelectedValue()
        AbsensiKaryawan.karyawan.GSNama = TxtNama.Text
        AbsensiKaryawan.karyawan.GSNik = TxtNik.Text
        AbsensiKaryawan.karyawan.GSAlamat = TxtAlamat.Text



        AbsensiKaryawan.karyawan.AddDataKaryawanDatabase(AbsensiKaryawan.karyawan.GSNik, AbsensiKaryawan.karyawan.GSNama, AbsensiKaryawan.karyawan.GSAlamat, AbsensiKaryawan.karyawan.GSJabatan)

        'Me.Close()
    End Sub

    Private Sub TambahKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
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



    Private Sub BtnUploadFoto_Click(sender As Object, e As EventArgs) Handles BtnUploadFoto.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "All Format|*.*"
        OpenFileDialog1.ShowDialog()

        FotoKaryawan = OpenFileDialog1.FileName

        PictureBox1.Load(FotoKaryawan)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        AbsensiKaryawan.karyawan.GSFoto = FotoKaryawan.ToString()
        AbsensiKaryawan.karyawan.GSFoto = AbsensiKaryawan.karyawan.GSFoto.Replace("\", "/")
    End Sub

    Private Sub TxtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNik.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Angka")

        End If
    End Sub
End Class