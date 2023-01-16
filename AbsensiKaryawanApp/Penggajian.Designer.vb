<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penggajian
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewPenggajian = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnHitungGaji = New System.Windows.Forms.Button()
        Me.BtnHapusGaji = New System.Windows.Forms.Button()
        Me.BtnEditGaji = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(889, 56)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "# Penggajian"
        '
        'DataGridViewPenggajian
        '
        Me.DataGridViewPenggajian.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPenggajian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenggajian.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPenggajian.Location = New System.Drawing.Point(22, 140)
        Me.DataGridViewPenggajian.Name = "DataGridViewPenggajian"
        Me.DataGridViewPenggajian.RowHeadersWidth = 51
        Me.DataGridViewPenggajian.RowTemplate.Height = 29
        Me.DataGridViewPenggajian.Size = New System.Drawing.Size(403, 288)
        Me.DataGridViewPenggajian.TabIndex = 8
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBack.Location = New System.Drawing.Point(3, 58)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 46)
        Me.BtnBack.TabIndex = 12
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridViewPenggajian)
        Me.Panel2.Controls.Add(Me.BtnBack)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 480)
        Me.Panel2.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnHitungGaji)
        Me.GroupBox1.Controls.Add(Me.BtnHapusGaji)
        Me.GroupBox1.Controls.Add(Me.BtnEditGaji)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(470, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 288)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'BtnHitungGaji
        '
        Me.BtnHitungGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHitungGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHitungGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHitungGaji.Location = New System.Drawing.Point(20, 54)
        Me.BtnHitungGaji.Name = "BtnHitungGaji"
        Me.BtnHitungGaji.Size = New System.Drawing.Size(169, 50)
        Me.BtnHitungGaji.TabIndex = 11
        Me.BtnHitungGaji.Text = "Hitung"
        Me.BtnHitungGaji.UseVisualStyleBackColor = False
        '
        'BtnHapusGaji
        '
        Me.BtnHapusGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusGaji.Location = New System.Drawing.Point(20, 218)
        Me.BtnHapusGaji.Name = "BtnHapusGaji"
        Me.BtnHapusGaji.Size = New System.Drawing.Size(169, 50)
        Me.BtnHapusGaji.TabIndex = 9
        Me.BtnHapusGaji.Text = "Hapus"
        Me.BtnHapusGaji.UseVisualStyleBackColor = False
        '
        'BtnEditGaji
        '
        Me.BtnEditGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditGaji.Location = New System.Drawing.Point(20, 137)
        Me.BtnEditGaji.Name = "BtnEditGaji"
        Me.BtnEditGaji.Size = New System.Drawing.Size(169, 50)
        Me.BtnEditGaji.TabIndex = 10
        Me.BtnEditGaji.Text = "Edit"
        Me.BtnEditGaji.UseVisualStyleBackColor = False
        '
        'Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Penggajian"
        Me.Text = "Penggajian"
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewPenggajian As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnHitungGaji As Button
    Friend WithEvents BtnHapusGaji As Button
    Friend WithEvents BtnEditGaji As Button
End Class
