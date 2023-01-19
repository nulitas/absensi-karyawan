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



    Public Function GetGajiKaryawan(ID As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jabatan.gaji_perhari FROM karyawan INNER JOIN jabatan ON jabatan.id_jabatan = karyawan.id_jabatan WHERE karyawan.id_jabatan = " & ID & ";"
        sqlRead = sqlCommand.ExecuteReader
        sqlRead.Read()

        sqlRead.Close()
        dbConn.Close()


    End Function


    Public Function AddDataPenggajian(data_id_karyawan As String, data_bulan_ke As Integer, data_total_gaji As Double)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO penggajian (id_karyawan, bulan_ke, total_gaji) VALUE('" _
                        & data_id_karyawan & "', '" _
                        & data_bulan_ke & "', '" _
                        & data_total_gaji & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function



    Public Function GetDataPenggajian() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penggajian AS 'No',
                                  id_karyawan AS 'ID',
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

    Public Function getDayCount(Month As Integer) As Integer
        Dim result As Integer = 0
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT count(*) FROM absensi WHERE MONTH(tanggal) = '" & Month & "';"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Read()
            result = sqlRead.GetString(0)

            dbConn.Close()
            sqlRead.Close()

            Return result
        Catch ex As Exception
            dbConn.Close()
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetLateDay(Month As Integer) As Integer
        Dim result As Integer = 0
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT count(*) FROM absensi WHERE MONTH(tanggal) = '" & Month & "' 
                        AND waktu_absen_masuk > '09:00:00';"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            sqlRead.Read()
            result = sqlRead.GetString(0)

            dbConn.Close()
            sqlRead.Close()

            Return result
        Catch ex As Exception
            dbConn.Close()
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
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

    Public Function getPenggajianByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_penggajian, id_karyawan,
                                  bulan_ke,
                                  total_gaji
                                  FROM penggajian WHERE id_penggajian =" & ID & ";"
        sqlRead = sqlCommand.ExecuteReader
        sqlRead.Read()
        If sqlRead.HasRows Then
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End If
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataPenggajianByID(total_gaji As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn


            sqlQuery = "UPDATE penggajian
                        SET total_gaji=" & total_gaji &
                        "WHERE id_penggajian= " & id_penggajian & ";"

            Debug.Print(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Read()

            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


End Class
