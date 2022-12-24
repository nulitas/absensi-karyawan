<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbsensiKeluar
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
        Me.BtnAbsen = New System.Windows.Forms.Button()
        Me.CBNamaPegawai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtIdPegawai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnAbsen)
        Me.Panel1.Controls.Add(Me.CBNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(19, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 237)
        Me.Panel1.TabIndex = 7
        '
        'BtnAbsen
        '
        Me.BtnAbsen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAbsen.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAbsen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAbsen.Location = New System.Drawing.Point(70, 181)
        Me.BtnAbsen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAbsen.Name = "BtnAbsen"
        Me.BtnAbsen.Size = New System.Drawing.Size(215, 34)
        Me.BtnAbsen.TabIndex = 7
        Me.BtnAbsen.Text = "Absen"
        Me.BtnAbsen.UseVisualStyleBackColor = False
        '
        'CBNamaPegawai
        '
        Me.CBNamaPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBNamaPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaPegawai.FormattingEnabled = True
        Me.CBNamaPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBNamaPegawai.Location = New System.Drawing.Point(70, 113)
        Me.CBNamaPegawai.Name = "CBNamaPegawai"
        Me.CBNamaPegawai.Size = New System.Drawing.Size(215, 23)
        Me.CBNamaPegawai.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Pegawai"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtIdPegawai)
        Me.Panel2.Location = New System.Drawing.Point(70, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 26)
        Me.Panel2.TabIndex = 4
        '
        'TxtIdPegawai
        '
        Me.TxtIdPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtIdPegawai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdPegawai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtIdPegawai.Location = New System.Drawing.Point(7, 3)
        Me.TxtIdPegawai.Name = "TxtIdPegawai"
        Me.TxtIdPegawai.Size = New System.Drawing.Size(201, 16)
        Me.TxtIdPegawai.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Pegawai"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# Absensi Keluar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbsensiKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 333)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AbsensiKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AbsensiKeluar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAbsen As Button
    Friend WithEvents CBNamaPegawai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtIdPegawai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
