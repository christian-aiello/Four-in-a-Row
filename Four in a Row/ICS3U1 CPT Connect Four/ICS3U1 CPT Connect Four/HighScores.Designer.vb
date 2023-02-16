<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.lblHighScoresAre = New System.Windows.Forms.Label()
        Me.lblRank1 = New System.Windows.Forms.Label()
        Me.lblRank2 = New System.Windows.Forms.Label()
        Me.lblRank3 = New System.Windows.Forms.Label()
        Me.lblRank4 = New System.Windows.Forms.Label()
        Me.lblRank5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHighScoresAre
        '
        Me.lblHighScoresAre.AutoSize = True
        Me.lblHighScoresAre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblHighScoresAre.ForeColor = System.Drawing.Color.White
        Me.lblHighScoresAre.Location = New System.Drawing.Point(12, 9)
        Me.lblHighScoresAre.Name = "lblHighScoresAre"
        Me.lblHighScoresAre.Size = New System.Drawing.Size(76, 13)
        Me.lblHighScoresAre.TabIndex = 0
        Me.lblHighScoresAre.Text = "High Scores"
        '
        'lblRank1
        '
        Me.lblRank1.AutoSize = True
        Me.lblRank1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRank1.ForeColor = System.Drawing.Color.White
        Me.lblRank1.Location = New System.Drawing.Point(34, 33)
        Me.lblRank1.Name = "lblRank1"
        Me.lblRank1.Size = New System.Drawing.Size(14, 13)
        Me.lblRank1.TabIndex = 1
        Me.lblRank1.Text = "1"
        '
        'lblRank2
        '
        Me.lblRank2.AutoSize = True
        Me.lblRank2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRank2.ForeColor = System.Drawing.Color.White
        Me.lblRank2.Location = New System.Drawing.Point(34, 55)
        Me.lblRank2.Name = "lblRank2"
        Me.lblRank2.Size = New System.Drawing.Size(14, 13)
        Me.lblRank2.TabIndex = 2
        Me.lblRank2.Text = "2"
        '
        'lblRank3
        '
        Me.lblRank3.AutoSize = True
        Me.lblRank3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRank3.ForeColor = System.Drawing.Color.White
        Me.lblRank3.Location = New System.Drawing.Point(34, 77)
        Me.lblRank3.Name = "lblRank3"
        Me.lblRank3.Size = New System.Drawing.Size(14, 13)
        Me.lblRank3.TabIndex = 3
        Me.lblRank3.Text = "3"
        '
        'lblRank4
        '
        Me.lblRank4.AutoSize = True
        Me.lblRank4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRank4.ForeColor = System.Drawing.Color.White
        Me.lblRank4.Location = New System.Drawing.Point(34, 99)
        Me.lblRank4.Name = "lblRank4"
        Me.lblRank4.Size = New System.Drawing.Size(14, 13)
        Me.lblRank4.TabIndex = 4
        Me.lblRank4.Text = "4"
        '
        'lblRank5
        '
        Me.lblRank5.AutoSize = True
        Me.lblRank5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblRank5.ForeColor = System.Drawing.Color.White
        Me.lblRank5.Location = New System.Drawing.Point(34, 122)
        Me.lblRank5.Name = "lblRank5"
        Me.lblRank5.Size = New System.Drawing.Size(14, 13)
        Me.lblRank5.TabIndex = 5
        Me.lblRank5.Text = "5"
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(274, 156)
        Me.Controls.Add(Me.lblRank5)
        Me.Controls.Add(Me.lblRank4)
        Me.Controls.Add(Me.lblRank3)
        Me.Controls.Add(Me.lblRank2)
        Me.Controls.Add(Me.lblRank1)
        Me.Controls.Add(Me.lblHighScoresAre)
        Me.Name = "HighScores"
        Me.Text = "High Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHighScoresAre As System.Windows.Forms.Label
    Friend WithEvents lblRank1 As System.Windows.Forms.Label
    Friend WithEvents lblRank2 As System.Windows.Forms.Label
    Friend WithEvents lblRank3 As System.Windows.Forms.Label
    Friend WithEvents lblRank4 As System.Windows.Forms.Label
    Friend WithEvents lblRank5 As System.Windows.Forms.Label
End Class
