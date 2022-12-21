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
        Me.BtnFormAbsensi = New System.Windows.Forms.Button()
        Me.BtnFormPenggajian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFormKaryawan
        '
        Me.BtnFormKaryawan.Location = New System.Drawing.Point(256, 126)
        Me.BtnFormKaryawan.Name = "BtnFormKaryawan"
        Me.BtnFormKaryawan.Size = New System.Drawing.Size(266, 29)
        Me.BtnFormKaryawan.TabIndex = 0
        Me.BtnFormKaryawan.Text = "Form Karyawan"
        Me.BtnFormKaryawan.UseVisualStyleBackColor = True
        '
        'BtnFormJabatan
        '
        Me.BtnFormJabatan.Location = New System.Drawing.Point(256, 180)
        Me.BtnFormJabatan.Name = "BtnFormJabatan"
        Me.BtnFormJabatan.Size = New System.Drawing.Size(266, 29)
        Me.BtnFormJabatan.TabIndex = 1
        Me.BtnFormJabatan.Text = "Form Jabatan"
        Me.BtnFormJabatan.UseVisualStyleBackColor = True
        '
        'BtnFormAbsensi
        '
        Me.BtnFormAbsensi.Location = New System.Drawing.Point(256, 235)
        Me.BtnFormAbsensi.Name = "BtnFormAbsensi"
        Me.BtnFormAbsensi.Size = New System.Drawing.Size(266, 29)
        Me.BtnFormAbsensi.TabIndex = 2
        Me.BtnFormAbsensi.Text = "Form Absensi"
        Me.BtnFormAbsensi.UseVisualStyleBackColor = True
        '
        'BtnFormPenggajian
        '
        Me.BtnFormPenggajian.Location = New System.Drawing.Point(256, 290)
        Me.BtnFormPenggajian.Name = "BtnFormPenggajian"
        Me.BtnFormPenggajian.Size = New System.Drawing.Size(266, 29)
        Me.BtnFormPenggajian.TabIndex = 3
        Me.BtnFormPenggajian.Text = "Form Penggajian"
        Me.BtnFormPenggajian.UseVisualStyleBackColor = True
        '
        'AbsensiKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnFormPenggajian)
        Me.Controls.Add(Me.BtnFormAbsensi)
        Me.Controls.Add(Me.BtnFormJabatan)
        Me.Controls.Add(Me.BtnFormKaryawan)
        Me.Name = "AbsensiKaryawan"
        Me.Text = "AbsensiKaryawan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFormKaryawan As Button
    Friend WithEvents BtnFormJabatan As Button
    Friend WithEvents BtnFormAbsensi As Button
    Friend WithEvents BtnFormPenggajian As Button
End Class
