<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.rbMhs = New System.Windows.Forms.RadioButton()
        Me.rbDsn = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'userText
        '
        Me.userText.Location = New System.Drawing.Point(16, 44)
        Me.userText.Name = "userText"
        Me.userText.Size = New System.Drawing.Size(226, 20)
        Me.userText.TabIndex = 2
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(16, 103)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(226, 20)
        Me.passwordText.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(167, 157)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'rbMhs
        '
        Me.rbMhs.AutoSize = True
        Me.rbMhs.Checked = True
        Me.rbMhs.Location = New System.Drawing.Point(6, 19)
        Me.rbMhs.Name = "rbMhs"
        Me.rbMhs.Size = New System.Drawing.Size(78, 17)
        Me.rbMhs.TabIndex = 7
        Me.rbMhs.TabStop = True
        Me.rbMhs.Text = "Mahasiswa"
        Me.rbMhs.UseVisualStyleBackColor = True
        '
        'rbDsn
        '
        Me.rbDsn.AutoSize = True
        Me.rbDsn.Location = New System.Drawing.Point(6, 42)
        Me.rbDsn.Name = "rbDsn"
        Me.rbDsn.Size = New System.Drawing.Size(56, 17)
        Me.rbDsn.TabIndex = 8
        Me.rbDsn.Text = "Dosen"
        Me.rbDsn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(13, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "大学校のシステム"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMhs)
        Me.GroupBox1.Controls.Add(Me.rbDsn)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 72)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sebagai :"
        '
        'loginScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 229)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.userText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "loginScreen"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents rbMhs As RadioButton
    Friend WithEvents rbDsn As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
