<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOptionsDialogBoxForm
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
        Me.grpChipColor = New System.Windows.Forms.GroupBox()
        Me.radCustomColorChips = New System.Windows.Forms.RadioButton()
        Me.radDefaultColorChips = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpRounds = New System.Windows.Forms.GroupBox()
        Me.rad9round = New System.Windows.Forms.RadioButton()
        Me.rad7round = New System.Windows.Forms.RadioButton()
        Me.rad5round = New System.Windows.Forms.RadioButton()
        Me.rad3round = New System.Windows.Forms.RadioButton()
        Me.rad1round = New System.Windows.Forms.RadioButton()
        Me.grpChipColor.SuspendLayout()
        Me.grpRounds.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChipColor
        '
        Me.grpChipColor.Controls.Add(Me.radCustomColorChips)
        Me.grpChipColor.Controls.Add(Me.radDefaultColorChips)
        Me.grpChipColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChipColor.ForeColor = System.Drawing.Color.White
        Me.grpChipColor.Location = New System.Drawing.Point(38, 12)
        Me.grpChipColor.Name = "grpChipColor"
        Me.grpChipColor.Size = New System.Drawing.Size(200, 74)
        Me.grpChipColor.TabIndex = 4
        Me.grpChipColor.TabStop = False
        Me.grpChipColor.Text = "Select Chip Type:"
        '
        'radCustomColorChips
        '
        Me.radCustomColorChips.AutoSize = True
        Me.radCustomColorChips.Location = New System.Drawing.Point(10, 43)
        Me.radCustomColorChips.Name = "radCustomColorChips"
        Me.radCustomColorChips.Size = New System.Drawing.Size(105, 17)
        Me.radCustomColorChips.TabIndex = 1
        Me.radCustomColorChips.Text = "Custom Colors"
        Me.radCustomColorChips.UseVisualStyleBackColor = True
        '
        'radDefaultColorChips
        '
        Me.radDefaultColorChips.AutoSize = True
        Me.radDefaultColorChips.Checked = True
        Me.radDefaultColorChips.Location = New System.Drawing.Point(10, 20)
        Me.radDefaultColorChips.Name = "radDefaultColorChips"
        Me.radDefaultColorChips.Size = New System.Drawing.Size(109, 17)
        Me.radDefaultColorChips.TabIndex = 0
        Me.radDefaultColorChips.TabStop = True
        Me.radDefaultColorChips.Text = "Default Colors "
        Me.radDefaultColorChips.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(38, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(38, 232)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(200, 23)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpRounds
        '
        Me.grpRounds.Controls.Add(Me.rad9round)
        Me.grpRounds.Controls.Add(Me.rad7round)
        Me.grpRounds.Controls.Add(Me.rad5round)
        Me.grpRounds.Controls.Add(Me.rad3round)
        Me.grpRounds.Controls.Add(Me.rad1round)
        Me.grpRounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRounds.ForeColor = System.Drawing.Color.White
        Me.grpRounds.Location = New System.Drawing.Point(38, 86)
        Me.grpRounds.Name = "grpRounds"
        Me.grpRounds.Size = New System.Drawing.Size(200, 140)
        Me.grpRounds.TabIndex = 8
        Me.grpRounds.TabStop = False
        Me.grpRounds.Text = "Select Number Of Rounds"
        '
        'rad9round
        '
        Me.rad9round.AutoSize = True
        Me.rad9round.Location = New System.Drawing.Point(10, 112)
        Me.rad9round.Name = "rad9round"
        Me.rad9round.Size = New System.Drawing.Size(32, 17)
        Me.rad9round.TabIndex = 4
        Me.rad9round.Text = "9"
        Me.rad9round.UseVisualStyleBackColor = True
        '
        'rad7round
        '
        Me.rad7round.AutoSize = True
        Me.rad7round.Location = New System.Drawing.Point(10, 89)
        Me.rad7round.Name = "rad7round"
        Me.rad7round.Size = New System.Drawing.Size(32, 17)
        Me.rad7round.TabIndex = 3
        Me.rad7round.Text = "7"
        Me.rad7round.UseVisualStyleBackColor = True
        '
        'rad5round
        '
        Me.rad5round.AutoSize = True
        Me.rad5round.Location = New System.Drawing.Point(10, 66)
        Me.rad5round.Name = "rad5round"
        Me.rad5round.Size = New System.Drawing.Size(32, 17)
        Me.rad5round.TabIndex = 2
        Me.rad5round.Text = "5"
        Me.rad5round.UseVisualStyleBackColor = True
        '
        'rad3round
        '
        Me.rad3round.AutoSize = True
        Me.rad3round.Location = New System.Drawing.Point(10, 43)
        Me.rad3round.Name = "rad3round"
        Me.rad3round.Size = New System.Drawing.Size(32, 17)
        Me.rad3round.TabIndex = 1
        Me.rad3round.Text = "3"
        Me.rad3round.UseVisualStyleBackColor = True
        '
        'rad1round
        '
        Me.rad1round.AutoSize = True
        Me.rad1round.Checked = True
        Me.rad1round.Location = New System.Drawing.Point(10, 20)
        Me.rad1round.Name = "rad1round"
        Me.rad1round.Size = New System.Drawing.Size(32, 17)
        Me.rad1round.TabIndex = 0
        Me.rad1round.TabStop = True
        Me.rad1round.Text = "1"
        Me.rad1round.UseVisualStyleBackColor = True
        '
        'GameOptionsDialogBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(274, 295)
        Me.Controls.Add(Me.grpRounds)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpChipColor)
        Me.Name = "GameOptionsDialogBoxForm"
        Me.Text = "Options"
        Me.grpChipColor.ResumeLayout(False)
        Me.grpChipColor.PerformLayout()
        Me.grpRounds.ResumeLayout(False)
        Me.grpRounds.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpChipColor As System.Windows.Forms.GroupBox
    Friend WithEvents radCustomColorChips As System.Windows.Forms.RadioButton
    Friend WithEvents radDefaultColorChips As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpRounds As System.Windows.Forms.GroupBox
    Friend WithEvents rad9round As System.Windows.Forms.RadioButton
    Friend WithEvents rad7round As System.Windows.Forms.RadioButton
    Friend WithEvents rad5round As System.Windows.Forms.RadioButton
    Friend WithEvents rad3round As System.Windows.Forms.RadioButton
    Friend WithEvents rad1round As System.Windows.Forms.RadioButton
End Class
