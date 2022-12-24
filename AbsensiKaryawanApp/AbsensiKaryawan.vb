Public Class AbsensiKaryawan

    Public Shared GSAbsensi = New GSAbsensi

    Private Sub BtnFormAbsensi_Click(sender As Object, e As EventArgs) Handles BtnFormAbsensi.Click
        Absensi.Show()
        Me.Hide()
    End Sub

    Private Sub AbsensiKaryawan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class
