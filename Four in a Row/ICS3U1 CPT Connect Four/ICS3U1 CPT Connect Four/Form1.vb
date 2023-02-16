'Menu Form Code
Imports System.Media 'Allows sound to be played
Imports System.IO 'Allows application to read and write to files

Public Class MenuForm
    'Declares the themecolor as public color variable, and highscores array and highscoresnames array to meaning all forms can access
    Public themeColor As Color
    Public highScores() As Integer = {0, 0, 0, 0, 0}
    Public highScoresNames() As String = {"", "", "", "", ""}

    'Button event procedures below declare and open corresponding forms
    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        Dim gameForm As New GameForm()
        gameForm.ShowDialog()
    End Sub

    Private Sub btnTheme_Click(sender As System.Object, e As System.EventArgs) Handles btnTheme.Click
        Me.ThemeColorDialog.ShowDialog()
        themeColor = Me.ThemeColorDialog.Color
        Me.BackColor = themeColor
    End Sub

    Private Sub btnHighScores_Click(sender As System.Object, e As System.EventArgs) Handles btnHighScores.Click
        Dim highScores As New HighScores()
        highScores.ShowDialog()
    End Sub

    Private Sub btnInstructions_Click(sender As System.Object, e As System.EventArgs) Handles btnInstructions.Click
        Dim instructions As New InstructionsForm()
        instructions.ShowDialog()
    End Sub


    'Loads the highscore array an highscorenames array from the highscores.txt file
    Private Sub MenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim path As String = My.Application.Info.DirectoryPath
        Dim hfile As String = IO.Path.Combine(path, "HighScores.txt")
        Dim fs As New FileStream(hfile, FileMode.Open, FileAccess.Read)
        Dim highScoreFile As New StreamReader(fs)

        highScores(0) = Val(highScoreFile.ReadLine())
        highScoresNames(0) = highScoreFile.ReadLine()
        highScores(1) = Val(highScoreFile.ReadLine())
        highScoresNames(1) = highScoreFile.ReadLine()
        highScores(2) = Val(highScoreFile.ReadLine())
        highScoresNames(2) = highScoreFile.ReadLine()
        highScores(3) = Val(highScoreFile.ReadLine())
        highScoresNames(3) = highScoreFile.ReadLine()
        highScores(4) = Val(highScoreFile.ReadLine())
        highScoresNames(4) = highScoreFile.ReadLine()

        highScoreFile.Close()
    End Sub
End Class


