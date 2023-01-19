<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahPenggajian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUbahGaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBIdPegawai = New System.Windows.Forms.ComboBox()
        Me.BtnEditGaji = New System.Windows.Forms.Button()
        Me.CBBulan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtUbahGaji)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBIdPegawai)
        Me.Panel1.Controls.Add(Me.BtnEditGaji)
        Me.Panel1.Controls.Add(Me.CBBulan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 478)
        Me.Panel1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 255)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Gaji"
        '
        'TxtUbahGaji
        '
        Me.TxtUbahGaji.Location = New System.Drawing.Point(348, 220)
        Me.TxtUbahGaji.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUbahGaji.Name = "TxtUbahGaji"
        Me.TxtUbahGaji.Size = New System.Drawing.Size(245, 27)
        Me.TxtUbahGaji.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bulan Ke"
        '
        'CBIdPegawai
        '
        Me.CBIdPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBIdPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIdPegawai.FormattingEnabled = True
        Me.CBIdPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBIdPegawai.Location = New System.Drawing.Point(346, 116)
        Me.CBIdPegawai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBIdPegawai.Name = "CBIdPegawai"
        Me.CBIdPegawai.Size = New System.Drawing.Size(245, 28)
        Me.CBIdPegawai.TabIndex = 8
        '
        'BtnEditGaji
        '
        Me.BtnEditGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditGaji.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditGaji.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditGaji.Location = New System.Drawing.Point(347, 268)
        Me.BtnEditGaji.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditGaji.Name = "BtnEditGaji"
        Me.BtnEditGaji.Size = New System.Drawing.Size(246, 46)
        Me.BtnEditGaji.TabIndex = 7
        Me.BtnEditGaji.Text = "Edit"
        Me.BtnEditGaji.UseVisualStyleBackColor = False
        '
        'CBBulan
        '
        Me.CBBulan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBulan.FormattingEnabled = True
        Me.CBBulan.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBBulan.Location = New System.Drawing.Point(346, 172)
        Me.CBBulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBBulan.Name = "CBBulan"
        Me.CBBulan.Size = New System.Drawing.Size(245, 28)
        Me.CBBulan.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Pegawai"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(889, 56)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "# Ubah Penggajian"
        '
        'UbahPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UbahPenggajian"
        Me.Text = "UbahPenggajian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtUbahGaji As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBIdPegawai As ComboBox
    Friend WithEvents BtnEditGaji As Button
    Friend WithEvents CBBulan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
