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
        CType(Me.DataGridViewJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewJabatan
        '
        Me.DataGridViewJabatan.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJabatan.Location = New System.Drawing.Point(52, 63)
        Me.DataGridViewJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewJabatan.Name = "DataGridViewJabatan"
        Me.DataGridViewJabatan.RowHeadersWidth = 51
        Me.DataGridViewJabatan.RowTemplate.Height = 29
        Me.DataGridViewJabatan.Size = New System.Drawing.Size(379, 277)
        Me.DataGridViewJabatan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "# Jabatan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnHapusJabatan)
        Me.GroupBox1.Controls.Add(Me.BtnEditJabatan)
        Me.GroupBox1.Controls.Add(Me.BtnTambahJabatan)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(170, 171)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'BtnHapusJabatan
        '
        Me.BtnHapusJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusJabatan.Location = New System.Drawing.Point(16, 120)
        Me.BtnHapusJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapusJabatan.Name = "BtnHapusJabatan"
        Me.BtnHapusJabatan.Size = New System.Drawing.Size(138, 29)
        Me.BtnHapusJabatan.TabIndex = 4
        Me.BtnHapusJabatan.Text = "Hapus"
        Me.BtnHapusJabatan.UseVisualStyleBackColor = False
        '
        'BtnEditJabatan
        '
        Me.BtnEditJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditJabatan.Location = New System.Drawing.Point(16, 76)
        Me.BtnEditJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditJabatan.Name = "BtnEditJabatan"
        Me.BtnEditJabatan.Size = New System.Drawing.Size(138, 29)
        Me.BtnEditJabatan.TabIndex = 3
        Me.BtnEditJabatan.Text = "Edit"
        Me.BtnEditJabatan.UseVisualStyleBackColor = False
        '
        'BtnTambahJabatan
        '
        Me.BtnTambahJabatan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTambahJabatan.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahJabatan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTambahJabatan.Location = New System.Drawing.Point(16, 35)
        Me.BtnTambahJabatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahJabatan.Name = "BtnTambahJabatan"
        Me.BtnTambahJabatan.Size = New System.Drawing.Size(138, 29)
        Me.BtnTambahJabatan.TabIndex = 0
        Me.BtnTambahJabatan.Text = "Tambah"
        Me.BtnTambahJabatan.UseVisualStyleBackColor = False
        '
        'Jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewJabatan)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Jabatan"
        Me.Text = "Jabatan"
        CType(Me.DataGridViewJabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewJabatan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnHapusJabatan As Button
    Friend WithEvents BtnEditJabatan As Button
    Friend WithEvents BtnTambahJabatan As Button
End Class
