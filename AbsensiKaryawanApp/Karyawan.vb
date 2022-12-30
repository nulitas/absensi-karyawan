Public Class Karyawan

    Public Shared karyawan = New KaryawanClass
    Public Shared selectedTableKaryawan
    Public Shared selectedTableKaryawanNama

    Private Sub ReloadDataTableDatabase()
        DataGridViewKaryawan.DataSource = AbsensiKaryawan.karyawan.GetDataKaryawanDatabase()
    End Sub


    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        TambahKaryawan.Show()
    End Sub

    Private Sub DataGridViewKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKaryawan.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKaryawan.Rows(index)

        selectedTableKaryawan = selectedRow.Cells(0).Value
        selectedTableKaryawanNama = selectedRow.Cells(2).Value

    End Sub

    Private Sub BtnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles BtnHapusKaryawan.Click
        HapusKaryawan.Show()
    End Sub

    Private Sub BtnEditKaryawan_Click(sender As Object, e As EventArgs) Handles BtnEditKaryawan.Click


        Dim selectedKaryawan As List(Of String) = karyawan.GetDataKaryawanByIDDatabase(selectedTableKaryawan)


        karyawan.GSNik = selectedKaryawan(1)
        karyawan.GSNama = selectedKaryawan(2)
        karyawan.GSAlamat = selectedKaryawan(3)
        karyawan.GSJabatan = selectedKaryawan(4)

        UbahKaryawan.Show()
    End Sub
End Class