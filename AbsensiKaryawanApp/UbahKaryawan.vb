Public Class UbahKaryawan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



        TxtNama.Text = AbsensiKaryawan.karyawan.GSNama
        TxtNik.Text = AbsensiKaryawan.karyawan.GSNik
        TxtAlamat.Text = AbsensiKaryawan.karyawan.GSAlamat
        CBJabatan.SelectedValue = AbsensiKaryawan.karyawan.GSJabatan

    End Sub

    Private Sub BtnUbahKaryawan_Click(sender As Object, e As EventArgs) Handles BtnUbahKaryawan.Click
        AbsensiKaryawan.karyawan.GSJabatan = CBJabatan.SelectedValue()
        AbsensiKaryawan.karyawan.GSNama = TxtNama.Text
        AbsensiKaryawan.karyawan.GSNik = TxtNik.Text
        AbsensiKaryawan.karyawan.GSAlamat = TxtAlamat.Text

        AbsensiKaryawan.karyawan.UpdateDataKoleksiByIDDatabase(Karyawan.selectedTableKaryawan,  , AbsensiKaryawan.karyawan.GSNik, AbsensiKaryawan.karyawan.GSNama, AbsensiKaryawan.karyawan.GSJabatan)

    End Sub
End Class