Public Class HitungPenggajian

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetKaryawanList()
    End Sub

    Public Sub GetKaryawanList()
        CBIdPegawai.DataSource = Penggajian.penggajian.GetListKaryawan()
        CBBulan.DataSource = Penggajian.penggajian.GetMonthDate()
    End Sub


End Class