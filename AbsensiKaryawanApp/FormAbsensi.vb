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

        Dim stringMasuk = "'" & waktu_masuk.Year & "-" & waktu_masuk.Month & "-" &
                          waktu_masuk.Day & " " & waktu_masuk.Hour & ":" &
                          waktu_masuk.Minute & ":" & waktu_masuk.Second & "'"

        Dim stringKeluar = "'" & waktu_keluar.Year & "-" & waktu_keluar.Month & "-" &
                           waktu_keluar.Day & " " & waktu_keluar.Hour & ":" &
                           waktu_keluar.Minute & ":" & waktu_keluar.Second & "'"

        If Absensi.absensi.checkEmployee(employeeId, selectedEmployee) Then
            If RdnAbsenMasuk.Checked Then
                stringKeluar = "NULL"
            ElseIf RdnAbsenKeluar.Checked Then
                stringMasuk = "NULL"
            End If
            Absensi.absensi.addDataAbsen(employeeId, Date.Today, stringMasuk, stringKeluar)
            Me.Close()
            Absensi.Show()
        End If
    End Sub

    Private Sub FormAbsensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBNamaPegawai.DataSource = Absensi.absensi.getEmployeesName()
    End Sub

    Private Sub FormAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()

    End Sub

    Private Sub FormAbsensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        waktu_masuk = DateAndTime.Now
        waktu_keluar = DateAndTime.Now
    End Sub
End Class