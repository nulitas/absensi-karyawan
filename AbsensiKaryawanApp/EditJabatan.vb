Public Class EditJabatan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtNamaJabatan.Text = Jabatan.jabatan.GSNama
        TxtGaji.Text = Jabatan.jabatan.GSGaji

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnEdit_Click_1(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Jabatan.jabatan.GSNama = TxtNamaJabatan.Text.ToString()
        Jabatan.jabatan.GSGaji = TxtGaji.Text.ToString()

        Jabatan.jabatan.UpdateDataJabataniByID(Jabatan.selectedTableJabatan, Jabatan.jabatan.GSNama, Jabatan.jabatan.GSGaji)

        Me.Close()
    End Sub

    Private Sub EditJabatan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
End Class