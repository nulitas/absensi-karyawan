<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HitungPenggajian
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtGaji = New System.Windows.Forms.TextBox()
        Me.TxtTotalGaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBIdPegawai = New System.Windows.Forms.ComboBox()
        Me.BtnHitungGaji = New System.Windows.Forms.Button()
        Me.CBBulan = New System.Windows.Forms.ComboBox()
        Me.LblNamaPegawai = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBGaji = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CBGaji)
        Me.Panel1.Controls.Add(Me.TxtGaji)
        Me.Panel1.Controls.Add(Me.TxtTotalGaji)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBIdPegawai)
        Me.Panel1.Controls.Add(Me.BtnHitungGaji)
        Me.Panel1.Controls.Add(Me.CBBulan)
        Me.Panel1.Controls.Add(Me.LblNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(42, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 380)
        Me.Panel1.TabIndex = 4
        '
        'TxtGaji
        '
        Me.TxtGaji.Location = New System.Drawing.Point(202, 52)
        Me.TxtGaji.Name = "TxtGaji"
        Me.TxtGaji.Size = New System.Drawing.Size(125, 27)
        Me.TxtGaji.TabIndex = 11
        '
        'TxtTotalGaji
        '
        Me.TxtTotalGaji.Location = New System.Drawing.Point(82, 266)
        Me.TxtTotalGaji.Name = "TxtTotalGaji"
        Me.TxtTotalGaji.Size = New System.Drawing.Size(245, 27)
        Me.TxtTotalGaji.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bulan Ke"
        '
        'CBIdPegawai
        '
        Me.CBIdPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBIdPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBIdPegawai.FormattingEnabled = True
        Me.CBIdPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBIdPegawai.Location = New System.Drawing.Point(82, 86)
        Me.CBIdPegawai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBIdPegawai.Name = "CBIdPegawai"
        Me.CBIdPegawai.Size = New System.Drawing.Size(245, 28)
        Me.CBIdPegawai.TabIndex = 8
        '
        'BtnHitungGaji
        '
        Me.BtnHitungGaji.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHitungGaji.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHitungGaji.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHitungGaji.Location = New System.Drawing.Point(80, 310)
        Me.BtnHitungGaji.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHitungGaji.Name = "BtnHitungGaji"
        Me.BtnHitungGaji.Size = New System.Drawing.Size(246, 46)
        Me.BtnHitungGaji.TabIndex = 7
        Me.BtnHitungGaji.Text = "Hitung"
        Me.BtnHitungGaji.UseVisualStyleBackColor = False
        '
        'CBBulan
        '
        Me.CBBulan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBulan.FormattingEnabled = True
        Me.CBBulan.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBBulan.Location = New System.Drawing.Point(82, 231)
        Me.CBBulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBBulan.Name = "CBBulan"
        Me.CBBulan.Size = New System.Drawing.Size(245, 28)
        Me.CBBulan.TabIndex = 6
        '
        'LblNamaPegawai
        '
        Me.LblNamaPegawai.AutoSize = True
        Me.LblNamaPegawai.Location = New System.Drawing.Point(150, 150)
        Me.LblNamaPegawai.Name = "LblNamaPegawai"
        Me.LblNamaPegawai.Size = New System.Drawing.Size(119, 20)
        Me.LblNamaPegawai.TabIndex = 5
        Me.LblNamaPegawai.Text = "NAMA PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Pegawai"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(135, 144)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(42, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 40)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# Form Hitung Gaji"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CBGaji
        '
        Me.CBGaji.FormattingEnabled = True
        Me.CBGaji.Location = New System.Drawing.Point(202, 3)
        Me.CBGaji.Name = "CBGaji"
        Me.CBGaji.Size = New System.Drawing.Size(151, 28)
        Me.CBGaji.TabIndex = 12
        '
        'HitungPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HitungPenggajian"
        Me.Text = "HitungPenggajian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnHitungGaji As Button
    Friend WithEvents CBBulan As ComboBox
    Friend WithEvents LblNamaPegawai As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBIdPegawai As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalGaji As TextBox
    Friend WithEvents TxtGaji As TextBox
    Friend WithEvents CBGaji As ComboBox
End Class
