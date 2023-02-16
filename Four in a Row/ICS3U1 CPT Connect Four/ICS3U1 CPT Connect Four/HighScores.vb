'Highscores Form Code
Public Class HighScores
    'Shows highscore by assigning labels scores and names from the highscores and highscoresnames arrays
    Private Sub HighScores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblRank1.Text = "1. " & MenuForm.highScores(0) & " - " & MenuForm.highScoresNames(0)
        Me.lblRank2.Text = "2. " & MenuForm.highScores(1) & " - " & MenuForm.highScoresNames(1)
        Me.lblRank3.Text = "3. " & MenuForm.highScores(2) & " - " & MenuForm.highScoresNames(2)
        Me.lblRank4.Text = "4. " & MenuForm.highScores(3) & " - " & MenuForm.highScoresNames(3)
        Me.lblRank5.Text = "5. " & MenuForm.highScores(4) & " - " & MenuForm.highScoresNames(4)
    End Sub
End Class