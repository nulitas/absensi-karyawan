Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Database



    Public Class Database
        Private conn As New MySqlConnection
        Private cmd As New MySqlCommand
        Private queryString As String
        Private dataReader As MySqlDataReader

        Public Sub New()
            conn.ConnectionString = "server=localhost; 
                                 user id=root;
                                 password=;
                                 database=absensi_karyawan"
        End Sub

        Private Sub Open()
            cmd.Connection = conn
            conn.Open()
        End Sub

        Public Sub Query(query As String)
            Open()
            queryString = query
            cmd.CommandText = queryString
        End Sub

        Public Sub Bind(name As String, type As String, value As String)
            If type = "number" Then
                value = Integer.Parse(value)
            End If

            cmd.Parameters.AddWithValue("@" & name, value)
        End Sub

        Private Sub PrepareStmt()
            If queryString.Contains("@") Then
                cmd.Prepare()
            End If
        End Sub

        Public Function Execute() As Integer
            Dim affectedRows As Integer

            PrepareStmt()

            affectedRows = cmd.ExecuteNonQuery()

            cmd.Parameters.Clear()
            conn.Close()

            Return affectedRows
        End Function

        Public Function Fetch() As DataTable
            Dim dataTable As New DataTable

            PrepareStmt()

            dataReader = cmd.ExecuteReader()
            dataTable.Load(dataReader)

            dataReader.Close()
            cmd.Parameters.Clear()

            conn.Close()
            Return dataTable

        End Function

    End Class
End Class
