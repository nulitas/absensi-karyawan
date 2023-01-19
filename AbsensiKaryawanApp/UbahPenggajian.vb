Imports MySql.Data.MySqlClient

Public Class UbahPenggajian

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared da As New MySqlDataAdapter

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'LblNamaPegawai.Text = Penggajian.penggajian.GSNama
        CBIdPegawai.Text = Penggajian.penggajian.GSIdKaryawan
        CBBulan.Text = Penggajian.penggajian.GSBulan
        TxtUbahGaji.Text = Penggajian.penggajian.GSTotalGaji

    End Sub

    Private Sub BtnEditGaji_Click(sender As Object, e As EventArgs) Handles BtnEditGaji.Click
        Penggajian.penggajian.GSIdKaryawan = CBIdPegawai.SelectedValue
        Penggajian.penggajian.GSBulan = CBBulan.SelectedValue
        Penggajian.penggajian.GSTotalGaji = TxtUbahGaji.Text

        Penggajian.penggajian.UpdateDataPenggajianByID(Penggajian.penggajian.GSTotalGaji)
        Me.Close()
    End Sub
End Class