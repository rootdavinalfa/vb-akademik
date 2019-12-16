<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showKRS
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
        Me.lblSmtKelompok = New System.Windows.Forms.Label()
        Me.krsDGV = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.krsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSmtKelompok
        '
        Me.lblSmtKelompok.AutoSize = True
        Me.lblSmtKelompok.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSmtKelompok.Location = New System.Drawing.Point(13, 13)
        Me.lblSmtKelompok.Name = "lblSmtKelompok"
        Me.lblSmtKelompok.Size = New System.Drawing.Size(451, 39)
        Me.lblSmtKelompok.TabIndex = 0
        Me.lblSmtKelompok.Text = "Semester 1 @ Kelompok : 1"
        '
        'krsDGV
        '
        Me.krsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.krsDGV.Location = New System.Drawing.Point(21, 138)
        Me.krsDGV.Name = "krsDGV"
        Me.krsDGV.Size = New System.Drawing.Size(767, 300)
        Me.krsDGV.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(301, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'showKRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.krsDGV)
        Me.Controls.Add(Me.lblSmtKelompok)
        Me.MaximizeBox = False
        Me.Name = "showKRS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lihat KRS"
        CType(Me.krsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSmtKelompok As Label
    Friend WithEvents krsDGV As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
