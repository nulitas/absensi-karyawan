<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penggajian
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
        Me.DataGridViewPenggajian = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPenggajian
        '
        Me.DataGridViewPenggajian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenggajian.Location = New System.Drawing.Point(47, 67)
        Me.DataGridViewPenggajian.Name = "DataGridViewPenggajian"
        Me.DataGridViewPenggajian.RowHeadersWidth = 51
        Me.DataGridViewPenggajian.RowTemplate.Height = 29
        Me.DataGridViewPenggajian.Size = New System.Drawing.Size(597, 317)
        Me.DataGridViewPenggajian.TabIndex = 0
        '
        'Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewPenggajian)
        Me.Name = "Penggajian"
        Me.Text = "Penggajian"
        CType(Me.DataGridViewPenggajian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPenggajian As DataGridView
End Class
