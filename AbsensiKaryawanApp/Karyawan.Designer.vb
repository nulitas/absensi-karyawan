<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Me.BtnHapusKaryawan = New System.Windows.Forms.Button()
        Me.DataGridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnTambahKaryawan = New System.Windows.Forms.Button()
        Me.BtnEditKaryawan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnHapusKaryawan
        '
        Me.BtnHapusKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusKaryawan.Location = New System.Drawing.Point(24, 247)
        Me.BtnHapusKaryawan.Name = "BtnHapusKaryawan"
        Me.BtnHapusKaryawan.Size = New System.Drawing.Size(169, 50)
        Me.BtnHapusKaryawan.TabIndex = 1
        Me.BtnHapusKaryawan.Text = "Hapus"
        Me.BtnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'DataGridViewKaryawan
        '
        Me.DataGridViewKaryawan.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKaryawan.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewKaryawan.Location = New System.Drawing.Point(14, 116)
        Me.DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        Me.DataGridViewKaryawan.RowHeadersWidth = 51
        Me.DataGridViewKaryawan.RowTemplate.Height = 29
        Me.DataGridViewKaryawan.Size = New System.Drawing.Size(606, 354)
        Me.DataGridViewKaryawan.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTambahKaryawan)
        Me.GroupBox1.Controls.Add(Me.BtnEditKaryawan)
        Me.GroupBox1.Controls.Add(Me.BtnHapusKaryawan)
        Me.GroupBox1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(644, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 354)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(24, 108)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(169, 50)
        Me.BtnTambahKaryawan.TabIndex = 3
        Me.BtnTambahKaryawan.Text = "Tambah"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'BtnEditKaryawan
        '
        Me.BtnEditKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditKaryawan.Location = New System.Drawing.Point(24, 179)
        Me.BtnEditKaryawan.Name = "BtnEditKaryawan"
        Me.BtnEditKaryawan.Size = New System.Drawing.Size(169, 50)
        Me.BtnEditKaryawan.TabIndex = 2
        Me.BtnEditKaryawan.Text = "Edit"
        Me.BtnEditKaryawan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(621, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Berisi daftar karyawan yang ada"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridViewKaryawan)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 488)
        Me.Panel1.TabIndex = 19
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBack.Location = New System.Drawing.Point(3, 59)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 46)
        Me.BtnBack.TabIndex = 20
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(929, 56)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "# Daftar Karyawan"
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Karyawan"
        Me.Text = "Karyawan"
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnHapusKaryawan As Button
    Friend WithEvents DataGridViewKaryawan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEditKaryawan As Button
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBack As Button
End Class
