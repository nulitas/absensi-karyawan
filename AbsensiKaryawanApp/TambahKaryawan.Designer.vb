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
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnUploadFoto = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBJabatan = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNik
        '
        Me.TxtNik.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtNik.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNik.Location = New System.Drawing.Point(250, 173)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(182, 20)
        Me.TxtNik.TabIndex = 0
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNama.Location = New System.Drawing.Point(8, 7)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(165, 20)
        Me.TxtNama.TabIndex = 1
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahKaryawan.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKaryawan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(470, 315)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(194, 40)
        Me.BtnTambahKaryawan.TabIndex = 2
        Me.BtnTambahKaryawan.Text = "Tambah Karyawan"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAlamat.Location = New System.Drawing.Point(7, 7)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(178, 20)
        Me.TxtAlamat.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(42, 106)
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
        Me.BtnUploadFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUploadFoto.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUploadFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUploadFoto.Location = New System.Drawing.Point(42, 315)
        Me.BtnUploadFoto.Name = "BtnUploadFoto"
        Me.BtnUploadFoto.Size = New System.Drawing.Size(148, 43)
        Me.BtnUploadFoto.TabIndex = 10
        Me.BtnUploadFoto.Text = "Upload"
        Me.BtnUploadFoto.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CBJabatan)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnUploadFoto)
        Me.Panel1.Controls.Add(Me.BtnTambahKaryawan)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 426)
        Me.Panel1.TabIndex = 11
        '
        'CBJabatan
        '
        Me.CBJabatan.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CBJabatan.FormattingEnabled = True
        Me.CBJabatan.ItemHeight = 20
        Me.CBJabatan.Location = New System.Drawing.Point(470, 158)
        Me.CBJabatan.Name = "CBJabatan"
        Me.CBJabatan.Size = New System.Drawing.Size(194, 28)
        Me.CBJabatan.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxtAlamat)
        Me.Panel5.Location = New System.Drawing.Point(470, 231)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(194, 36)
        Me.Panel5.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Jabatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NIK"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(232, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 36)
        Me.Panel2.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtNama)
        Me.Panel3.Location = New System.Drawing.Point(232, 231)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 36)
        Me.Panel3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(-1, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(764, 56)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "# Tambah Karyawan"
        '
        'TambahKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtNik)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TambahKaryawan"
        Me.Text = "TambahKaryawan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNik As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnUploadFoto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CBJabatan As ComboBox
    Friend WithEvents Label4 As Label
End Class
