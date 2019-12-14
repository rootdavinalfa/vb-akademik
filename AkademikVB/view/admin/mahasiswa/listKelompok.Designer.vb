<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listKelompok
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvMhs = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNotHave = New System.Windows.Forms.RadioButton()
        Me.rbGantiKelompok = New System.Windows.Forms.RadioButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(411, 54)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvMhs
        '
        Me.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMhs.Location = New System.Drawing.Point(6, 99)
        Me.dgvMhs.Name = "dgvMhs"
        Me.dgvMhs.Size = New System.Drawing.Size(480, 292)
        Me.dgvMhs.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNotHave)
        Me.GroupBox1.Controls.Add(Me.rbGantiKelompok)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 71)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Mahasiswa"
        '
        'rbNotHave
        '
        Me.rbNotHave.AutoSize = True
        Me.rbNotHave.Location = New System.Drawing.Point(7, 45)
        Me.rbNotHave.Name = "rbNotHave"
        Me.rbNotHave.Size = New System.Drawing.Size(137, 17)
        Me.rbNotHave.TabIndex = 1
        Me.rbNotHave.TabStop = True
        Me.rbNotHave.Text = "Belum Punya Kelompok"
        Me.rbNotHave.UseVisualStyleBackColor = True
        '
        'rbGantiKelompok
        '
        Me.rbGantiKelompok.AutoSize = True
        Me.rbGantiKelompok.Location = New System.Drawing.Point(7, 16)
        Me.rbGantiKelompok.Name = "rbGantiKelompok"
        Me.rbGantiKelompok.Size = New System.Drawing.Size(100, 17)
        Me.rbGantiKelompok.TabIndex = 0
        Me.rbGantiKelompok.TabStop = True
        Me.rbGantiKelompok.Text = "Ganti Kelompok"
        Me.rbGantiKelompok.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(411, 415)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'listKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMhs)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "listKelompok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listKelompok"
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvMhs As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNotHave As RadioButton
    Friend WithEvents rbGantiKelompok As RadioButton
    Friend WithEvents btnUpdate As Button
End Class
