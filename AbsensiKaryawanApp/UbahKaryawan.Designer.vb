<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UbahKaryawan
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
        Me.BtnUploadFoto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblJabatan = New System.Windows.Forms.Label()
        Me.CBJabatan = New System.Windows.Forms.ComboBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblNik = New System.Windows.Forms.Label()
        Me.BtnUbahKaryawan = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.TxtJabatan = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUploadFoto
        '
        Me.BtnUploadFoto.Location = New System.Drawing.Point(70, 281)
        Me.BtnUploadFoto.Name = "BtnUploadFoto"
        Me.BtnUploadFoto.Size = New System.Drawing.Size(148, 29)
        Me.BtnUploadFoto.TabIndex = 21
        Me.BtnUploadFoto.Text = "Upload Foto"
        Me.BtnUploadFoto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(70, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 203)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'LblJabatan
        '
        Me.LblJabatan.AutoSize = True
        Me.LblJabatan.Location = New System.Drawing.Point(508, 221)
        Me.LblJabatan.Name = "LblJabatan"
        Me.LblJabatan.Size = New System.Drawing.Size(60, 20)
        Me.LblJabatan.TabIndex = 19
        Me.LblJabatan.Text = "Jabatan"
        '
        'CBJabatan
        '
        Me.CBJabatan.FormattingEnabled = True
        Me.CBJabatan.Location = New System.Drawing.Point(508, 252)
        Me.CBJabatan.Name = "CBJabatan"
        Me.CBJabatan.Size = New System.Drawing.Size(125, 28)
        Me.CBJabatan.TabIndex = 18
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(508, 160)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(125, 27)
        Me.TxtAlamat.TabIndex = 17
        '
        'LblAlamat
        '
        Me.LblAlamat.AutoSize = True
        Me.LblAlamat.Location = New System.Drawing.Point(508, 127)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(57, 20)
        Me.LblAlamat.TabIndex = 16
        Me.LblAlamat.Text = "Alamat"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(263, 221)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(49, 20)
        Me.LblNama.TabIndex = 15
        Me.LblNama.Text = "Nama"
        '
        'LblNik
        '
        Me.LblNik.AutoSize = True
        Me.LblNik.Location = New System.Drawing.Point(263, 127)
        Me.LblNik.Name = "LblNik"
        Me.LblNik.Size = New System.Drawing.Size(33, 20)
        Me.LblNik.TabIndex = 14
        Me.LblNik.Text = "NIK"
        '
        'BtnUbahKaryawan
        '
        Me.BtnUbahKaryawan.Location = New System.Drawing.Point(247, 335)
        Me.BtnUbahKaryawan.Name = "BtnUbahKaryawan"
        Me.BtnUbahKaryawan.Size = New System.Drawing.Size(165, 29)
        Me.BtnUbahKaryawan.TabIndex = 13
        Me.BtnUbahKaryawan.Text = "Ubah Karyawan"
        Me.BtnUbahKaryawan.UseVisualStyleBackColor = True
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(263, 253)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(165, 27)
        Me.TxtNama.TabIndex = 12
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(263, 160)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(165, 27)
        Me.TxtNik.TabIndex = 11
        '
        'TxtJabatan
        '
        Me.TxtJabatan.Location = New System.Drawing.Point(508, 305)
        Me.TxtJabatan.Name = "TxtJabatan"
        Me.TxtJabatan.Size = New System.Drawing.Size(125, 27)
        Me.TxtJabatan.TabIndex = 22
        '
        'UbahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtJabatan)
        Me.Controls.Add(Me.BtnUploadFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblJabatan)
        Me.Controls.Add(Me.CBJabatan)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblNik)
        Me.Controls.Add(Me.BtnUbahKaryawan)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNik)
        Me.Name = "UbahKaryawan"
        Me.Text = "UbahKaryawan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUploadFoto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblJabatan As Label
    Friend WithEvents CBJabatan As ComboBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents LblNik As Label
    Friend WithEvents BtnUbahKaryawan As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNik As TextBox
    Friend WithEvents TxtJabatan As TextBox
End Class
