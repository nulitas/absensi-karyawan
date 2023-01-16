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
        Me.DataGridViewAbsensi = New System.Windows.Forms.DataGridView()
        Me.BtnHapusAbsensi = New System.Windows.Forms.Button()
        Me.BtnEditAbsensi = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewAbsensi
        '
        Me.DataGridViewAbsensi.AllowUserToAddRows = False
        Me.DataGridViewAbsensi.AllowUserToDeleteRows = False
        Me.DataGridViewAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAbsensi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewAbsensi.Location = New System.Drawing.Point(18, 135)
        Me.DataGridViewAbsensi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewAbsensi.Name = "DataGridViewAbsensi"
        Me.DataGridViewAbsensi.RowHeadersWidth = 51
        Me.DataGridViewAbsensi.RowTemplate.Height = 25
        Me.DataGridViewAbsensi.Size = New System.Drawing.Size(629, 265)
        Me.DataGridViewAbsensi.TabIndex = 0
        '
        'BtnHapusAbsensi
        '
        Me.BtnHapusAbsensi.BackColor = System.Drawing.Color.Black
        Me.BtnHapusAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusAbsensi.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusAbsensi.ForeColor = System.Drawing.Color.White
        Me.BtnHapusAbsensi.Location = New System.Drawing.Point(35, 170)
        Me.BtnHapusAbsensi.Name = "BtnHapusAbsensi"
        Me.BtnHapusAbsensi.Size = New System.Drawing.Size(118, 48)
        Me.BtnHapusAbsensi.TabIndex = 6
        Me.BtnHapusAbsensi.Text = "Hapus"
        Me.BtnHapusAbsensi.UseVisualStyleBackColor = False
        '
        'BtnEditAbsensi
        '
        Me.BtnEditAbsensi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEditAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditAbsensi.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEditAbsensi.ForeColor = System.Drawing.Color.Black
        Me.BtnEditAbsensi.Location = New System.Drawing.Point(35, 84)
        Me.BtnEditAbsensi.Name = "BtnEditAbsensi"
        Me.BtnEditAbsensi.Size = New System.Drawing.Size(118, 48)
        Me.BtnEditAbsensi.TabIndex = 7
        Me.BtnEditAbsensi.Text = "Edit"
        Me.BtnEditAbsensi.UseVisualStyleBackColor = False
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnKembali.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnKembali.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnKembali.Location = New System.Drawing.Point(14, 537)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(147, 53)
        Me.BtnKembali.TabIndex = 10
        Me.BtnKembali.Text = "<  Kembali"
        Me.BtnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.DataGridViewAbsensi)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 467)
        Me.Panel1.TabIndex = 11
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBack.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnBack.Location = New System.Drawing.Point(3, 59)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(144, 46)
        Me.BtnBack.TabIndex = 13
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEditAbsensi)
        Me.GroupBox1.Controls.Add(Me.BtnHapusAbsensi)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(670, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 265)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(889, 56)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "# Absensi"
        '
        'Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Absensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Absensi"
        CType(Me.DataGridViewAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewAbsensi As DataGridView
    Friend WithEvents BtnHapusAbsensi As Button
    Friend WithEvents BtnEditAbsensi As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
End Class
