Public Class HapusKaryawan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapusKaryawan.Text() = Karyawan.selectedTableKaryawanNama
    End Sub
    Private Sub BtnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles BtnHapusKaryawan.Click
        AbsensiKaryawan.karyawan.DeleteDataKaryawanDatabase(Karyawan.selectedTableKaryawan)

        Me.Close()
    End Sub
End Class