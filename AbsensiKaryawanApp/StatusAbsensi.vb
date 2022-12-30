Public Class StatusAbsensi

    Dim emp_id
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        emp_id = Absensi.absensi.GSid_karyawan

        LblIdAbsensi.Text = Absensi.absensi.GSid_absensi
        CBNamaPegawai.SelectedItem = Absensi.absensi.getEmployeeNameByID(emp_id)
        DPTanggal.Format = DateTimePickerFormat.Custom
        DPTanggal.CustomFormat = "yyyy/MM/dd"
        DPTanggal.Value = Absensi.absensi.GStanggal

        DPWaktu.Format = DateTimePickerFormat.Custom
        DPWaktu.CustomFormat = "HH:mm:ss"


        If Absensi.absensi.GSwaktu_masuk <> "NULL" Then
            RdnAbsenMasuk.Checked = True
            DPWaktu.Value = Absensi.absensi.GSwaktu_masuk
        ElseIf Absensi.absensi.GSwaktu_keluar <> "NULL" Then
            RdnAbsenKeluar.Checked = True
            DPWaktu.Value = Absensi.absensi.GSwaktu_keluar
        End If

    End Sub

    Private Sub StatusAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()
    End Sub

    Private Sub StatusAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CBNamaPegawai.DataSource = Absensi.absensi.getEmployeesName
        CBNamaPegawai.SelectedItem = Absensi.absensi.getEmployeeNameByID(emp_id)
    End Sub

    Private Sub BtnAbsen_Click(sender As Object, e As EventArgs) Handles BtnAbsen.Click
        Dim idEmployee = Absensi.absensi.getEmployyeIDByName(CBNamaPegawai.SelectedValue)


        Dim stringMasuk = "'" & DPTanggal.Value.Year & "-" & DPTanggal.Value.Month & "-" &
                          DPTanggal.Value.Day & " " & DPWaktu.Value.Hour & ":" &
                          DPWaktu.Value.Minute & ":" & DPWaktu.Value.Second & "'"

        Dim stringKeluar = "'" & DPTanggal.Value.Year & "-" & DPTanggal.Value.Month & "-" &
                           DPTanggal.Value.Day & " " & DPWaktu.Value.Hour & ":" &
                           DPWaktu.Value.Minute & ":" & DPWaktu.Value.Second & "'"

        If RdnAbsenMasuk.Checked Then
            stringKeluar = "NULL"
        ElseIf RdnAbsenKeluar.Checked Then
            stringMasuk = "NULL"
        End If
        Absensi.absensi.updateDataAbsensi(idEmployee, DPTanggal.Value, stringMasuk, stringKeluar)
        Me.Close()
        Absensi.Show()
    End Sub
End Class