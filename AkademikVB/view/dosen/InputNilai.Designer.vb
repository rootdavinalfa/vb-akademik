<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputNilai
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
        Me.cbMataKuliah = New System.Windows.Forms.ComboBox()
        Me.buttonShow = New System.Windows.Forms.Button()
        Me.dgvNilai = New System.Windows.Forms.DataGridView()
        Me.buttonLapor = New System.Windows.Forms.Button()
        Me.cbKelompok = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mata Kuliah"
        '
        'cbMataKuliah
        '
        Me.cbMataKuliah.FormattingEnabled = True
        Me.cbMataKuliah.Location = New System.Drawing.Point(98, 17)
        Me.cbMataKuliah.Name = "cbMataKuliah"
        Me.cbMataKuliah.Size = New System.Drawing.Size(397, 21)
        Me.cbMataKuliah.TabIndex = 1
        '
        'buttonShow
        '
        Me.buttonShow.Location = New System.Drawing.Point(420, 44)
        Me.buttonShow.Name = "buttonShow"
        Me.buttonShow.Size = New System.Drawing.Size(75, 23)
        Me.buttonShow.TabIndex = 2
        Me.buttonShow.Text = "Show Data"
        Me.buttonShow.UseVisualStyleBackColor = True
        '
        'dgvNilai
        '
        Me.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNilai.Location = New System.Drawing.Point(16, 105)
        Me.dgvNilai.Name = "dgvNilai"
        Me.dgvNilai.Size = New System.Drawing.Size(486, 310)
        Me.dgvNilai.TabIndex = 3
        '
        'buttonLapor
        '
        Me.buttonLapor.Location = New System.Drawing.Point(427, 421)
        Me.buttonLapor.Name = "buttonLapor"
        Me.buttonLapor.Size = New System.Drawing.Size(75, 23)
        Me.buttonLapor.TabIndex = 4
        Me.buttonLapor.Text = "Lapor Nilai"
        Me.buttonLapor.UseVisualStyleBackColor = True
        '
        'cbKelompok
        '
        Me.cbKelompok.FormattingEnabled = True
        Me.cbKelompok.Location = New System.Drawing.Point(98, 46)
        Me.cbKelompok.Name = "cbKelompok"
        Me.cbKelompok.Size = New System.Drawing.Size(132, 21)
        Me.cbKelompok.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kelompok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(490, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tolong diperhatikan,pastikan input nilai dengan format 00.00 (2 digit-2digit)"
        '
        'InputNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbKelompok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonLapor)
        Me.Controls.Add(Me.dgvNilai)
        Me.Controls.Add(Me.buttonShow)
        Me.Controls.Add(Me.cbMataKuliah)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InputNilai"
        Me.Text = "InputNilai"
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMataKuliah As ComboBox
    Friend WithEvents buttonShow As Button
    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents buttonLapor As Button
    Friend WithEvents cbKelompok As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
