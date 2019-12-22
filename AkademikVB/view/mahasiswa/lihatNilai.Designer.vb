<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lihatNilai
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
        Me.dgvNilai = New System.Windows.Forms.DataGridView()
        Me.txtSmt = New System.Windows.Forms.TextBox()
        Me.lblSmt = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNilai
        '
        Me.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNilai.Location = New System.Drawing.Point(12, 35)
        Me.dgvNilai.Name = "dgvNilai"
        Me.dgvNilai.Size = New System.Drawing.Size(776, 336)
        Me.dgvNilai.TabIndex = 0
        '
        'txtSmt
        '
        Me.txtSmt.Location = New System.Drawing.Point(66, 6)
        Me.txtSmt.Name = "txtSmt"
        Me.txtSmt.Size = New System.Drawing.Size(100, 20)
        Me.txtSmt.TabIndex = 1
        '
        'lblSmt
        '
        Me.lblSmt.AutoSize = True
        Me.lblSmt.Location = New System.Drawing.Point(9, 9)
        Me.lblSmt.Name = "lblSmt"
        Me.lblSmt.Size = New System.Drawing.Size(51, 13)
        Me.lblSmt.TabIndex = 2
        Me.lblSmt.Text = "Semester"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(191, 6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Lihat"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lihatNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 383)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblSmt)
        Me.Controls.Add(Me.txtSmt)
        Me.Controls.Add(Me.dgvNilai)
        Me.Name = "lihatNilai"
        Me.Text = "lihatNilai"
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents txtSmt As TextBox
    Friend WithEvents lblSmt As Label
    Friend WithEvents btnShow As Button
End Class
