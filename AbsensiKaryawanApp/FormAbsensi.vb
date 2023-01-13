Public Class FormAbsensi

    Dim waktu_masuk As DateTime
    Dim waktu_keluar As DateTime

    Dim id_karyawan
    Dim id_absen

    Dim absensi As AbsensiClass

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        absensi = New AbsensiClass
        CBNamaPegawai.DataSource = absensi.GetEmployeesNameList()
    End Sub

    Private Sub BtnAbsen_Click(sender As Object, e As EventArgs) Handles BtnAbsen.Click

        Dim selectedEmployee = CBNamaPegawai.SelectedValue
        Dim employeeId = Integer.Parse(TxtIdPegawai.Text)

        Dim stringMasuk As String = "NULL"
        Dim stringKeluar As String = "NULL"

        If absensi.CheckEmployee(employeeId, selectedEmployee) Then
            If RdnAbsenMasuk.Checked Then

                stringMasuk = "'" & waktu_masuk.Hour & ":" &
                              waktu_masuk.Minute & ":" & waktu_masuk.Second & "'"
                absensi.AddDataAbsen(employeeId, Date.Today, stringMasuk, stringKeluar)
            ElseIf RdnAbsenKeluar.Checked Then
                Dim datalist = absensi.GetDataAbsensiByID(id_absen)

                stringMasuk = "'" & Date.Today.Year & "-" & Date.Today.Month & "-" &
                              Date.Today.Day & " " & datalist(2) & "'"

                stringKeluar = "'" & waktu_keluar.Hour & ":" &
                               waktu_keluar.Minute & ":" & waktu_keluar.Second & "'"
                absensi.UpdateDataAbsensi(id_absen, id_karyawan, Date.Today, stringMasuk, stringKeluar)
            End If
            Me.Close()
            AbsensiKaryawan.Show()
        End If
    End Sub

    Private Sub FormAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AbsensiKaryawan.Show()

    End Sub

    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'CBNamaPegawai.DataSource = Absensi.absensi.GetEmployeesNameList()
        waktu_masuk = DateAndTime.Now
        waktu_keluar = DateAndTime.Now
    End Sub

    Private Sub CBNamaPegawai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNamaPegawai.SelectedIndexChanged
        id_karyawan = absensi.GetEmployyeIDByName(CBNamaPegawai.SelectedItem)
        id_absen = absensi.CheckOnAbsenKeluar(id_karyawan)
        'MsgBox(id_absen)
        Dim listdata = absensi.GetDataAbsensiByID(id_absen)

        If id_absen > 0 Then
            RdnAbsenMasuk.Enabled = False
            RdnAbsenKeluar.Enabled = True
            'MsgBox(id_absen)
            If listdata(3) <> "NULL" Then
                RdnAbsenMasuk.Enabled = False
                RdnAbsenKeluar.Enabled = False
            End If
        Else
            RdnAbsenMasuk.Enabled = True
            RdnAbsenKeluar.Enabled = False
        End If
    End Sub
End Class