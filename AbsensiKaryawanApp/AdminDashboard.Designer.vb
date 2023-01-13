<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Me.BtnFormPenggajian = New System.Windows.Forms.Button()
        Me.BtnFormJabatan = New System.Windows.Forms.Button()
        Me.BtnFormKaryawan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnDataAbsensi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFormPenggajian
        '
        Me.BtnFormPenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormPenggajian.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormPenggajian.ForeColor = System.Drawing.Color.Black
        Me.BtnFormPenggajian.Location = New System.Drawing.Point(392, 220)
        Me.BtnFormPenggajian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormPenggajian.Name = "BtnFormPenggajian"
        Me.BtnFormPenggajian.Size = New System.Drawing.Size(378, 54)
        Me.BtnFormPenggajian.TabIndex = 10
        Me.BtnFormPenggajian.Text = "Gaji"
        Me.BtnFormPenggajian.UseVisualStyleBackColor = True
        '
        'BtnFormJabatan
        '
        Me.BtnFormJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormJabatan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormJabatan.ForeColor = System.Drawing.Color.Black
        Me.BtnFormJabatan.Location = New System.Drawing.Point(392, 137)
        Me.BtnFormJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormJabatan.Name = "BtnFormJabatan"
        Me.BtnFormJabatan.Size = New System.Drawing.Size(378, 65)
        Me.BtnFormJabatan.TabIndex = 8
        Me.BtnFormJabatan.Text = "Lihat Detail Jabatan"
        Me.BtnFormJabatan.UseVisualStyleBackColor = True
        '
        'BtnFormKaryawan
        '
        Me.BtnFormKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFormKaryawan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnFormKaryawan.Location = New System.Drawing.Point(26, 137)
        Me.BtnFormKaryawan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormKaryawan.Name = "BtnFormKaryawan"
        Me.BtnFormKaryawan.Size = New System.Drawing.Size(342, 137)
        Me.BtnFormKaryawan.TabIndex = 7
        Me.BtnFormKaryawan.Text = "Data Karyawan"
        Me.BtnFormKaryawan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 70)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "# Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogout.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout.Location = New System.Drawing.Point(654, 43)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(98, 30)
        Me.BtnLogout.TabIndex = 12
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnDataAbsensi
        '
        Me.BtnDataAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataAbsensi.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDataAbsensi.ForeColor = System.Drawing.Color.Black
        Me.BtnDataAbsensi.Location = New System.Drawing.Point(26, 295)
        Me.BtnDataAbsensi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDataAbsensi.Name = "BtnDataAbsensi"
        Me.BtnDataAbsensi.Size = New System.Drawing.Size(342, 54)
        Me.BtnDataAbsensi.TabIndex = 13
        Me.BtnDataAbsensi.Text = "Data Absensi"
        Me.BtnDataAbsensi.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 392)
        Me.Controls.Add(Me.BtnDataAbsensi)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFormPenggajian)
        Me.Controls.Add(Me.BtnFormJabatan)
        Me.Controls.Add(Me.BtnFormKaryawan)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFormPenggajian As Button
    Friend WithEvents BtnFormJabatan As Button
    Friend WithEvents BtnFormKaryawan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnDataAbsensi As Button
End Class
