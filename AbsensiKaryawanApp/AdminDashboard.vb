Public Class AdminDashboard


    Private Sub AbsensiKaryawan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()

    End Sub

    Private Sub BtnFormKaryawan_Click(sender As Object, e As EventArgs) Handles BtnFormKaryawan.Click
        Karyawan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFormJabatan_Click(sender As Object, e As EventArgs) Handles BtnFormJabatan.Click
        Jabatan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFormPenggajian_Click(sender As Object, e As EventArgs) Handles BtnFormPenggajian.Click
        Penggajian.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        AbsensiKaryawan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDataAbsensi_Click(sender As Object, e As EventArgs) Handles BtnDataAbsensi.Click
        Absensi.Show()
        Me.Hide()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
End Class