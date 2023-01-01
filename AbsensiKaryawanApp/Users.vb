Imports System.Buffers
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class Users

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "absensi_karyawan"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public usersList As New ArrayList()



    Public Property GSusername() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSpassword() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property


    Public Sub AddData(dataUser As String, dataPass As String)
        usersList.Add({dataUser, EncryptData(dataPass)})
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String
        'Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        'Create the stream.
        Dim ms As New System.IO.MemoryStream
        'Create the encoder To write To the stream.
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream To write the Byte array To the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string.

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String


        For Each user In usersList
            If String.Compare(username, user(0)) = 0 And String.Compare(EncryptData(plainPassword), user(1)) = 0 Then
                Return True
            End If
        Next
        Return False

    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)

        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function


    Public Function AddUsersDatabase(username_reg As String, password_reg As String, email As String)
        Try

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users(username, password, email) VALUE('" _
                & username_reg & "', '" _
                & EncryptMD5(password_reg) & "', '" _
                & email & "')"



            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database + ";" + "Convert Zero Datetime=True"
            dbConn.Open()

            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add((sqlRead.GetString(0).ToString))
                    result.Add((sqlRead.GetString(1).ToString))
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function



End Class
