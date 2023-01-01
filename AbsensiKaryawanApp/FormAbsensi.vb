Public Class FormAbsensi

    Dim waktu_masuk As DateTime
    Dim waktu_keluar As DateTime

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnAbsen_Click(sender As Object, e As EventArgs) Handles BtnAbsen.Click

        Dim selectedEmployee = CBNamaPegawai.SelectedValue
        Dim employeeId = Integer.Parse(TxtIdPegawai.Text)

        Dim stringMasuk As String = "NULL"
        Dim stringKeluar As String = "NULL"

        If Absensi.absensi.CheckEmployee(employeeId, selectedEmployee) Then
            If RdnAbsenMasuk.Checked Then
                'stringKeluar = "NULL"
                stringMasuk = "'" & waktu_masuk.Hour & ":" &
                          waktu_masuk.Minute & ":" & waktu_masuk.Second & "'"
            ElseIf RdnAbsenKeluar.Checked Then
                'stringMasuk = "NULL"
                stringKeluar = "'" & waktu_keluar.Hour & ":" &
                           waktu_keluar.Minute & ":" & waktu_keluar.Second & "'"
            End If
            Absensi.absensi.AddDataAbsen(employeeId, Date.Today, stringMasuk, stringKeluar)
            Me.Close()
            Absensi.Show()
        End If
    End Sub

    Private Sub FormAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()

    End Sub

    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CBNamaPegawai.DataSource = Absensi.absensi.GetEmployeesNameList()
        waktu_masuk = DateAndTime.Now
        waktu_keluar = DateAndTime.Now
    End Sub
End Class