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
        Me.BtnHitungGaji = New System.Windows.Forms.Button()
        Me.BtnEditGaji = New System.Windows.Forms.Button()
        Me.BtnHapusGaji = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1332, 70)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "# Form Penggajian"
        '
        'DataGridViewPenggajian
        '
        Me.DataGridViewPenggajian.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPenggajian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenggajian.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPenggajian.Location = New System.Drawing.Point(39, 133)
        Me.DataGridViewPenggajian.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewPenggajian.Name = "DataGridViewPenggajian"
        Me.DataGridViewPenggajian.RowHeadersWidth = 51
        Me.DataGridViewPenggajian.RowTemplate.Height = 29
        Me.DataGridViewPenggajian.Size = New System.Drawing.Size(792, 360)
        Me.DataGridViewPenggajian.TabIndex = 8
        '
        'BtnHitungGaji
        '
        Me.BtnHitungGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHitungGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHitungGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHitungGaji.Location = New System.Drawing.Point(973, 186)
        Me.BtnHitungGaji.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHitungGaji.Name = "BtnHitungGaji"
        Me.BtnHitungGaji.Size = New System.Drawing.Size(211, 62)
        Me.BtnHitungGaji.TabIndex = 11
        Me.BtnHitungGaji.Text = "Hitung"
        Me.BtnHitungGaji.UseVisualStyleBackColor = False
        '
        'BtnEditGaji
        '
        Me.BtnEditGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditGaji.Location = New System.Drawing.Point(973, 275)
        Me.BtnEditGaji.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditGaji.Name = "BtnEditGaji"
        Me.BtnEditGaji.Size = New System.Drawing.Size(211, 62)
        Me.BtnEditGaji.TabIndex = 10
        Me.BtnEditGaji.Text = "Edit"
        Me.BtnEditGaji.UseVisualStyleBackColor = False
        '
        'BtnHapusGaji
        '
        Me.BtnHapusGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusGaji.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusGaji.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnHapusGaji.Location = New System.Drawing.Point(973, 360)
        Me.BtnHapusGaji.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapusGaji.Name = "BtnHapusGaji"
        Me.BtnHapusGaji.Size = New System.Drawing.Size(211, 62)
        Me.BtnHapusGaji.TabIndex = 9
        Me.BtnHapusGaji.Text = "Hapus"
        Me.BtnHapusGaji.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBack.Location = New System.Drawing.Point(24, 74)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(169, 48)
        Me.BtnBack.TabIndex = 12
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 531)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnHitungGaji)
        Me.Controls.Add(Me.BtnEditGaji)
        Me.Controls.Add(Me.BtnHapusGaji)
        Me.Controls.Add(Me.DataGridViewPenggajian)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Penggajian"
        Me.Text = "Penggajian"
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewPenggajian As DataGridView
    Friend WithEvents BtnHitungGaji As Button
    Friend WithEvents BtnEditGaji As Button
    Friend WithEvents BtnHapusGaji As Button
    Friend WithEvents BtnBack As Button
End Class
