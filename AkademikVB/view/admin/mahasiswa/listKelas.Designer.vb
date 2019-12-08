<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listKelas
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
        Me.dgvKelas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateNewClass = New System.Windows.Forms.Button()
        Me.dgvMhs = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnIN = New System.Windows.Forms.Button()
        Me.btnOUT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNotHave = New System.Windows.Forms.RadioButton()
        Me.rbIsiKelas = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvAction = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Kelas"
        '
        'dgvKelas
        '
        Me.dgvKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelas.Location = New System.Drawing.Point(15, 125)
        Me.dgvKelas.Name = "dgvKelas"
        Me.dgvKelas.Size = New System.Drawing.Size(216, 255)
        Me.dgvKelas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilih Mahasiswa"
        '
        'btnCreateNewClass
        '
        Me.btnCreateNewClass.Location = New System.Drawing.Point(15, 13)
        Me.btnCreateNewClass.Name = "btnCreateNewClass"
        Me.btnCreateNewClass.Size = New System.Drawing.Size(110, 23)
        Me.btnCreateNewClass.TabIndex = 3
        Me.btnCreateNewClass.Text = "Buat Kelas Baru"
        Me.btnCreateNewClass.UseVisualStyleBackColor = True
        '
        'dgvMhs
        '
        Me.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMhs.Location = New System.Drawing.Point(290, 125)
        Me.dgvMhs.Name = "dgvMhs"
        Me.dgvMhs.Size = New System.Drawing.Size(373, 255)
        Me.dgvMhs.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(526, 499)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnIN
        '
        Me.btnIN.Location = New System.Drawing.Point(237, 186)
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(47, 46)
        Me.btnIN.TabIndex = 6
        Me.btnIN.Text = "< IN"
        Me.btnIN.UseVisualStyleBackColor = True
        '
        'btnOUT
        '
        Me.btnOUT.Location = New System.Drawing.Point(237, 238)
        Me.btnOUT.Name = "btnOUT"
        Me.btnOUT.Size = New System.Drawing.Size(47, 46)
        Me.btnOUT.TabIndex = 7
        Me.btnOUT.Text = "X Out"
        Me.btnOUT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNotHave)
        Me.GroupBox1.Controls.Add(Me.rbIsiKelas)
        Me.GroupBox1.Location = New System.Drawing.Point(423, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 71)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Mahasiswa"
        '
        'rbNotHave
        '
        Me.rbNotHave.AutoSize = True
        Me.rbNotHave.Location = New System.Drawing.Point(7, 45)
        Me.rbNotHave.Name = "rbNotHave"
        Me.rbNotHave.Size = New System.Drawing.Size(217, 17)
        Me.rbNotHave.TabIndex = 1
        Me.rbNotHave.TabStop = True
        Me.rbNotHave.Text = "List Mahasiswa Yang Tidak Punya Kelas"
        Me.rbNotHave.UseVisualStyleBackColor = True
        '
        'rbIsiKelas
        '
        Me.rbIsiKelas.AutoSize = True
        Me.rbIsiKelas.Location = New System.Drawing.Point(7, 16)
        Me.rbIsiKelas.Name = "rbIsiKelas"
        Me.rbIsiKelas.Size = New System.Drawing.Size(90, 17)
        Me.rbIsiKelas.TabIndex = 0
        Me.rbIsiKelas.TabStop = True
        Me.rbIsiKelas.Text = "Lihat Isi Kelas"
        Me.rbIsiKelas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Action List"
        '
        'dgvAction
        '
        Me.dgvAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAction.Location = New System.Drawing.Point(15, 410)
        Me.dgvAction.Name = "dgvAction"
        Me.dgvAction.Size = New System.Drawing.Size(505, 112)
        Me.dgvAction.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Clear Action"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(67, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Fakultas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Prodi"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(67, 69)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox2.TabIndex = 14
        '
        'listKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 523)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvAction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOUT)
        Me.Controls.Add(Me.btnIN)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvMhs)
        Me.Controls.Add(Me.btnCreateNewClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvKelas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listKelas"
        Me.Text = "listKelas"
        CType(Me.dgvKelas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvKelas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateNewClass As Button
    Friend WithEvents dgvMhs As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnIN As Button
    Friend WithEvents btnOUT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNotHave As RadioButton
    Friend WithEvents rbIsiKelas As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvAction As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class
