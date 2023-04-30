<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftball
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
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.lstSoftball = New System.Windows.Forms.ListBox()
        Me.btnSoftball = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuFitness.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFitness
        '
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuClear, Me.mnuExit})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(800, 24)
        Me.mnuFitness.TabIndex = 11
        Me.mnuFitness.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(46, 20)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.BackColor = System.Drawing.Color.White
        Me.lblFinalScore.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.ForeColor = System.Drawing.Color.Red
        Me.lblFinalScore.Location = New System.Drawing.Point(14, 266)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(311, 29)
        Me.lblFinalScore.TabIndex = 15
        Me.lblFinalScore.Text = "The final score is XX runs"
        Me.lblFinalScore.Visible = False
        '
        'lstSoftball
        '
        Me.lstSoftball.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSoftball.ForeColor = System.Drawing.Color.Red
        Me.lstSoftball.FormattingEnabled = True
        Me.lstSoftball.ItemHeight = 23
        Me.lstSoftball.Location = New System.Drawing.Point(527, 119)
        Me.lstSoftball.Name = "lstSoftball"
        Me.lstSoftball.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSoftball.Size = New System.Drawing.Size(50, 188)
        Me.lstSoftball.TabIndex = 14
        '
        'btnSoftball
        '
        Me.btnSoftball.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSoftball.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftball.Location = New System.Drawing.Point(62, 172)
        Me.btnSoftball.Name = "btnSoftball"
        Me.btnSoftball.Size = New System.Drawing.Size(207, 38)
        Me.btnSoftball.TabIndex = 13
        Me.btnSoftball.Text = "Enter Score"
        Me.btnSoftball.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(12, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(365, 42)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Softball Scoreboard"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSoftball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BulmerCh6CPA3.My.Resources.Resources._6210162ad5e83_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuFitness)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lstSoftball)
        Me.Controls.Add(Me.btnSoftball)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSoftball"
        Me.Text = "Softball Scoreboard"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFitness As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents lstSoftball As ListBox
    Friend WithEvents btnSoftball As Button
    Friend WithEvents lblTitle As Label
End Class
