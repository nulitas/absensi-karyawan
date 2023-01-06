Public Class HapusPenggajian

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapusPenggajian.Text() = Penggajian.selectedGaji
    End Sub
    Private Sub BtnHapusPenggajian_Click(sender As Object, e As EventArgs) Handles BtnHapusPenggajian.Click
        Penggajian.penggajian.deleteDataPenggajian(Penggajian.selectedGaji)

        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class