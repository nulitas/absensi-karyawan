<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLogin = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(465, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 175)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Location = New System.Drawing.Point(7, 9)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(217, 20)
        Me.TxtUsername.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Location = New System.Drawing.Point(6, 8)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(217, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRegister.Location = New System.Drawing.Point(141, 331)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(264, 46)
        Me.BtnRegister.TabIndex = 3
        Me.BtnRegister.Text = "SIGN UP"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(8, 9)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(217, 20)
        Me.TxtConfirmPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Konfirmasi Password"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahGambar.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambahGambar.Location = New System.Drawing.Point(465, 302)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(195, 39)
        Me.BtnTambahGambar.TabIndex = 8
        Me.BtnTambahGambar.Text = "Upload"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LinkLogin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnTambahGambar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnRegister)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(12, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 467)
        Me.Panel1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sudah memiliki akun?"
        '
        'LinkLogin
        '
        Me.LinkLogin.AutoSize = True
        Me.LinkLogin.Location = New System.Drawing.Point(315, 385)
        Me.LinkLogin.Name = "LinkLogin"
        Me.LinkLogin.Size = New System.Drawing.Size(54, 20)
        Me.LinkLogin.TabIndex = 11
        Me.LinkLogin.TabStop = True
        Me.LinkLogin.Text = "Sign In"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtUsername)
        Me.Panel2.Location = New System.Drawing.Point(141, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 39)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtPassword)
        Me.Panel3.Location = New System.Drawing.Point(141, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 39)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtConfirmPassword)
        Me.Panel4.Location = New System.Drawing.Point(141, 280)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(264, 39)
        Me.Panel4.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(335, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sign Up"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(272, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Daftarkan diri anda sekarang juga!"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 576)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLogin As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
