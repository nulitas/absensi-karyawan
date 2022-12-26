Public Class Karyawan

    Public Shared GSAbsensi = New GSAbsensi

    Private Sub ReloadDataTableDatabase()
        DataGridViewKaryawan.DataSource = GSAbsensi.GetDataKaryawanDatabase()
    End Sub


    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        TambahKaryawan.Show()
    End Sub
End Class