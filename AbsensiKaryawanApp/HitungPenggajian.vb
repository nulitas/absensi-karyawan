Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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

        'CBIdPegawai.DataSource = Penggajian.penggajian.GetListKaryawan()

        CBBulan.DataSource = Penggajian.penggajian.GetMonthDate()
        'CBGaji.DataSource = Penggajian.penggajian.GetGajiKaryawan(9)

        TxtGaji.Text = Penggajian.penggajian.GetGajiKaryawan(9)
    End Sub


    Private Sub HitungPenggajian_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"


        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_karyawan from karyawan"


            da.SelectCommand = sqlCommand

            Dim table1 As New DataTable

            da.Fill(table1)


            CBIdPegawai.DataSource = table1
            CBIdPegawai.DisplayMember = "id_karyawan"
            CBIdPegawai.ValueMember = "id_karyawan"

        Catch ex As Exception

        Finally
            dbConn.Dispose()
        End Try


    End Sub


    'Private Sub BtnGetGaji_Click(sender As Object, e As EventArgs)

    '    dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlCommand.CommandText = " SELECT jabatan.gaji_perhari FROM karyawan INNER JOIN jabatan ON jabatan.id_jabatan = karyawan.id_jabatan WHERE karyawan.id_karyawan =" & CBIdPegawai.SelectedValue & ";"

    '        da.SelectCommand = sqlCommand

    '        Dim table1 As New DataTable

    '        da.Fill(table1)
    '        TxtGaji.Text = table1(0)(0)


    '    Catch ex As Exception

    '    Finally
    '        dbConn.Dispose()
    '    End Try

    'End Sub

    Private Sub CBIdPegawai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBIdPegawai.SelectedIndexChanged
        'dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = " SELECT jabatan.gaji_perhari FROM karyawan INNER JOIN jabatan ON jabatan.id_jabatan = karyawan.id_jabatan WHERE karyawan.id_karyawan =" & CBIdPegawai.SelectedValue & ";"

            da.SelectCommand = sqlCommand

            Dim table1 As New DataTable

            da.Fill(table1)
            TxtGaji.Text = table1(0)(0)



        Catch ex As Exception

        Finally
            dbConn.Dispose()
        End Try
    End Sub



    Private Sub BtnHitungGaji_Click(sender As Object, e As EventArgs) Handles BtnHitungGaji.Click
        'ini kondisi kalo lewat jam 9
        Penggajian.penggajian.GSBulan = CBBulan.SelectedValue

        Dim Day = Penggajian.penggajian.getDayCount(Penggajian.penggajian.GSBulan)
        Dim lateDay = Penggajian.penggajian.GetLateDay(Penggajian.penggajian.GSBulan)

        Dim potongan = TxtGaji.Text * (2 / 100)
        Dim total = Day * TxtGaji.Text
        If lateDay > 0 Then 
            total -= (lateDay * potongan)
        End If
        TxtTotalGaji.Text = total

        Penggajian.penggajian.GSTotalGaji = TxtTotalGaji.Text
        Penggajian.penggajian.GSIdKaryawan = CBIdPegawai.SelectedValue

        Penggajian.penggajian.AddDataPenggajian(Penggajian.penggajian.GSIdKaryawan, Penggajian.penggajian.GSBulan, Penggajian.penggajian.GSTotalGaji)
    End Sub


End Class