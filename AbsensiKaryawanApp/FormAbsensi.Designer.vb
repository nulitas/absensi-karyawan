<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsensi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdnAbsenMasuk = New System.Windows.Forms.RadioButton()
        Me.RdnAbsenKeluar = New System.Windows.Forms.RadioButton()
        Me.CBNamaPegawai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtIdPegawai = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAbsen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(889, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "# Form Absensi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Pegawai"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 478)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdnAbsenMasuk)
        Me.GroupBox1.Controls.Add(Me.RdnAbsenKeluar)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 279)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(246, 89)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Absensi"
        '
        'RdnAbsenMasuk
        '
        Me.RdnAbsenMasuk.AutoSize = True
        Me.RdnAbsenMasuk.Location = New System.Drawing.Point(65, 29)
        Me.RdnAbsenMasuk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdnAbsenMasuk.Name = "RdnAbsenMasuk"
        Me.RdnAbsenMasuk.Size = New System.Drawing.Size(117, 24)
        Me.RdnAbsenMasuk.TabIndex = 8
        Me.RdnAbsenMasuk.TabStop = True
        Me.RdnAbsenMasuk.Text = "Absen Masuk"
        Me.RdnAbsenMasuk.UseVisualStyleBackColor = True
        '
        'RdnAbsenKeluar
        '
        Me.RdnAbsenKeluar.AutoSize = True
        Me.RdnAbsenKeluar.Location = New System.Drawing.Point(65, 56)
        Me.RdnAbsenKeluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdnAbsenKeluar.Name = "RdnAbsenKeluar"
        Me.RdnAbsenKeluar.Size = New System.Drawing.Size(117, 24)
        Me.RdnAbsenKeluar.TabIndex = 9
        Me.RdnAbsenKeluar.TabStop = True
        Me.RdnAbsenKeluar.Text = "Absen Keluar"
        Me.RdnAbsenKeluar.UseVisualStyleBackColor = True
        '
        'CBNamaPegawai
        '
        Me.CBNamaPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBNamaPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaPegawai.FormattingEnabled = True
        Me.CBNamaPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBNamaPegawai.Location = New System.Drawing.Point(313, 227)
        Me.CBNamaPegawai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBNamaPegawai.Name = "CBNamaPegawai"
        Me.CBNamaPegawai.Size = New System.Drawing.Size(245, 28)
        Me.CBNamaPegawai.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Pegawai"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtIdPegawai)
        Me.Panel2.Location = New System.Drawing.Point(313, 125)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 34)
        Me.Panel2.TabIndex = 4
        '
        'TxtIdPegawai
        '
        Me.TxtIdPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TxtIdPegawai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdPegawai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtIdPegawai.Location = New System.Drawing.Point(8, 4)
        Me.TxtIdPegawai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIdPegawai.Name = "TxtIdPegawai"
        Me.TxtIdPegawai.Size = New System.Drawing.Size(230, 20)
        Me.TxtIdPegawai.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnAbsen)
        Me.Panel3.Location = New System.Drawing.Point(300, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 381)
        Me.Panel3.TabIndex = 11
        '
        'BtnAbsen
        '
        Me.BtnAbsen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAbsen.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAbsen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAbsen.Location = New System.Drawing.Point(-1, 335)
        Me.BtnAbsen.Name = "BtnAbsen"
        Me.BtnAbsen.Size = New System.Drawing.Size(275, 45)
        Me.BtnAbsen.TabIndex = 7
        Me.BtnAbsen.Text = "Absen"
        Me.BtnAbsen.UseVisualStyleBackColor = False
        '
        'FormAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormAbsensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Absensi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtIdPegawai As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CBNamaPegawai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAbsen As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdnAbsenMasuk As RadioButton
    Friend WithEvents RdnAbsenKeluar As RadioButton
    Friend WithEvents Panel3 As Panel
End Class
