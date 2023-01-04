Public Class Absensi
    Public Shared absensi As AbsensiClass

    Dim selectedAbsensiId As Integer = 0

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        absensi = New AbsensiClass
        ReloadDataTable()
        DataGridViewAbsensi.ClearSelection()

    End Sub


    Private Sub ReloadDataTable()
        DataGridViewAbsensi.DataSource = absensi.GetDataAbsensi()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        AbsensiKaryawan.Show()
        Me.Close()
    End Sub

    Private Sub BtnAbsenMasuk_Click(sender As Object, e As EventArgs) Handles BtnAbsenMasuk.Click
        FormAbsensi.Show()
        Me.Hide()

    End Sub

    Private Sub Absensi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTable()
        DataGridViewAbsensi.ClearSelection()
    End Sub

    Private Sub BtnEditAbsensi_Click(sender As Object, e As EventArgs) Handles BtnEditAbsensi.Click
        Try
            Dim selectedAbsen As List(Of String) = absensi.GetDataAbsensiByID(selectedAbsensiId)

            absensi.GSid_absensi = selectedAbsensiId
            absensi.GSid_karyawan = selectedAbsen(0)
            absensi.GStanggal = selectedAbsen(1)
            absensi.GSwaktu_masuk = selectedAbsen(2)
            absensi.GSwaktu_keluar = selectedAbsen(3)

            StatusAbsensi.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Harap pilih baris terlebih dahulu sebelum mengedit!")
        End Try

    End Sub

    Private Sub DataGridViewAbsensi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbsensi.CellClick
        Dim index As Integer = DataGridViewAbsensi.CurrentRow.Index
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewAbsensi.Rows(index)

        selectedAbsensiId = selectedRow.Cells(0).Value
    End Sub

    Private Sub BtnHapusAbsensi_Click(sender As Object, e As EventArgs) Handles BtnHapusAbsensi.Click
        Try
            Dim selectedAbsen As List(Of String) = absensi.GetDataAbsensiByID(selectedAbsensiId)

            absensi.GSid_absensi = selectedAbsensiId
            absensi.GSid_karyawan = selectedAbsen(0)
            absensi.GStanggal = selectedAbsen(1)
            absensi.GSwaktu_masuk = selectedAbsen(2)
            absensi.GSwaktu_keluar = selectedAbsen(3)

            HapusAbsensi.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class