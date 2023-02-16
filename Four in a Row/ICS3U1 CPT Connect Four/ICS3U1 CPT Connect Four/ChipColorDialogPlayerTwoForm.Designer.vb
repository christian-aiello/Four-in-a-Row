<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChipColorDialogPlayerTwoForm
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
        Me.radPurpleChip = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.radBlueChip = New System.Windows.Forms.RadioButton()
        Me.radTealChip = New System.Windows.Forms.RadioButton()
        Me.radYellowChip = New System.Windows.Forms.RadioButton()
        Me.grpChipColor = New System.Windows.Forms.GroupBox()
        Me.radOrangeChip = New System.Windows.Forms.RadioButton()
        Me.radRedChip = New System.Windows.Forms.RadioButton()
        Me.radWhiteChip = New System.Windows.Forms.RadioButton()
        Me.radBlackChip = New System.Windows.Forms.RadioButton()
        Me.grpChipColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'radPurpleChip
        '
        Me.radPurpleChip.AutoSize = True
        Me.radPurpleChip.Location = New System.Drawing.Point(10, 135)
        Me.radPurpleChip.Name = "radPurpleChip"
        Me.radPurpleChip.Size = New System.Drawing.Size(61, 17)
        Me.radPurpleChip.TabIndex = 5
        Me.radPurpleChip.TabStop = True
        Me.radPurpleChip.Text = "Purple"
        Me.radPurpleChip.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(37, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(37, 225)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(200, 23)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'radBlueChip
        '
        Me.radBlueChip.AutoSize = True
        Me.radBlueChip.Location = New System.Drawing.Point(10, 112)
        Me.radBlueChip.Name = "radBlueChip"
        Me.radBlueChip.Size = New System.Drawing.Size(50, 17)
        Me.radBlueChip.TabIndex = 4
        Me.radBlueChip.TabStop = True
        Me.radBlueChip.Text = "Blue"
        Me.radBlueChip.UseVisualStyleBackColor = True
        '
        'radTealChip
        '
        Me.radTealChip.AutoSize = True
        Me.radTealChip.Location = New System.Drawing.Point(10, 89)
        Me.radTealChip.Name = "radTealChip"
        Me.radTealChip.Size = New System.Drawing.Size(50, 17)
        Me.radTealChip.TabIndex = 3
        Me.radTealChip.TabStop = True
        Me.radTealChip.Text = "Teal"
        Me.radTealChip.UseVisualStyleBackColor = True
        '
        'radYellowChip
        '
        Me.radYellowChip.AutoSize = True
        Me.radYellowChip.Location = New System.Drawing.Point(10, 66)
        Me.radYellowChip.Name = "radYellowChip"
        Me.radYellowChip.Size = New System.Drawing.Size(62, 17)
        Me.radYellowChip.TabIndex = 2
        Me.radYellowChip.TabStop = True
        Me.radYellowChip.Text = "Yellow"
        Me.radYellowChip.UseVisualStyleBackColor = True
        '
        'grpChipColor
        '
        Me.grpChipColor.Controls.Add(Me.radBlackChip)
        Me.grpChipColor.Controls.Add(Me.radWhiteChip)
        Me.grpChipColor.Controls.Add(Me.radPurpleChip)
        Me.grpChipColor.Controls.Add(Me.radBlueChip)
        Me.grpChipColor.Controls.Add(Me.radTealChip)
        Me.grpChipColor.Controls.Add(Me.radYellowChip)
        Me.grpChipColor.Controls.Add(Me.radOrangeChip)
        Me.grpChipColor.Controls.Add(Me.radRedChip)
        Me.grpChipColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChipColor.ForeColor = System.Drawing.Color.White
        Me.grpChipColor.Location = New System.Drawing.Point(12, 5)
        Me.grpChipColor.Name = "grpChipColor"
        Me.grpChipColor.Size = New System.Drawing.Size(250, 214)
        Me.grpChipColor.TabIndex = 9
        Me.grpChipColor.TabStop = False
        Me.grpChipColor.Text = "Player 2, choose your chip color:"
        '
        'radOrangeChip
        '
        Me.radOrangeChip.AutoSize = True
        Me.radOrangeChip.Location = New System.Drawing.Point(10, 43)
        Me.radOrangeChip.Name = "radOrangeChip"
        Me.radOrangeChip.Size = New System.Drawing.Size(66, 17)
        Me.radOrangeChip.TabIndex = 1
        Me.radOrangeChip.TabStop = True
        Me.radOrangeChip.Text = "Orange"
        Me.radOrangeChip.UseVisualStyleBackColor = True
        '
        'radRedChip
        '
        Me.radRedChip.AutoSize = True
        Me.radRedChip.Location = New System.Drawing.Point(10, 20)
        Me.radRedChip.Name = "radRedChip"
        Me.radRedChip.Size = New System.Drawing.Size(48, 17)
        Me.radRedChip.TabIndex = 0
        Me.radRedChip.TabStop = True
        Me.radRedChip.Text = "Red"
        Me.radRedChip.UseVisualStyleBackColor = True
        '
        'radWhiteChip
        '
        Me.radWhiteChip.AutoSize = True
        Me.radWhiteChip.Location = New System.Drawing.Point(10, 158)
        Me.radWhiteChip.Name = "radWhiteChip"
        Me.radWhiteChip.Size = New System.Drawing.Size(58, 17)
        Me.radWhiteChip.TabIndex = 6
        Me.radWhiteChip.TabStop = True
        Me.radWhiteChip.Text = "White"
        Me.radWhiteChip.UseVisualStyleBackColor = True
        '
        'radBlackChip
        '
        Me.radBlackChip.AutoSize = True
        Me.radBlackChip.Location = New System.Drawing.Point(10, 181)
        Me.radBlackChip.Name = "radBlackChip"
        Me.radBlackChip.Size = New System.Drawing.Size(57, 17)
        Me.radBlackChip.TabIndex = 7
        Me.radBlackChip.TabStop = True
        Me.radBlackChip.Text = "Black"
        Me.radBlackChip.UseVisualStyleBackColor = True
        '
        'ChipColorDialogPlayerTwoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(274, 289)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpChipColor)
        Me.Name = "ChipColorDialogPlayerTwoForm"
        Me.Text = "Chip Color Player 2"
        Me.grpChipColor.ResumeLayout(False)
        Me.grpChipColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radPurpleChip As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents radBlueChip As System.Windows.Forms.RadioButton
    Friend WithEvents radTealChip As System.Windows.Forms.RadioButton
    Friend WithEvents radYellowChip As System.Windows.Forms.RadioButton
    Friend WithEvents grpChipColor As System.Windows.Forms.GroupBox
    Friend WithEvents radOrangeChip As System.Windows.Forms.RadioButton
    Friend WithEvents radRedChip As System.Windows.Forms.RadioButton
    Friend WithEvents radBlackChip As System.Windows.Forms.RadioButton
    Friend WithEvents radWhiteChip As System.Windows.Forms.RadioButton
End Class
