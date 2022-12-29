<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKaryawan
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
        Me.LblHapusKaryawan = New System.Windows.Forms.Label()
        Me.BtnHapusKaryawan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblHapusKaryawan
        '
        Me.LblHapusKaryawan.AutoSize = True
        Me.LblHapusKaryawan.Location = New System.Drawing.Point(200, 154)
        Me.LblHapusKaryawan.Name = "LblHapusKaryawan"
        Me.LblHapusKaryawan.Size = New System.Drawing.Size(53, 20)
        Me.LblHapusKaryawan.TabIndex = 0
        Me.LblHapusKaryawan.Text = "Label1"
        '
        'BtnHapusKaryawan
        '
        Me.BtnHapusKaryawan.Location = New System.Drawing.Point(189, 200)
        Me.BtnHapusKaryawan.Name = "BtnHapusKaryawan"
        Me.BtnHapusKaryawan.Size = New System.Drawing.Size(94, 29)
        Me.BtnHapusKaryawan.TabIndex = 1
        Me.BtnHapusKaryawan.Text = "Hapus"
        Me.BtnHapusKaryawan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hapus Karyawan ?"
        '
        'HapusKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusKaryawan)
        Me.Controls.Add(Me.LblHapusKaryawan)
        Me.Name = "HapusKaryawan"
        Me.Text = "HapusKaryawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHapusKaryawan As Label
    Friend WithEvents BtnHapusKaryawan As Button
    Friend WithEvents Label1 As Label
End Class
