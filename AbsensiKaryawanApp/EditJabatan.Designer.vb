<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJabatan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNamaJabatan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtGaji = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 461)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(515, 48)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "# Edit Jabatan"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtNamaJabatan)
        Me.Panel3.Location = New System.Drawing.Point(154, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 39)
        Me.Panel3.TabIndex = 8
        '
        'TxtNamaJabatan
        '
        Me.TxtNamaJabatan.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtNamaJabatan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNamaJabatan.Location = New System.Drawing.Point(6, 9)
        Me.TxtNamaJabatan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNamaJabatan.Name = "TxtNamaJabatan"
        Me.TxtNamaJabatan.Size = New System.Drawing.Size(253, 20)
        Me.TxtNamaJabatan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Gaji/Hari"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdit.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEdit.Location = New System.Drawing.Point(270, 290)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(144, 46)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtGaji)
        Me.Panel2.Location = New System.Drawing.Point(154, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 39)
        Me.Panel2.TabIndex = 7
        '
        'TxtGaji
        '
        Me.TxtGaji.BackColor = System.Drawing.SystemColors.Menu
        Me.TxtGaji.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGaji.Location = New System.Drawing.Point(7, 8)
        Me.TxtGaji.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGaji.Name = "TxtGaji"
        Me.TxtGaji.Size = New System.Drawing.Size(252, 20)
        Me.TxtGaji.TabIndex = 3
        '
        'EditJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditJabatan"
        Me.Text = "EditJabatan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtNamaJabatan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtGaji As TextBox
End Class
