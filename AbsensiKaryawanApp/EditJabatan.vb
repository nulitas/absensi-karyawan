Public Class EditJabatan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtNamaJabatan.Text = Jabatan.jabatan.GSNama
        TxtGaji.Text = Jabatan.jabatan.GSGaji

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text
        Jabatan.jabatan.GSGaji = TxtGaji.Text

        Jabatan.jabatan.UpdateDataKoleksiByIDDatabase(Jabatan.selectedTableJabatan,  , Jabatan.jabatan.GSNama, Jabatan.jabatan.GSGaji)

    End Sub
End Class