<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardAdmin
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMhs = New System.Windows.Forms.Button()
        Me.btnMK = New System.Windows.Forms.Button()
        Me.btnDosen = New System.Windows.Forms.Button()
        Me.btnKRS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(13, 13)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(169, 24)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome , %name"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(540, 16)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMhs
        '
        Me.btnMhs.Location = New System.Drawing.Point(17, 128)
        Me.btnMhs.Name = "btnMhs"
        Me.btnMhs.Size = New System.Drawing.Size(141, 103)
        Me.btnMhs.TabIndex = 2
        Me.btnMhs.Text = "Mahasiswa"
        Me.btnMhs.UseVisualStyleBackColor = True
        '
        'btnMK
        '
        Me.btnMK.Location = New System.Drawing.Point(164, 128)
        Me.btnMK.Name = "btnMK"
        Me.btnMK.Size = New System.Drawing.Size(141, 103)
        Me.btnMK.TabIndex = 3
        Me.btnMK.Text = "Mata Kuliah"
        Me.btnMK.UseVisualStyleBackColor = True
        '
        'btnDosen
        '
        Me.btnDosen.Location = New System.Drawing.Point(311, 128)
        Me.btnDosen.Name = "btnDosen"
        Me.btnDosen.Size = New System.Drawing.Size(141, 103)
        Me.btnDosen.TabIndex = 4
        Me.btnDosen.Text = "Dosen"
        Me.btnDosen.UseVisualStyleBackColor = True
        '
        'btnKRS
        '
        Me.btnKRS.Location = New System.Drawing.Point(458, 128)
        Me.btnKRS.Name = "btnKRS"
        Me.btnKRS.Size = New System.Drawing.Size(141, 103)
        Me.btnKRS.TabIndex = 5
        Me.btnKRS.Text = "KRS"
        Me.btnKRS.UseVisualStyleBackColor = True
        '
        'dashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 258)
        Me.Controls.Add(Me.btnKRS)
        Me.Controls.Add(Me.btnDosen)
        Me.Controls.Add(Me.btnMK)
        Me.Controls.Add(Me.btnMhs)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "dashboardAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMhs As Button
    Friend WithEvents btnMK As Button
    Friend WithEvents btnDosen As Button
    Friend WithEvents btnKRS As Button
End Class
