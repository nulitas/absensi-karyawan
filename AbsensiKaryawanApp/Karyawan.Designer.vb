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
        Me.BtnEditKaryawan = New System.Windows.Forms.Button()
        Me.BtnTambahKaryawan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnHapusKaryawan
        '
        Me.BtnHapusKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusKaryawan.Location = New System.Drawing.Point(24, 207)
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
        Me.DataGridViewKaryawan.Location = New System.Drawing.Point(26, 102)
        Me.DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        Me.DataGridViewKaryawan.RowHeadersWidth = 51
        Me.DataGridViewKaryawan.RowTemplate.Height = 29
        Me.DataGridViewKaryawan.Size = New System.Drawing.Size(541, 370)
        Me.DataGridViewKaryawan.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTambahKaryawan)
        Me.GroupBox1.Controls.Add(Me.BtnEditKaryawan)
        Me.GroupBox1.Controls.Add(Me.BtnHapusKaryawan)
        Me.GroupBox1.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(636, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 301)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'BtnEditKaryawan
        '
        Me.BtnEditKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditKaryawan.Location = New System.Drawing.Point(24, 132)
        Me.BtnEditKaryawan.Name = "BtnEditKaryawan"
        Me.BtnEditKaryawan.Size = New System.Drawing.Size(169, 50)
        Me.BtnEditKaryawan.TabIndex = 2
        Me.BtnEditKaryawan.Text = "Edit"
        Me.BtnEditKaryawan.UseVisualStyleBackColor = False
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKaryawan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(24, 66)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(169, 50)
        Me.BtnTambahKaryawan.TabIndex = 3
        Me.BtnTambahKaryawan.Text = "Tambah"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(886, 56)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "# Karyawan"
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 575)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewKaryawan)
        Me.Name = "Karyawan"
        Me.Text = "Karyawan"
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnHapusKaryawan As Button
    Friend WithEvents DataGridViewKaryawan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEditKaryawan As Button
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents Label1 As Label
End Class
