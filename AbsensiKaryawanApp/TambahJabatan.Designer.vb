<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJabatan
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
        Me.TxtNamaJabatan = New System.Windows.Forms.TextBox()
        Me.TxtGaji = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Jabatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gaji/Hari"
        '
        'TxtNamaJabatan
        '
        Me.TxtNamaJabatan.Location = New System.Drawing.Point(183, 52)
        Me.TxtNamaJabatan.Name = "TxtNamaJabatan"
        Me.TxtNamaJabatan.Size = New System.Drawing.Size(141, 23)
        Me.TxtNamaJabatan.TabIndex = 2
        '
        'TxtGaji
        '
        Me.TxtGaji.Location = New System.Drawing.Point(183, 99)
        Me.TxtGaji.Name = "TxtGaji"
        Me.TxtGaji.Size = New System.Drawing.Size(141, 23)
        Me.TxtGaji.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(249, 168)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtGaji)
        Me.Controls.Add(Me.TxtNamaJabatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahJabatan"
        Me.Text = "TambahJabatan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaJabatan As TextBox
    Friend WithEvents TxtGaji As TextBox
    Friend WithEvents BtnTambah As Button
End Class
