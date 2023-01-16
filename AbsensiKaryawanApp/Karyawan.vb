Imports Google.Protobuf.WellKnownTypes

Public Class Karyawan

    Public Shared karyawan = New KaryawanClass
    Public Shared selectedTableKaryawan
    Public Shared selectedTableKaryawanNama

    Private Sub ReloadDataTableDatabase()
        DataGridViewKaryawan.DataSource = karyawan.GetDataKaryawan()
        DataGridViewKaryawan.Rows(0).Cells(0).Selected = False
    End Sub

    Private Sub Karyawan_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnTambahKaryawan.Click
        TambahKaryawan.Show()
    End Sub

    Private Sub DataGridViewKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKaryawan.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewKaryawan.Rows(index)
        If index > -1 Then
            selectedTableKaryawan = selectedRow.Cells(0).Value
            selectedTableKaryawanNama = selectedRow.Cells(3).Value
        End If

    End Sub

    Private Sub BtnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles BtnHapusKaryawan.Click

        Try
            Dim selectedKaryawan As List(Of String) = karyawan.GetDataKaryawanByID(selectedTableKaryawan)
            HapusKaryawan.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try


    End Sub

    Private Sub BtnEditKaryawan_Click(sender As Object, e As EventArgs) Handles BtnEditKaryawan.Click


        Try
            Dim selectedKaryawan As List(Of String) = karyawan.GetDataKaryawanByID(selectedTableKaryawan)

            karyawan.GSFoto = selectedKaryawan(1)
            karyawan.GSNik = selectedKaryawan(2)
            karyawan.GSNama = selectedKaryawan(3)
            karyawan.GSAlamat = selectedKaryawan(4)
            karyawan.GSJabatan = selectedKaryawan(5)


            UbahKaryawan.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Karyawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Karyawan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AdminDashboard.Show()
    End Sub

    Private Sub BtnBack_Click_1(sender As Object, e As EventArgs) Handles BtnBack.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class