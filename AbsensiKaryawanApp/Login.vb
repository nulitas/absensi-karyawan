Public Class Login

    Public Shared AbsensiKaryawan = New AbsensiKaryawan
    Public Shared Users = New Users

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtPassword.UseSystemPasswordChar = True


        'AbsensiKaryawan = New AbsensiKaryawan
        Users = New Users
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSusername = data_user(1)
            Me.Hide()
            AdminDashboard.Show()
        Else
            MessageBox.Show("Error!")
        End If
    End Sub

    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        Me.Hide()
        Register.Show()

    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'AbsensiKaryawan.Show()
    End Sub
End Class