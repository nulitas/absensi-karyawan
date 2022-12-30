Public Class UbahKaryawan


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtNama.Text = Karyawan.karyawan.GSNama
        TxtNik.Text = Karyawan.karyawan.GSNik
        TxtAlamat.Text = Karyawan.karyawan.GSAlamat
        CBJabatan.Text = Karyawan.karyawan.GSJabatan
        'TxtJabatan.Text = Karyawan.karyawan.GSJabatan


    End Sub

    Private Sub BtnUbahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnUbahKaryawan.Click
        AbsensiKaryawan.karyawan.GSJabatan = CBJabatan.SelectedValue()
        AbsensiKaryawan.karyawan.GSNama = TxtNama.Text
        AbsensiKaryawan.karyawan.GSNik = TxtNik.Text
        AbsensiKaryawan.karyawan.GSAlamat = TxtAlamat.Text


        AbsensiKaryawan.karyawan.UpdateDataKaryawanByIDDatabase(Karyawan.selectedTableKaryawan, AbsensiKaryawan.karyawan.GSNik, AbsensiKaryawan.karyawan.GSNama, AbsensiKaryawan.karyawan.GSAlamat, AbsensiKaryawan.karyawan.GSJabatan)

        Me.Close()


    End Sub
End Class