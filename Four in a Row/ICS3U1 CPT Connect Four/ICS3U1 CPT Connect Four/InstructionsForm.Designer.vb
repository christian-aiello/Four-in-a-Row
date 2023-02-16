<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructionsForm
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
        Me.lblInstructions1 = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        Me.lblInstructions3 = New System.Windows.Forms.Label()
        Me.lblInstructions4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstructions1
        '
        Me.lblInstructions1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions1.ForeColor = System.Drawing.Color.White
        Me.lblInstructions1.Location = New System.Drawing.Point(23, 21)
        Me.lblInstructions1.Name = "lblInstructions1"
        Me.lblInstructions1.Size = New System.Drawing.Size(260, 54)
        Me.lblInstructions1.TabIndex = 1
        Me.lblInstructions1.Text = "1. At the beginnng of each game, each player will be prompted to select their chi" & _
    "p color, and the number of rounds can be selected."
        '
        'lblInstructions2
        '
        Me.lblInstructions2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions2.ForeColor = System.Drawing.Color.White
        Me.lblInstructions2.Location = New System.Drawing.Point(23, 92)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(260, 43)
        Me.lblInstructions2.TabIndex = 2
        Me.lblInstructions2.Text = "2. Starting with player 1, the players take turns dropping chips in the board usi" & _
    "ng the buttons on top."
        '
        'lblInstructions3
        '
        Me.lblInstructions3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions3.ForeColor = System.Drawing.Color.White
        Me.lblInstructions3.Location = New System.Drawing.Point(23, 152)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(260, 43)
        Me.lblInstructions3.TabIndex = 3
        Me.lblInstructions3.Text = "3. The first player to get four chips in a row either vertically, horzontally, or" & _
    " diagonally wins the game."
        '
        'lblInstructions4
        '
        Me.lblInstructions4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions4.ForeColor = System.Drawing.Color.White
        Me.lblInstructions4.Location = New System.Drawing.Point(23, 212)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(260, 43)
        Me.lblInstructions4.TabIndex = 4
        Me.lblInstructions4.Text = "4. The player to win the most rounds wins the game, and will be given a score bas" & _
    "ed on how well they played."
        '
        'InstructionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(307, 276)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions1)
        Me.Name = "InstructionsForm"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInstructions1 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions2 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions3 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions4 As System.Windows.Forms.Label
End Class
