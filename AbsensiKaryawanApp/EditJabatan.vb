Public Class EditJabatan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtNamaJabatan.Text = Jabatan.jabatan.GSNama
        TxtGaji.Text = Jabatan.jabatan.GSGaji

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text.ToString()
        Jabatan.jabatan.GSGaji = TxtGaji.Text.ToString()

        Jabatan.jabatan.UpdateDataJabataniByIDDatabase(Jabatan.selectedTableJabatan, Jabatan.jabatan.GSGaji, Jabatan.jabatan.GSNama)

        Me.Close()

    End Sub
End Class