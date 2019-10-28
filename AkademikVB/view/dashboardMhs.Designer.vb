<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardMhs
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
        Me.btnShowKRS = New System.Windows.Forms.Button()
        Me.btnCreateKRS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(13, 13)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(243, 36)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome , 春宮さ"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(713, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnShowKRS
        '
        Me.btnShowKRS.Location = New System.Drawing.Point(484, 154)
        Me.btnShowKRS.Name = "btnShowKRS"
        Me.btnShowKRS.Size = New System.Drawing.Size(151, 148)
        Me.btnShowKRS.TabIndex = 6
        Me.btnShowKRS.Text = "Lihat KRS"
        Me.btnShowKRS.UseVisualStyleBackColor = True
        '
        'btnCreateKRS
        '
        Me.btnCreateKRS.Location = New System.Drawing.Point(150, 154)
        Me.btnCreateKRS.Name = "btnCreateKRS"
        Me.btnCreateKRS.Size = New System.Drawing.Size(151, 148)
        Me.btnCreateKRS.TabIndex = 5
        Me.btnCreateKRS.Text = "Buat KRS"
        Me.btnCreateKRS.UseVisualStyleBackColor = True
        '
        'dashboardMhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShowKRS)
        Me.Controls.Add(Me.btnCreateKRS)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.MaximizeBox = False
        Me.Name = "dashboardMhs"
        Me.Text = "Dashboard Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCreateKRS As Button
    Friend WithEvents btnShowKRS As Button
End Class
