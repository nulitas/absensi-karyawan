Public Class Jabatan

    Public Shared jabatan = New JabatanClass
    Public Shared selectedTableJabatan
    Public Shared selectedTableJabatanNama

    Private Sub ReloadDataTableDatabase()
        DataGridViewJabatan.DataSource = jabatan.GetDataJabatan()
        DataGridViewJabatan.Rows(0).Cells(0).Selected = False
    End Sub

    Private Sub BtnTambahJabatan_Click(sender As Object, e As EventArgs) Handles BtnTambahJabatan.Click
        TambahJabatan.Show()
    End Sub

    Private Sub BtnEditJabatan_Click(sender As Object, e As EventArgs) Handles BtnEditJabatan.Click


        Try
            Dim selectedJabatan As List(Of String) = jabatan.GetDataJabatanByID(selectedTableJabatan)


            jabatan.GSNama = selectedJabatan(1)
            jabatan.GSGaji = selectedJabatan(2)

            EditJabatan.Show()

        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try

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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Jabatan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AdminDashboard.Show()
    End Sub

    Private Sub Jabatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class