Public Class StatusAbsensi

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub StatusAbsensi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Absensi.Show()
    End Sub
End Class