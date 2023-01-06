Imports MySql.Data.MySqlClient

Public Class PenggajianClass


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String


    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Private id_penggajian As Integer
    Private id_karyawan As Integer
    Private bulan_ke As Integer
    Private total_gaji As Integer

    Public Property GSIdPenggajian As Integer
        Get
            Return id_penggajian
        End Get
        Set(value As Integer)
            id_penggajian = value
        End Set
    End Property

    Public Property GSIdKaryawan As Integer
        Get
            Return id_karyawan
        End Get
        Set(value As Integer)
            id_karyawan = value
        End Set
    End Property

    Public Property GSBulan As Integer
        Get
            Return bulan_ke
        End Get
        Set(value As Integer)
            bulan_ke = value
        End Set
    End Property

    Public Property GSTotalGaji As Integer
        Get
            Return total_gaji
        End Get
        Set(value As Integer)
            total_gaji = value
        End Set
    End Property

    Public Function GetListKaryawan() As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan FROM karyawan"
        sqlRead = sqlCommand.ExecuteReader
        sqlRead.Read()
        If sqlRead.HasRows Then
            result.Add(sqlRead.GetString(0))
        End If
        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function




    Public Function GetDataPenggajian() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan AS 'ID',
                                  bulan_ke as 'Bulan Ke',
                                  total_gaji as 'Total Gaji'
                   
                                  FROM penggajian"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetMonthDate() As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        Try

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT tanggal FROM absensi"
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Read()
            If sqlRead.HasRows Then
                Dim tanggal As Date = sqlRead.GetString(0)
                result.Add(tanggal.Month)
            End If
            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub deleteDataPenggajian(ID As Integer)
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM penggajian " &
                "WHERE id_penggajian='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub

    Public Function getPenggajianByID(GSID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_karyawan,
                                  bulan_ke,
                                  total_gaji
                   
                                  FROM penggajian WHERE id_penggajian =" + GSID
        sqlRead = sqlCommand.ExecuteReader
        sqlRead.Read()
        If sqlRead.HasRows Then
            result.Add(sqlRead.GetString(0))
            result.Add(sqlRead.GetString(1))
            result.Add(sqlRead.GetString(2))
        End If
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

End Class
