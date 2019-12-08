<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dosenBay
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDosen = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNID = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.inputNama = New System.Windows.Forms.TextBox()
        Me.inputFakultas = New System.Windows.Forms.ComboBox()
        Me.inputProdi = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dgvDosen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 204)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Dosen"
        '
        'dgvDosen
        '
        Me.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDosen.Location = New System.Drawing.Point(7, 42)
        Me.dgvDosen.Name = "dgvDosen"
        Me.dgvDosen.Size = New System.Drawing.Size(670, 156)
        Me.dgvDosen.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(602, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inputProdi)
        Me.GroupBox2.Controls.Add(Me.inputFakultas)
        Me.GroupBox2.Controls.Add(Me.inputNama)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Controls.Add(Me.btnGenerate)
        Me.GroupBox2.Controls.Add(Me.lblNID)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(676, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Dosen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fakultas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prodi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NID"
        '
        'lblNID
        '
        Me.lblNID.AutoSize = True
        Me.lblNID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNID.Location = New System.Drawing.Point(69, 146)
        Me.lblNID.Name = "lblNID"
        Me.lblNID.Size = New System.Drawing.Size(58, 20)
        Me.lblNID.TabIndex = 4
        Me.lblNID.Text = "%%nid&"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(326, 143)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(94, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate NID"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(564, 163)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(94, 23)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'inputNama
        '
        Me.inputNama.Location = New System.Drawing.Point(71, 32)
        Me.inputNama.Name = "inputNama"
        Me.inputNama.Size = New System.Drawing.Size(249, 20)
        Me.inputNama.TabIndex = 6
        '
        'inputFakultas
        '
        Me.inputFakultas.FormattingEnabled = True
        Me.inputFakultas.Location = New System.Drawing.Point(71, 66)
        Me.inputFakultas.Name = "inputFakultas"
        Me.inputFakultas.Size = New System.Drawing.Size(249, 21)
        Me.inputFakultas.TabIndex = 7
        '
        'inputProdi
        '
        Me.inputProdi.FormattingEnabled = True
        Me.inputProdi.Location = New System.Drawing.Point(71, 96)
        Me.inputProdi.Name = "inputProdi"
        Me.inputProdi.Size = New System.Drawing.Size(249, 21)
        Me.inputProdi.TabIndex = 8
        '
        'dosenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "dosenBay"
        Me.Text = "dosenBay"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvDosen As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents inputProdi As ComboBox
    Friend WithEvents inputFakultas As ComboBox
    Friend WithEvents inputNama As TextBox
End Class
