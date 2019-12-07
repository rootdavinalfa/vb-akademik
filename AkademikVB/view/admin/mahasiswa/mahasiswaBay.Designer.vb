<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mahasiswaBay
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvListMahasiswa = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listProdi = New System.Windows.Forms.ComboBox()
        Me.listFakultas = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inputNama = New System.Windows.Forms.TextBox()
        Me.inputProdi = New System.Windows.Forms.ComboBox()
        Me.inputFakultas = New System.Windows.Forms.ComboBox()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnKelas = New System.Windows.Forms.Button()
        Me.btnGenerateNim = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dgvListMahasiswa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.listProdi)
        Me.GroupBox1.Controls.Add(Me.listFakultas)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Mahasiswa"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(694, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvListMahasiswa
        '
        Me.dgvListMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListMahasiswa.Location = New System.Drawing.Point(10, 55)
        Me.dgvListMahasiswa.Name = "dgvListMahasiswa"
        Me.dgvListMahasiswa.Size = New System.Drawing.Size(759, 172)
        Me.dgvListMahasiswa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prodi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fakultas"
        '
        'listProdi
        '
        Me.listProdi.FormattingEnabled = True
        Me.listProdi.Location = New System.Drawing.Point(265, 23)
        Me.listProdi.Name = "listProdi"
        Me.listProdi.Size = New System.Drawing.Size(121, 21)
        Me.listProdi.TabIndex = 1
        '
        'listFakultas
        '
        Me.listFakultas.FormattingEnabled = True
        Me.listFakultas.Location = New System.Drawing.Point(60, 23)
        Me.listFakultas.Name = "listFakultas"
        Me.listFakultas.Size = New System.Drawing.Size(149, 21)
        Me.listFakultas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnGenerateNim)
        Me.GroupBox2.Controls.Add(Me.inputNama)
        Me.GroupBox2.Controls.Add(Me.inputProdi)
        Me.GroupBox2.Controls.Add(Me.inputFakultas)
        Me.GroupBox2.Controls.Add(Me.lblNim)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnCreate)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(769, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mahasiswa Baru"
        '
        'inputNama
        '
        Me.inputNama.Location = New System.Drawing.Point(73, 27)
        Me.inputNama.Name = "inputNama"
        Me.inputNama.Size = New System.Drawing.Size(321, 20)
        Me.inputNama.TabIndex = 14
        '
        'inputProdi
        '
        Me.inputProdi.FormattingEnabled = True
        Me.inputProdi.Location = New System.Drawing.Point(73, 104)
        Me.inputProdi.Name = "inputProdi"
        Me.inputProdi.Size = New System.Drawing.Size(186, 21)
        Me.inputProdi.TabIndex = 13
        '
        'inputFakultas
        '
        Me.inputFakultas.FormattingEnabled = True
        Me.inputFakultas.Location = New System.Drawing.Point(73, 66)
        Me.inputFakultas.Name = "inputFakultas"
        Me.inputFakultas.Size = New System.Drawing.Size(186, 21)
        Me.inputFakultas.TabIndex = 8
        '
        'lblNim
        '
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNim.Location = New System.Drawing.Point(603, 64)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.Size = New System.Drawing.Size(46, 20)
        Me.lblNim.TabIndex = 12
        Me.lblNim.Text = "NIM :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Prodi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nama"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(688, 124)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Buat"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnKelas
        '
        Me.btnKelas.Location = New System.Drawing.Point(13, 415)
        Me.btnKelas.Name = "btnKelas"
        Me.btnKelas.Size = New System.Drawing.Size(177, 23)
        Me.btnKelas.TabIndex = 15
        Me.btnKelas.Text = "Buat dan Lihat Kelas Mahasiswa"
        Me.btnKelas.UseVisualStyleBackColor = True
        '
        'btnGenerateNim
        '
        Me.btnGenerateNim.Location = New System.Drawing.Point(560, 27)
        Me.btnGenerateNim.Name = "btnGenerateNim"
        Me.btnGenerateNim.Size = New System.Drawing.Size(104, 23)
        Me.btnGenerateNim.TabIndex = 15
        Me.btnGenerateNim.Text = "Generate NIM"
        Me.btnGenerateNim.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NIM :"
        '
        'mahasiswaBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKelas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mahasiswaBay"
        Me.Text = "mahasiswaBay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listProdi As ComboBox
    Friend WithEvents listFakultas As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvListMahasiswa As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents inputProdi As ComboBox
    Friend WithEvents inputFakultas As ComboBox
    Friend WithEvents inputNama As TextBox
    Friend WithEvents btnKelas As Button
    Friend WithEvents btnGenerateNim As Button
    Friend WithEvents Label3 As Label
End Class
