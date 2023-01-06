Public Class Penggajian

    Public Shared selectedGaji
    Public Shared penggajian As PenggajianClass
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        penggajian = New PenggajianClass()

    End Sub
    Private Sub Penggajian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewPenggajian.DataSource = penggajian.GetDataPenggajian()
    End Sub

    Private Sub BtnHitungGaji_Click(sender As Object, e As EventArgs) Handles BtnHitungGaji.Click
        HitungPenggajian.Show()
    End Sub

    Private Sub DataGridViewPenggajian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPenggajian.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewPenggajian.Rows(index)
        If index > -1 Then
            selectedGaji = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub BtnEditGaji_Click(sender As Object, e As EventArgs) Handles BtnEditGaji.Click
        Try
            Dim selectedGajiKaryawan As List(Of String) = penggajian.getPenggajianByID(selectedGaji)

            penggajian.GSIdPenggajian = selectedGaji()
            penggajian.GSIdKaryawan = selectedGajiKaryawan(0)
            penggajian.GSBulan = selectedGajiKaryawan(1)
            penggajian.GSTotalGaji = selectedGajiKaryawan(2)

            UbahPenggajian.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnHapusGaji_Click(sender As Object, e As EventArgs) Handles BtnHapusGaji.Click
        HapusPenggajian.Show()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        AbsensiKaryawan.Show()
    End Sub
End Class