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
        Me.SuspendLayout()
        '
        'BtnFormPenggajian
        '
        Me.BtnFormPenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormPenggajian.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormPenggajian.ForeColor = System.Drawing.Color.Black
        Me.BtnFormPenggajian.Location = New System.Drawing.Point(448, 294)
        Me.BtnFormPenggajian.Name = "BtnFormPenggajian"
        Me.BtnFormPenggajian.Size = New System.Drawing.Size(432, 72)
        Me.BtnFormPenggajian.TabIndex = 10
        Me.BtnFormPenggajian.Text = "Gaji"
        Me.BtnFormPenggajian.UseVisualStyleBackColor = True
        '
        'BtnFormJabatan
        '
        Me.BtnFormJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormJabatan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormJabatan.ForeColor = System.Drawing.Color.Black
        Me.BtnFormJabatan.Location = New System.Drawing.Point(448, 183)
        Me.BtnFormJabatan.Name = "BtnFormJabatan"
        Me.BtnFormJabatan.Size = New System.Drawing.Size(432, 87)
        Me.BtnFormJabatan.TabIndex = 8
        Me.BtnFormJabatan.Text = "Lihat Detail Jabatan"
        Me.BtnFormJabatan.UseVisualStyleBackColor = True
        '
        'BtnFormKaryawan
        '
        Me.BtnFormKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFormKaryawan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnFormKaryawan.Location = New System.Drawing.Point(30, 183)
        Me.BtnFormKaryawan.Name = "BtnFormKaryawan"
        Me.BtnFormKaryawan.Size = New System.Drawing.Size(391, 183)
        Me.BtnFormKaryawan.TabIndex = 7
        Me.BtnFormKaryawan.Text = "Data Karyawan"
        Me.BtnFormKaryawan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(850, 93)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "# Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogout.ForeColor = System.Drawing.Color.Black
        Me.BtnLogout.Location = New System.Drawing.Point(748, 57)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(112, 40)
        Me.BtnLogout.TabIndex = 12
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 522)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFormPenggajian)
        Me.Controls.Add(Me.BtnFormJabatan)
        Me.Controls.Add(Me.BtnFormKaryawan)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFormPenggajian As Button
    Friend WithEvents BtnFormJabatan As Button
    Friend WithEvents BtnFormKaryawan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogout As Button
End Class
