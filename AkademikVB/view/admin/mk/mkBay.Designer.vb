<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mkBay
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
        Me.listProdi = New System.Windows.Forms.ComboBox()
        Me.listFakultas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvMKList = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDosen = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.inputProdi = New System.Windows.Forms.ComboBox()
        Me.inputFakultas = New System.Windows.Forms.ComboBox()
        Me.inputSemester = New System.Windows.Forms.TextBox()
        Me.inputNamaMK = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblIDMK = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPengajar = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMKList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.listProdi)
        Me.GroupBox1.Controls.Add(Me.listFakultas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List MK"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(694, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'listProdi
        '
        Me.listProdi.FormattingEnabled = True
        Me.listProdi.Location = New System.Drawing.Point(292, 19)
        Me.listProdi.Name = "listProdi"
        Me.listProdi.Size = New System.Drawing.Size(215, 21)
        Me.listProdi.TabIndex = 3
        '
        'listFakultas
        '
        Me.listFakultas.FormattingEnabled = True
        Me.listFakultas.Location = New System.Drawing.Point(61, 20)
        Me.listFakultas.Name = "listFakultas"
        Me.listFakultas.Size = New System.Drawing.Size(188, 21)
        Me.listFakultas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prodi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fakultas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvMKList)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 242)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List"
        '
        'dgvMKList
        '
        Me.dgvMKList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMKList.Location = New System.Drawing.Point(7, 20)
        Me.dgvMKList.Name = "dgvMKList"
        Me.dgvMKList.Size = New System.Drawing.Size(378, 216)
        Me.dgvMKList.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDosen)
        Me.GroupBox3.Location = New System.Drawing.Point(410, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 242)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dosen Pengajar"
        '
        'dgvDosen
        '
        Me.dgvDosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDosen.Location = New System.Drawing.Point(6, 19)
        Me.dgvDosen.Name = "dgvDosen"
        Me.dgvDosen.Size = New System.Drawing.Size(360, 217)
        Me.dgvDosen.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCreate)
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.inputProdi)
        Me.GroupBox4.Controls.Add(Me.inputFakultas)
        Me.GroupBox4.Controls.Add(Me.inputSemester)
        Me.GroupBox4.Controls.Add(Me.inputNamaMK)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblIDMK)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 318)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(775, 175)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Create MK"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCreate.Location = New System.Drawing.Point(700, 132)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGenerate.Location = New System.Drawing.Point(652, 36)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'inputProdi
        '
        Me.inputProdi.FormattingEnabled = True
        Me.inputProdi.Location = New System.Drawing.Point(77, 104)
        Me.inputProdi.Name = "inputProdi"
        Me.inputProdi.Size = New System.Drawing.Size(308, 21)
        Me.inputProdi.TabIndex = 9
        '
        'inputFakultas
        '
        Me.inputFakultas.FormattingEnabled = True
        Me.inputFakultas.Location = New System.Drawing.Point(77, 72)
        Me.inputFakultas.Name = "inputFakultas"
        Me.inputFakultas.Size = New System.Drawing.Size(308, 21)
        Me.inputFakultas.TabIndex = 8
        '
        'inputSemester
        '
        Me.inputSemester.Location = New System.Drawing.Point(77, 134)
        Me.inputSemester.Name = "inputSemester"
        Me.inputSemester.Size = New System.Drawing.Size(172, 20)
        Me.inputSemester.TabIndex = 7
        '
        'inputNamaMK
        '
        Me.inputNamaMK.Location = New System.Drawing.Point(77, 36)
        Me.inputNamaMK.Name = "inputNamaMK"
        Me.inputNamaMK.Size = New System.Drawing.Size(308, 20)
        Me.inputNamaMK.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Semester"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Prodi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fakultas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama MK"
        '
        'lblIDMK
        '
        Me.lblIDMK.AutoSize = True
        Me.lblIDMK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDMK.Location = New System.Drawing.Point(461, 36)
        Me.lblIDMK.Name = "lblIDMK"
        Me.lblIDMK.Size = New System.Drawing.Size(110, 24)
        Me.lblIDMK.TabIndex = 1
        Me.lblIDMK.Text = "%%idmk%%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID MK"
        '
        'btnPengajar
        '
        Me.btnPengajar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPengajar.Location = New System.Drawing.Point(13, 499)
        Me.btnPengajar.Name = "btnPengajar"
        Me.btnPengajar.Size = New System.Drawing.Size(147, 23)
        Me.btnPengajar.TabIndex = 12
        Me.btnPengajar.Text = "Buat dan Lihat Pengajar"
        Me.btnPengajar.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(600, 15)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'mkBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.btnPengajar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mkBay"
        Me.Text = "mkBay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvMKList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDosen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents listProdi As ComboBox
    Friend WithEvents listFakultas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvMKList As DataGridView
    Friend WithEvents dgvDosen As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIDMK As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents inputProdi As ComboBox
    Friend WithEvents inputFakultas As ComboBox
    Friend WithEvents inputSemester As TextBox
    Friend WithEvents inputNamaMK As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnPengajar As Button
    Friend WithEvents btnUpdate As Button
End Class
