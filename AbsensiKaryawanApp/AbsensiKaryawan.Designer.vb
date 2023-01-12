<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbsensiKaryawan
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnFormAbsensi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLogin.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLogin.Location = New System.Drawing.Point(112, 213)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(193, 63)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnFormAbsensi
        '
        Me.BtnFormAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormAbsensi.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormAbsensi.ForeColor = System.Drawing.Color.Black
        Me.BtnFormAbsensi.Location = New System.Drawing.Point(112, 304)
        Me.BtnFormAbsensi.Name = "BtnFormAbsensi"
        Me.BtnFormAbsensi.Size = New System.Drawing.Size(193, 57)
        Me.BtnFormAbsensi.TabIndex = 5
        Me.BtnFormAbsensi.Text = "Absensi"
        Me.BtnFormAbsensi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 60)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Absensi Karyawan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(30, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(377, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Absensi untuk mempermudah di sistem"
        '
        'AbsensiKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 481)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFormAbsensi)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "AbsensiKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AbsensiKaryawan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnFormAbsensi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
