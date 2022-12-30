Public Class HapusJabatan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LblHapusJabatan.Text() = Jabatan.selectedTableJabatanNama

    End Sub

    Private Sub HapusJabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Jabatan.jabatan.DeleteDataJabatanDatabase(Jabatan.selectedTableJabatan)

    End Sub
End Class