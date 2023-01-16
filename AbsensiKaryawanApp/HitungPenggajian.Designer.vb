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
        Me.LblNamaPegawai = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGaji = New System.Windows.Forms.TextBox()
        Me.TxtTotalGaji = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBIdPegawai = New System.Windows.Forms.ComboBox()
        Me.BtnHitungGaji = New System.Windows.Forms.Button()
        Me.CBBulan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtGaji)
        Me.Panel1.Controls.Add(Me.TxtTotalGaji)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBIdPegawai)
        Me.Panel1.Controls.Add(Me.BtnHitungGaji)
        Me.Panel1.Controls.Add(Me.CBBulan)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 478)
        Me.Panel1.TabIndex = 4
        '
        'LblNamaPegawai
        '
        Me.LblNamaPegawai.AutoSize = True
        Me.LblNamaPegawai.Location = New System.Drawing.Point(239, 107)
        Me.LblNamaPegawai.Name = "LblNamaPegawai"
        Me.LblNamaPegawai.Size = New System.Drawing.Size(117, 20)
        Me.LblNamaPegawai.TabIndex = 5
        Me.LblNamaPegawai.Text = "Nama Karyawan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gaji Perhari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total Gaji"
        '
        'TxtGaji
        '
        Me.TxtGaji.Enabled = False
        Me.TxtGaji.Location = New System.Drawing.Point(362, 150)
        Me.TxtGaji.Name = "TxtGaji"
        Me.TxtGaji.Size = New System.Drawing.Size(245, 27)
        Me.TxtGaji.TabIndex = 11
        '
        'TxtTotalGaji
        '
        Me.TxtTotalGaji.Location = New System.Drawing.Point(362, 227)
        Me.TxtTotalGaji.Name = "TxtTotalGaji"
        Me.TxtTotalGaji.Size = New System.Drawing.Size(245, 27)
        Me.TxtTotalGaji.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 189)
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
        Me.CBIdPegawai.Location = New System.Drawing.Point(362, 104)
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
        Me.BtnHitungGaji.Location = New System.Drawing.Point(362, 282)
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
        Me.CBBulan.Location = New System.Drawing.Point(362, 189)
        Me.CBBulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBBulan.Name = "CBBulan"
        Me.CBBulan.Size = New System.Drawing.Size(245, 28)
        Me.CBBulan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(889, 40)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# Form Hitung Gaji"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HitungPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 504)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents CBIdPegawai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalGaji As TextBox
    Friend WithEvents TxtGaji As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
