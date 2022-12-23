<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbsensiKaryawan
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
        Me.BtnFormKaryawan = New System.Windows.Forms.Button()
        Me.BtnFormJabatan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFormAbsensi = New System.Windows.Forms.Button()
        Me.BtnFormPenggajian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFormKaryawan
        '
        Me.BtnFormKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFormKaryawan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnFormKaryawan.Location = New System.Drawing.Point(20, 123)
        Me.BtnFormKaryawan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormKaryawan.Name = "BtnFormKaryawan"
        Me.BtnFormKaryawan.Size = New System.Drawing.Size(342, 116)
        Me.BtnFormKaryawan.TabIndex = 0
        Me.BtnFormKaryawan.Text = "Data Karyawan"
        Me.BtnFormKaryawan.UseVisualStyleBackColor = False
        '
        'BtnFormJabatan
        '
        Me.BtnFormJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormJabatan.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormJabatan.ForeColor = System.Drawing.Color.Black
        Me.BtnFormJabatan.Location = New System.Drawing.Point(388, 123)
        Me.BtnFormJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormJabatan.Name = "BtnFormJabatan"
        Me.BtnFormJabatan.Size = New System.Drawing.Size(378, 65)
        Me.BtnFormJabatan.TabIndex = 1
        Me.BtnFormJabatan.Text = "Lihat Detail Jabatan"
        Me.BtnFormJabatan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "# Menu"
        '
        'BtnFormAbsensi
        '
        Me.BtnFormAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormAbsensi.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormAbsensi.ForeColor = System.Drawing.Color.Black
        Me.BtnFormAbsensi.Location = New System.Drawing.Point(20, 243)
        Me.BtnFormAbsensi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormAbsensi.Name = "BtnFormAbsensi"
        Me.BtnFormAbsensi.Size = New System.Drawing.Size(342, 54)
        Me.BtnFormAbsensi.TabIndex = 5
        Me.BtnFormAbsensi.Text = "Absensi"
        Me.BtnFormAbsensi.UseVisualStyleBackColor = True
        '
        'BtnFormPenggajian
        '
        Me.BtnFormPenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormPenggajian.Font = New System.Drawing.Font("Myanmar Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormPenggajian.ForeColor = System.Drawing.Color.Black
        Me.BtnFormPenggajian.Location = New System.Drawing.Point(388, 243)
        Me.BtnFormPenggajian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFormPenggajian.Name = "BtnFormPenggajian"
        Me.BtnFormPenggajian.Size = New System.Drawing.Size(378, 54)
        Me.BtnFormPenggajian.TabIndex = 6
        Me.BtnFormPenggajian.Text = "Gaji"
        Me.BtnFormPenggajian.UseVisualStyleBackColor = True
        '
        'AbsensiKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 428)
        Me.Controls.Add(Me.BtnFormPenggajian)
        Me.Controls.Add(Me.BtnFormAbsensi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFormJabatan)
        Me.Controls.Add(Me.BtnFormKaryawan)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AbsensiKaryawan"
        Me.Text = "AbsensiKaryawan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFormKaryawan As Button
    Friend WithEvents BtnFormJabatan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFormAbsensi As Button
    Friend WithEvents BtnFormPenggajian As Button
End Class
