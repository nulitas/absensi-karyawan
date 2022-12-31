Public Class AbsensiKaryawan

    Public Shared GSAbsensi = New GSAbsensi
    Public Shared karyawan = New KaryawanClass

    Private Sub BtnFormKaryawan_Click(sender As Object, e As EventArgs) Handles BtnFormKaryawan.Click
        karyawan.Show()
    End Sub
End Class
