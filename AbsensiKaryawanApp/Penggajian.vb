Public Class Penggajian

    Public Shared penggajian = New PenggajianClass

    Private Sub Penggajian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewPenggajian.DataSource = penggajian.GetDataPenggajian()
    End Sub
End Class