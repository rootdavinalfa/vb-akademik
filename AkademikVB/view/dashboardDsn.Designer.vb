<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardDsn
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
        Me.btnShowMK = New System.Windows.Forms.Button()
        Me.btnShowMahasiswa = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowMK
        '
        Me.btnShowMK.Location = New System.Drawing.Point(484, 156)
        Me.btnShowMK.Name = "btnShowMK"
        Me.btnShowMK.Size = New System.Drawing.Size(151, 148)
        Me.btnShowMK.TabIndex = 10
        Me.btnShowMK.Text = "Lihat MK"
        Me.btnShowMK.UseVisualStyleBackColor = True
        '
        'btnShowMahasiswa
        '
        Me.btnShowMahasiswa.Location = New System.Drawing.Point(150, 156)
        Me.btnShowMahasiswa.Name = "btnShowMahasiswa"
        Me.btnShowMahasiswa.Size = New System.Drawing.Size(151, 148)
        Me.btnShowMahasiswa.TabIndex = 9
        Me.btnShowMahasiswa.Text = "Lihat Mahasiswa"
        Me.btnShowMahasiswa.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(713, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(13, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(243, 36)
        Me.lblWelcome.TabIndex = 7
        Me.lblWelcome.Text = "Welcome , 春宮さ"
        '
        'dashboardDsn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowMK)
        Me.Controls.Add(Me.btnShowMahasiswa)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximizeBox = False
        Me.Name = "dashboardDsn"
        Me.Text = "Dashboard Dosen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowMK As Button
    Friend WithEvents btnShowMahasiswa As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
End Class
