Public Class TambahJabatan


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text
        Jabatan.jabatan.GSGaji = TxtGaji.Text

        Jabatan.jabatan.AddDataJabatanDatabase(Jabatan.jabatan.GSNama, Jabatan.jabatan.GSGaji)

        Me.Close()

    End Sub
End Class