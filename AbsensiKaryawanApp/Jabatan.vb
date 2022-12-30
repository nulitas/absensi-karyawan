Public Class Jabatan

    Public Shared jabatan = New JabatanClass
    Public Shared selectedTableJabatan
    Public Shared selectedTableJabatanNama

    Private Sub ReloadDataTableDatabase()
        DataGridViewJabatan.DataSource = jabatan.GetDataKaryawanDatabase()
    End Sub

    Private Sub BtnTambahJabatan_Click(sender As Object, e As EventArgs) Handles BtnTambahJabatan.Click
        TambahJabatan.Show()
    End Sub

    Private Sub BtnEditJabatan_Click(sender As Object, e As EventArgs) Handles BtnEditJabatan.Click
        EditJabatan.Show()
    End Sub

    Private Sub BtnHapusJabatan_Click(sender As Object, e As EventArgs) Handles BtnHapusJabatan.Click
        HapusJabatan.Show()
    End Sub

    Private Sub Jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class