Public Class TambahJabatan


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text
        Jabatan.jabatan.GSGaji = TxtGaji.Text

        Jabatan.jabatan.AddDataJabatan(Jabatan.jabatan.GSNama, Jabatan.jabatan.GSGaji)

        Me.Close()

    End Sub

    Private Sub TambahJabatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
End Class