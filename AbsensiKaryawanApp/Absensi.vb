Public Class Absensi
    Public Shared absensi As AbsensiClass

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        absensi = New AbsensiClass
        ReloadDataTable()

    End Sub


    Private Sub ReloadDataTable()
        DataGridViewAbsensi.DataSource = absensi.GetDataAbsensi()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        AbsensiKaryawan.Show()
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