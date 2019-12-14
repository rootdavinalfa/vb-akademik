<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowSiswa
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
        Me.pickMK = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSiswa = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pickMK
        '
        Me.pickMK.FormattingEnabled = True
        Me.pickMK.Location = New System.Drawing.Point(168, 25)
        Me.pickMK.Name = "pickMK"
        Me.pickMK.Size = New System.Drawing.Size(314, 21)
        Me.pickMK.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MK / Semester mengajar"
        '
        'dgvSiswa
        '
        Me.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiswa.Location = New System.Drawing.Point(15, 75)
        Me.dgvSiswa.Name = "dgvSiswa"
        Me.dgvSiswa.Size = New System.Drawing.Size(773, 363)
        Me.dgvSiswa.TabIndex = 2
        '
        'ShowSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvSiswa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pickMK)
        Me.MaximizeBox = False
        Me.Name = "ShowSiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lihat Siswa"
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pickMK As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSiswa As DataGridView
End Class
