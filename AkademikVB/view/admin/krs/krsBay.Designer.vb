<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class krsBay
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputNIM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvKrs = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textName = New System.Windows.Forms.Label()
        Me.textFakultas = New System.Windows.Forms.Label()
        Me.textProdi = New System.Windows.Forms.Label()
        Me.textSemester = New System.Windows.Forms.Label()
        CType(Me.dgvKrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acc KRS Untuk Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIM"
        '
        'inputNIM
        '
        Me.inputNIM.Location = New System.Drawing.Point(47, 63)
        Me.inputNIM.Name = "inputNIM"
        Me.inputNIM.Size = New System.Drawing.Size(233, 20)
        Me.inputNIM.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "'ENTERのボタン をクリックしてください"
        '
        'dgvKrs
        '
        Me.dgvKrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKrs.Location = New System.Drawing.Point(17, 191)
        Me.dgvKrs.Name = "dgvKrs"
        Me.dgvKrs.Size = New System.Drawing.Size(662, 265)
        Me.dgvKrs.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Please check information on right,if correct then you may continue your flow!"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(604, 462)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "ACC"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(389, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Fakultas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(389, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Semester"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(389, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Prodi"
        '
        'textName
        '
        Me.textName.AutoSize = True
        Me.textName.Location = New System.Drawing.Point(468, 66)
        Me.textName.Name = "textName"
        Me.textName.Size = New System.Drawing.Size(41, 13)
        Me.textName.TabIndex = 11
        Me.textName.Text = "%name"
        '
        'textFakultas
        '
        Me.textFakultas.AutoSize = True
        Me.textFakultas.Location = New System.Drawing.Point(468, 95)
        Me.textFakultas.Name = "textFakultas"
        Me.textFakultas.Size = New System.Drawing.Size(52, 13)
        Me.textFakultas.TabIndex = 12
        Me.textFakultas.Text = "%fakultas"
        '
        'textProdi
        '
        Me.textProdi.AutoSize = True
        Me.textProdi.Location = New System.Drawing.Point(468, 129)
        Me.textProdi.Name = "textProdi"
        Me.textProdi.Size = New System.Drawing.Size(38, 13)
        Me.textProdi.TabIndex = 13
        Me.textProdi.Text = "%prodi"
        '
        'textSemester
        '
        Me.textSemester.AutoSize = True
        Me.textSemester.Location = New System.Drawing.Point(468, 158)
        Me.textSemester.Name = "textSemester"
        Me.textSemester.Size = New System.Drawing.Size(57, 13)
        Me.textSemester.TabIndex = 14
        Me.textSemester.Text = "%semester"
        '
        'krsBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 489)
        Me.Controls.Add(Me.textSemester)
        Me.Controls.Add(Me.textProdi)
        Me.Controls.Add(Me.textFakultas)
        Me.Controls.Add(Me.textName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvKrs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputNIM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "krsBay"
        Me.Text = "krsBay"
        CType(Me.dgvKrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputNIM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvKrs As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textName As Label
    Friend WithEvents textFakultas As Label
    Friend WithEvents textProdi As Label
    Friend WithEvents textSemester As Label
End Class
