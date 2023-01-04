Public Class HapusAbsensi

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblidAbsensi.Text = Absensi.absensi.GSid_absensi
        LblKaryawan.Text = Absensi.absensi.GSid_karyawan &
                           " - " & Absensi.absensi.GetEmployeeNameByID(Absensi.absensi.GSid_karyawan)
        LblTanggal.Text = Absensi.absensi.GStanggal
        LblWaktuMasuk.Text = Absensi.absensi.GSwaktu_masuk
        LblWaktuKeluar.Text = Absensi.absensi.GSwaktu_keluar
        'If Absensi.absensi.GSwaktu_keluar <> "NULL" Then
        'ElseIf Absensi.absensi.GSwaktu_masuk <> "NULL" Then
        '    LblJenisAbsen.Text = "Absen Masuk"
        'End If

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

    Private Sub BtnHapusAbsensi_Click(sender As Object, e As EventArgs) Handles BtnHapusAbsensi.Click
        Absensi.absensi.DeleteDataAbsensi(Absensi.absensi.GSid_absensi)
        Me.Close()
    End Sub

    Private Sub HapusAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()
    End Sub
End Class