Public Class Absensi
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim mainmenu = New AbsensiKaryawan
        mainmenu.Show()
        Me.Close()
    End Sub

    Private Sub BtnAbsenMasuk_Click(sender As Object, e As EventArgs) Handles BtnAbsenMasuk.Click
        AbsensiMasuk.Show()
        Me.Hide()

    End Sub

    Private Sub BtnAbsenKeluar_Click(sender As Object, e As EventArgs) Handles BtnAbsenKeluar.Click
        AbsensiKeluar.Show()
        Me.Hide()

    End Sub
End Class