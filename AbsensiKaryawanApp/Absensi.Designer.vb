<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Absensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewAbsensi = New System.Windows.Forms.DataGridView()
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.BtnEditAbsensi = New System.Windows.Forms.Button()
        Me.BtnAbsenMasuk = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        CType(Me.DataGridViewAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# Absensi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewAbsensi
        '
        Me.DataGridViewAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAbsensi.Location = New System.Drawing.Point(12, 127)
        Me.DataGridViewAbsensi.Name = "DataGridViewAbsensi"
        Me.DataGridViewAbsensi.RowTemplate.Height = 25
        Me.DataGridViewAbsensi.Size = New System.Drawing.Size(565, 199)
        Me.DataGridViewAbsensi.TabIndex = 1
        '
        'BtnHapusAbsensi
        '
        Me.BtnHapusAbsensi.BackColor = System.Drawing.Color.Crimson
        Me.BtnHapusAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusAbsensi.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusAbsensi.ForeColor = System.Drawing.Color.White
        Me.BtnHapusAbsensi.Location = New System.Drawing.Point(12, 77)
        Me.BtnHapusAbsensi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapusAbsensi.Name = "BtnHapusAbsensi"
        Me.BtnHapusAbsensi.Size = New System.Drawing.Size(88, 36)
        Me.BtnHapusAbsensi.TabIndex = 6
        Me.BtnHapusAbsensi.Text = "Hapus"
        Me.BtnHapusAbsensi.UseVisualStyleBackColor = False
        '
        'BtnEditAbsensi
        '
        Me.BtnEditAbsensi.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnEditAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditAbsensi.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditAbsensi.ForeColor = System.Drawing.Color.White
        Me.BtnEditAbsensi.Location = New System.Drawing.Point(117, 77)
        Me.BtnEditAbsensi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditAbsensi.Name = "BtnEditAbsensi"
        Me.BtnEditAbsensi.Size = New System.Drawing.Size(81, 36)
        Me.BtnEditAbsensi.TabIndex = 7
        Me.BtnEditAbsensi.Text = "Edit"
        Me.BtnEditAbsensi.UseVisualStyleBackColor = False
        '
        'BtnAbsenMasuk
        '
        Me.BtnAbsenMasuk.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnAbsenMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbsenMasuk.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAbsenMasuk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAbsenMasuk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAbsenMasuk.Location = New System.Drawing.Point(290, 340)
        Me.BtnAbsenMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAbsenMasuk.Name = "BtnAbsenMasuk"
        Me.BtnAbsenMasuk.Size = New System.Drawing.Size(287, 33)
        Me.BtnAbsenMasuk.TabIndex = 8
        Me.BtnAbsenMasuk.Text = "Absen"
        Me.BtnAbsenMasuk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAbsenMasuk.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnKembali.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnKembali.Location = New System.Drawing.Point(12, 403)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(129, 40)
        Me.BtnKembali.TabIndex = 10
        Me.BtnKembali.Text = "<  Kembali"
        Me.BtnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 454)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnAbsenMasuk)
        Me.Controls.Add(Me.BtnEditAbsensi)
        Me.Controls.Add(Me.BtnHapusAbsensi)
        Me.Controls.Add(Me.DataGridViewAbsensi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Absensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Absensi"
        CType(Me.DataGridViewAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewAbsensi As DataGridView
    Friend WithEvents BtnHapusAbsensi As Button
    Friend WithEvents BtnEditAbsensi As Button
    Friend WithEvents BtnAbsenMasuk As Button
    Friend WithEvents BtnKembali As Button
End Class
