<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKaryawan
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
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnTambahKaryawan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.CBJabatan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnUploadFoto = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(248, 169)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(165, 27)
        Me.TxtNik.TabIndex = 0
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(248, 262)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(165, 27)
        Me.TxtNama.TabIndex = 1
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(232, 344)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(165, 29)
        Me.BtnTambahKaryawan.TabIndex = 2
        Me.BtnTambahKaryawan.Text = "Tambah Karyawan"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(493, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Alamat"
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(493, 169)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(125, 27)
        Me.TxtAlamat.TabIndex = 6
        '
        'CBJabatan
        '
        Me.CBJabatan.FormattingEnabled = True
        Me.CBJabatan.Location = New System.Drawing.Point(493, 261)
        Me.CBJabatan.Name = "CBJabatan"
        Me.CBJabatan.Size = New System.Drawing.Size(125, 28)
        Me.CBJabatan.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(493, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Jabatan"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(55, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 203)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnUploadFoto
        '
        Me.BtnUploadFoto.Location = New System.Drawing.Point(55, 290)
        Me.BtnUploadFoto.Name = "BtnUploadFoto"
        Me.BtnUploadFoto.Size = New System.Drawing.Size(148, 29)
        Me.BtnUploadFoto.TabIndex = 10
        Me.BtnUploadFoto.Text = "Upload Foto"
        Me.BtnUploadFoto.UseVisualStyleBackColor = True
        '
        'TambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnUploadFoto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBJabatan)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTambahKaryawan)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNik)
        Me.Name = "TambahKaryawan"
        Me.Text = "TambahKaryawan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNik As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents CBJabatan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnUploadFoto As Button
End Class
