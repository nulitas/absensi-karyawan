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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBJabatan = New System.Windows.Forms.ComboBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUbahKaryawan = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jabatan"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NIK"
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
        'UbahKaryawan
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
    Friend WithEvents Label4 As Label
    Friend WithEvents CBJabatan As ComboBox
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUbahKaryawan As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNik As TextBox
End Class
