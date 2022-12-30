Public Class TambahJabatan
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtGaji.TextChanged

    End Sub

    Private Sub TxtNamaJabatan_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaJabatan.TextChanged

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text
        Jabatan.jabatan.GSGaji = TxtGaji.Text

        Jabatan.jabatan.AddDataJabatanDatabase(Jabatan.jabatan.GSNama, Jabatan.jabatan.GSGaji)

        Me.Close()

    End Sub
End Class