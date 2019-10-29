<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createKRS
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
        Me.lblKrsInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvAvail = New System.Windows.Forms.DataGridView()
        Me.dgvPicked = New System.Windows.Forms.DataGridView()
        Me.btnApplyKrs = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvAvail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPicked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKrsInfo
        '
        Me.lblKrsInfo.AutoSize = True
        Me.lblKrsInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblKrsInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblKrsInfo.Name = "lblKrsInfo"
        Me.lblKrsInfo.Size = New System.Drawing.Size(86, 39)
        Me.lblKrsInfo.TabIndex = 0
        Me.lblKrsInfo.Text = "AAA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Available Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Picked Course"
        '
        'dgvAvail
        '
        Me.dgvAvail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAvail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvail.Location = New System.Drawing.Point(22, 80)
        Me.dgvAvail.Name = "dgvAvail"
        Me.dgvAvail.Size = New System.Drawing.Size(766, 160)
        Me.dgvAvail.TabIndex = 3
        '
        'dgvPicked
        '
        Me.dgvPicked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPicked.Location = New System.Drawing.Point(22, 280)
        Me.dgvPicked.Name = "dgvPicked"
        Me.dgvPicked.Size = New System.Drawing.Size(766, 160)
        Me.dgvPicked.TabIndex = 4
        '
        'btnApplyKrs
        '
        Me.btnApplyKrs.Location = New System.Drawing.Point(692, 446)
        Me.btnApplyKrs.Name = "btnApplyKrs"
        Me.btnApplyKrs.Size = New System.Drawing.Size(96, 28)
        Me.btnApplyKrs.TabIndex = 5
        Me.btnApplyKrs.Text = "Apply KRS"
        Me.btnApplyKrs.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(713, 51)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'createKRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnApplyKrs)
        Me.Controls.Add(Me.dgvPicked)
        Me.Controls.Add(Me.dgvAvail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKrsInfo)
        Me.MaximizeBox = False
        Me.Name = "createKRS"
        Me.Text = "Mari buat KRS!"
        CType(Me.dgvAvail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPicked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKrsInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvAvail As DataGridView
    Friend WithEvents dgvPicked As DataGridView
    Friend WithEvents btnApplyKrs As Button
    Friend WithEvents btnRefresh As Button
End Class
