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
        Me.DataGridViewKaryawan = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnTambahKaryawan = New System.Windows.Forms.Button()
        Me.BtnHapusKaryawan = New System.Windows.Forms.Button()
        Me.BtnEditKaryawan = New System.Windows.Forms.Button()
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewKaryawan
        '
        Me.DataGridViewKaryawan.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKaryawan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridViewKaryawan.Location = New System.Drawing.Point(181, 111)
        Me.DataGridViewKaryawan.Name = "DataGridViewKaryawan"
        Me.DataGridViewKaryawan.RowHeadersWidth = 51
        Me.DataGridViewKaryawan.RowTemplate.Height = 29
        Me.DataGridViewKaryawan.Size = New System.Drawing.Size(587, 371)
        Me.DataGridViewKaryawan.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(134, 43)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnTambahKaryawan
        '
        Me.BtnTambahKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKaryawan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnTambahKaryawan.Location = New System.Drawing.Point(181, 505)
        Me.BtnTambahKaryawan.Name = "BtnTambahKaryawan"
        Me.BtnTambahKaryawan.Size = New System.Drawing.Size(134, 43)
        Me.BtnTambahKaryawan.TabIndex = 5
        Me.BtnTambahKaryawan.Text = "Tambah"
        Me.BtnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'BtnHapusKaryawan
        '
        Me.BtnHapusKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusKaryawan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHapusKaryawan.Location = New System.Drawing.Point(399, 505)
        Me.BtnHapusKaryawan.Name = "BtnHapusKaryawan"
        Me.BtnHapusKaryawan.Size = New System.Drawing.Size(134, 43)
        Me.BtnHapusKaryawan.TabIndex = 6
        Me.BtnHapusKaryawan.Text = "Hapus"
        Me.BtnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'BtnEditKaryawan
        '
        Me.BtnEditKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditKaryawan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditKaryawan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditKaryawan.Location = New System.Drawing.Point(624, 505)
        Me.BtnEditKaryawan.Name = "BtnEditKaryawan"
        Me.BtnEditKaryawan.Size = New System.Drawing.Size(134, 43)
        Me.BtnEditKaryawan.TabIndex = 7
        Me.BtnEditKaryawan.Text = "Edit"
        Me.BtnEditKaryawan.UseVisualStyleBackColor = False
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 611)
        Me.Controls.Add(Me.BtnEditKaryawan)
        Me.Controls.Add(Me.BtnHapusKaryawan)
        Me.Controls.Add(Me.BtnTambahKaryawan)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DataGridViewKaryawan)
        Me.Name = "Karyawan"
        Me.Text = "Karyawan"
        CType(Me.DataGridViewKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewKaryawan As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnTambahKaryawan As Button
    Friend WithEvents BtnHapusKaryawan As Button
    Friend WithEvents BtnEditKaryawan As Button
End Class
