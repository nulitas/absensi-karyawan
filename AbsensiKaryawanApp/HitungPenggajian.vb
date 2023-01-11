Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class HitungPenggajian
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
        GetKaryawanList()

    End Sub

    Public Sub GetKaryawanList()

        CBIdPegawai.DataSource = Penggajian.penggajian.GetListKaryawan()
        CBBulan.DataSource = Penggajian.penggajian.GetMonthDate()
        CBGaji.DataSource = Penggajian.penggajian.GetGajiKaryawan()
    End Sub

    Private Sub BtnHitungGaji_Click(sender As Object, e As EventArgs) Handles BtnHitungGaji.Click

        Dim potongan = 1000 * (2 / 100)
        Dim total = 1000 - potongan
        TxtTotalGaji.Text = total

        Penggajian.penggajian.GSTotalGaji = TxtTotalGaji.Text
    End Sub
    Private Sub HitungPenggajian_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"


        Try




        Catch ex As Exception

        Finally
            dbConn.Dispose()
        End Try


    End Sub

    Private Sub HitungPenggajian_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class