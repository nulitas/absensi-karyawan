Public Class HapusKaryawan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapusKaryawan.Text() = Karyawan.selectedTableKaryawanNama
    End Sub
    Private Sub BtnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles BtnHapusKaryawan.Click
        Karyawan.karyawan.DeleteDataKaryawan(Karyawan.selectedTableKaryawan)

        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class