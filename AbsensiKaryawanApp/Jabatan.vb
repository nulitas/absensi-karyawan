Public Class Jabatan

    Public Shared jabatan = New JabatanClass
    Public Shared selectedTableJabatan
    Public Shared selectedTableJabatanNama

    Private Sub ReloadDataTableDatabase()
        DataGridViewJabatan.DataSource = jabatan.GetDataJabatanDatabase()
    End Sub

    Private Sub BtnTambahJabatan_Click(sender As Object, e As EventArgs) Handles BtnTambahJabatan.Click
        TambahJabatan.Show()
    End Sub

    Private Sub BtnEditJabatan_Click(sender As Object, e As EventArgs) Handles BtnEditJabatan.Click
        Dim selectedJabatan As List(Of String) = jabatan.GetDataJabatanByIDDatabase(selectedTableJabatan)


        jabatan.GSNama = selectedJabatan(2)
        jabatan.GSGaji = selectedJabatan(1)

        EditJabatan.Show()
    End Sub

    Private Sub BtnHapusJabatan_Click(sender As Object, e As EventArgs) Handles BtnHapusJabatan.Click
        HapusJabatan.Show()
    End Sub

    Private Sub Jabatan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridViewJabatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJabatan.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewJabatan.Rows(index)

        selectedTableJabatan = selectedRow.Cells(0).Value
        selectedTableJabatanNama = selectedRow.Cells(1).Value
    End Sub
End Class