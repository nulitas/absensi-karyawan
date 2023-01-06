<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusPenggajian
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
        Me.BtnHapusPenggajian = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHapusPenggajian = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnHapusPenggajian)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LblHapusPenggajian)
        Me.Panel1.Location = New System.Drawing.Point(15, -9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 468)
        Me.Panel1.TabIndex = 5
        '
        'BtnHapusPenggajian
        '
        Me.BtnHapusPenggajian.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusPenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusPenggajian.Font = New System.Drawing.Font("Myanmar Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusPenggajian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHapusPenggajian.Location = New System.Drawing.Point(175, 322)
        Me.BtnHapusPenggajian.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnHapusPenggajian.Name = "BtnHapusPenggajian"
        Me.BtnHapusPenggajian.Size = New System.Drawing.Size(162, 60)
        Me.BtnHapusPenggajian.TabIndex = 1
        Me.BtnHapusPenggajian.Text = "Hapus"
        Me.BtnHapusPenggajian.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Myanmar Text", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancel.Location = New System.Drawing.Point(384, 322)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(162, 60)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Batal"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-1, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(771, 70)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "# Hapus Penggajian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(98, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(571, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apakah anda ingin menghapus penggajian ?"
        '
        'LblHapusPenggajian
        '
        Me.LblHapusPenggajian.AutoSize = True
        Me.LblHapusPenggajian.Font = New System.Drawing.Font("Myanmar Text", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHapusPenggajian.Location = New System.Drawing.Point(288, 197)
        Me.LblHapusPenggajian.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHapusPenggajian.Name = "LblHapusPenggajian"
        Me.LblHapusPenggajian.Size = New System.Drawing.Size(153, 71)
        Me.LblHapusPenggajian.TabIndex = 0
        Me.LblHapusPenggajian.Text = "Label1"
        '
        'HapusPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HapusPenggajian"
        Me.Text = "HapusPenggajian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnHapusPenggajian As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblHapusPenggajian As Label
End Class
