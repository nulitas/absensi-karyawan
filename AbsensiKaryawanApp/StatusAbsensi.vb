Public Class StatusAbsensi

    Dim emp_id
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        emp_id = Absensi.absensi.GSid_karyawan

        LblIdAbsensi.Text = Absensi.absensi.GSid_absensi
        CBNamaPegawai.SelectedItem = Absensi.absensi.GetEmployeeNameByID(emp_id)
        DPTanggal.Format = DateTimePickerFormat.Custom
        DPTanggal.CustomFormat = "yyyy/MM/dd"
        DPTanggal.Value = Absensi.absensi.GStanggal

        DPWaktuMasuk.Format = DateTimePickerFormat.Custom
        DPWaktuMasuk.CustomFormat = "HH:mm:ss"

        DPWaktuKeluar.Format = DateTimePickerFormat.Custom
        DPWaktuKeluar.CustomFormat = "HH:mm:ss"

        DPWaktuMasuk.Value = Absensi.absensi.GStanggal & " " & Absensi.absensi.GSwaktu_masuk
        If Absensi.absensi.GSwaktu_keluar = "NULL" Then
            DPWaktuKeluar.Value = Absensi.absensi.GStanggal
        Else
            DPWaktuKeluar.Value = Absensi.absensi.GStanggal & " " & Absensi.absensi.GSwaktu_keluar
        End If

    End Sub

    Private Sub StatusAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()
    End Sub

    Private Sub StatusAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CBNamaPegawai.DataSource = Absensi.absensi.GetEmployeesNameList
        CBNamaPegawai.SelectedItem = Absensi.absensi.GetEmployeeNameByID(emp_id)
    End Sub

    Private Sub BtnAbsen_Click(sender As Object, e As EventArgs) Handles BtnAbsen.Click
        Dim idEmployee = Absensi.absensi.GetEmployyeIDByName(CBNamaPegawai.SelectedValue)


        Dim stringMasuk = "'" & DPWaktuMasuk.Value.Hour & ":" & DPWaktuMasuk.Value.Minute &
                            ":" & DPWaktuMasuk.Value.Second & "'"

        Dim stringKeluar = "'" & DPWaktuKeluar.Value.Hour & ":" & DPWaktuKeluar.Value.Minute &
                            ":" & DPWaktuKeluar.Value.Second & "'"

        Absensi.absensi.UpdateDataAbsensi(LblIdAbsensi.Text,
                                          idEmployee,
                                          DPTanggal.Value,
                                          stringMasuk,
                                          stringKeluar)
        Me.Close()
        Absensi.Show()
    End Sub

    Private Sub StatusAbsensi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
End Class