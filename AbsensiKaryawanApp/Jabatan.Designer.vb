<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jabatan
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
        Me.DataGridViewJabatan = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnHapusJabatan = New System.Windows.Forms.Button()
        Me.BtnEditJabatan = New System.Windows.Forms.Button()
        Me.BtnTambahJabatan = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewJabatan
        '
        Me.DataGridViewJabatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJabatan.Location = New System.Drawing.Point(30, 116)
        Me.DataGridViewJabatan.Name = "DataGridViewJabatan"
        Me.DataGridViewJabatan.RowHeadersWidth = 51
        Me.DataGridViewJabatan.RowTemplate.Height = 29
        Me.DataGridViewJabatan.Size = New System.Drawing.Size(406, 369)
        Me.DataGridViewJabatan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(188, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Daftar Jabatan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnHapusJabatan)
        Me.GroupBox1.Controls.Add(Me.BtnEditJabatan)
        Me.GroupBox1.Controls.Add(Me.BtnTambahJabatan)
        Me.GroupBox1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 369)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'BtnHapusJabatan
        '
        Me.BtnHapusJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusJabatan.Location = New System.Drawing.Point(23, 222)
        Me.BtnHapusJabatan.Name = "BtnHapusJabatan"
        Me.BtnHapusJabatan.Size = New System.Drawing.Size(158, 56)
        Me.BtnHapusJabatan.TabIndex = 4
        Me.BtnHapusJabatan.Text = "Hapus"
        Me.BtnHapusJabatan.UseVisualStyleBackColor = False
        '
        'BtnEditJabatan
        '
        Me.BtnEditJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditJabatan.Location = New System.Drawing.Point(23, 151)
        Me.BtnEditJabatan.Name = "BtnEditJabatan"
        Me.BtnEditJabatan.Size = New System.Drawing.Size(158, 54)
        Me.BtnEditJabatan.TabIndex = 3
        Me.BtnEditJabatan.Text = "Edit"
        Me.BtnEditJabatan.UseVisualStyleBackColor = False
        '
        'BtnTambahJabatan
        '
        Me.BtnTambahJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambahJabatan.Location = New System.Drawing.Point(23, 78)
        Me.BtnTambahJabatan.Name = "BtnTambahJabatan"
        Me.BtnTambahJabatan.Size = New System.Drawing.Size(158, 54)
        Me.BtnTambahJabatan.TabIndex = 0
        Me.BtnTambahJabatan.Text = "Tambah"
        Me.BtnTambahJabatan.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBack.Location = New System.Drawing.Point(30, 16)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(125, 48)
        Me.BtnBack.TabIndex = 5
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridViewJabatan)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 528)
        Me.Panel1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(165, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Berisi daftar jabatan yang terdata di sistem"
        '
        'Jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Jabatan"
        Me.Text = "Jabatan"
        CType(Me.DataGridViewJabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewJabatan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnHapusJabatan As Button
    Friend WithEvents BtnEditJabatan As Button
    Friend WithEvents BtnTambahJabatan As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
