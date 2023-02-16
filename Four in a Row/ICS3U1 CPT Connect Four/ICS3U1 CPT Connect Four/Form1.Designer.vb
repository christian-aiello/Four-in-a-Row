<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.lblConnnectFour = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnTheme = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.ThemeColorDialog = New System.Windows.Forms.ColorDialog()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConnnectFour
        '
        Me.lblConnnectFour.AutoSize = True
        Me.lblConnnectFour.Font = New System.Drawing.Font("Microsoft YaHei", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnnectFour.ForeColor = System.Drawing.Color.White
        Me.lblConnnectFour.Location = New System.Drawing.Point(148, 55)
        Me.lblConnnectFour.Name = "lblConnnectFour"
        Me.lblConnnectFour.Size = New System.Drawing.Size(566, 86)
        Me.lblConnnectFour.TabIndex = 0
        Me.lblConnnectFour.Text = "FOUR IN A ROW"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlay.FlatAppearance.BorderSize = 5
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(274, 147)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(300, 75)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnTheme
        '
        Me.btnTheme.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnTheme.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnTheme.FlatAppearance.BorderSize = 5
        Me.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTheme.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTheme.ForeColor = System.Drawing.Color.White
        Me.btnTheme.Location = New System.Drawing.Point(274, 228)
        Me.btnTheme.Name = "btnTheme"
        Me.btnTheme.Size = New System.Drawing.Size(300, 75)
        Me.btnTheme.TabIndex = 2
        Me.btnTheme.Text = "CHANGE THEME"
        Me.btnTheme.UseVisualStyleBackColor = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnInstructions.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInstructions.FlatAppearance.BorderSize = 5
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.White
        Me.btnInstructions.Location = New System.Drawing.Point(274, 390)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(300, 75)
        Me.btnInstructions.TabIndex = 3
        Me.btnInstructions.Text = "INSTRUCTIONS"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'btnHighScores
        '
        Me.btnHighScores.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnHighScores.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnHighScores.FlatAppearance.BorderSize = 5
        Me.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighScores.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.ForeColor = System.Drawing.Color.White
        Me.btnHighScores.Location = New System.Drawing.Point(274, 309)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(300, 75)
        Me.btnHighScores.TabIndex = 5
        Me.btnHighScores.Text = "HIGH SCORES"
        Me.btnHighScores.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(836, 521)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnTheme)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblConnnectFour)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConnnectFour As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnTheme As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents ThemeColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents btnHighScores As System.Windows.Forms.Button

End Class
