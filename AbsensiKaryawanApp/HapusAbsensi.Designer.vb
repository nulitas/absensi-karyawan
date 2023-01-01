<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusAbsensi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblidAbsensi = New System.Windows.Forms.Label()
        Me.LblKaryawan = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.LblWaktu = New System.Windows.Forms.Label()
        Me.LblJenisAbsen = New System.Windows.Forms.Label()
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "# Hapus Absensi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(84, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Yakin Ingin Menghapus Data Absensi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID Absensi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Waktu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Jenis Absensi"
        '
        'lblidAbsensi
        '
        Me.lblidAbsensi.AutoSize = True
        Me.lblidAbsensi.Location = New System.Drawing.Point(248, 103)
        Me.lblidAbsensi.Name = "lblidAbsensi"
        Me.lblidAbsensi.Size = New System.Drawing.Size(24, 15)
        Me.lblidAbsensi.TabIndex = 8
        Me.lblidAbsensi.Text = "#id"
        '
        'LblKaryawan
        '
        Me.LblKaryawan.AutoSize = True
        Me.LblKaryawan.Location = New System.Drawing.Point(248, 133)
        Me.LblKaryawan.Name = "LblKaryawan"
        Me.LblKaryawan.Size = New System.Drawing.Size(64, 15)
        Me.LblKaryawan.TabIndex = 9
        Me.LblKaryawan.Text = "#karyawan"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(248, 161)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(54, 15)
        Me.LblTanggal.TabIndex = 10
        Me.LblTanggal.Text = "#tanggal"
        '
        'LblWaktu
        '
        Me.LblWaktu.AutoSize = True
        Me.LblWaktu.Location = New System.Drawing.Point(248, 193)
        Me.LblWaktu.Name = "LblWaktu"
        Me.LblWaktu.Size = New System.Drawing.Size(46, 15)
        Me.LblWaktu.TabIndex = 11
        Me.LblWaktu.Text = "#waktu"
        '
        'LblJenisAbsen
        '
        Me.LblJenisAbsen.AutoSize = True
        Me.LblJenisAbsen.Location = New System.Drawing.Point(248, 227)
        Me.LblJenisAbsen.Name = "LblJenisAbsen"
        Me.LblJenisAbsen.Size = New System.Drawing.Size(80, 15)
        Me.LblJenisAbsen.TabIndex = 12
        Me.LblJenisAbsen.Text = "#jenis absensi"
        '
        'BtnHapusAbsensi
        '
        Me.BtnHapusAbsensi.BackColor = System.Drawing.Color.Crimson
        Me.BtnHapusAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusAbsensi.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusAbsensi.ForeColor = System.Drawing.Color.White
        Me.BtnHapusAbsensi.Location = New System.Drawing.Point(276, 277)
        Me.BtnHapusAbsensi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapusAbsensi.Name = "BtnHapusAbsensi"
        Me.BtnHapusAbsensi.Size = New System.Drawing.Size(92, 36)
        Me.BtnHapusAbsensi.TabIndex = 14
        Me.BtnHapusAbsensi.Text = "Hapus"
        Me.BtnHapusAbsensi.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnKembali.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnKembali.Location = New System.Drawing.Point(114, 277)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(100, 36)
        Me.BtnKembali.TabIndex = 15
        Me.BtnKembali.Text = "Batal"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'HapusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 350)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapusAbsensi)
        Me.Controls.Add(Me.LblJenisAbsen)
        Me.Controls.Add(Me.LblWaktu)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LblKaryawan)
        Me.Controls.Add(Me.lblidAbsensi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusAbsensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HapusAbsensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblidAbsensi As Label
    Friend WithEvents LblKaryawan As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LblWaktu As Label
    Friend WithEvents LblJenisAbsen As Label
    Friend WithEvents BtnHapusAbsensi As Button
    Friend WithEvents BtnKembali As Button
End Class
