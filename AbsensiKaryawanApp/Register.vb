Public Class Register

    Public FotoShare


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtPassword.UseSystemPasswordChar = True
        TxtConfirmPassword.UseSystemPasswordChar = True


    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
            If String.Compare(TxtPassword.Text, TxtConfirmPassword.Text) = 0 Then
                Login.Users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text, FotoShare)
                Me.Close()
            Else
                MessageBox.Show("Error!")
            End If

        Else
            MessageBox.Show("Insert Data!")
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "All Format|*.*"
        OpenFileDialog1.ShowDialog()

        FotoShare = OpenFileDialog1.FileName

        PictureBox1.Load(FotoShare)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        AbsensiKaryawan.GSAbsensi.GSFoto = FotoShare.ToString()
        AbsensiKaryawan.GSAbsensi.GSFoto = AbsensiKaryawan.GSAbsensi.GSFoto.Replace("\", "/")
    End Sub
End Class