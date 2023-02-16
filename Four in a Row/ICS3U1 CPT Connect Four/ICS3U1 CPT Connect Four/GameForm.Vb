
Imports System.Media 'Allows sound to be played
Imports System.IO 'Allows application to read and write to files

Public Class GameForm
    Dim player As Integer = 1 'Declares player to keep track of which players turn it currently is
    Dim playerOneChipImage As Image 'Declares image variables storing what players chips and chips in a connect four look like
    Dim playerTwoChipImage As Image
    Dim playerOneChipImageWin As Image
    Dim playerTwoChipImageWin As Image
    Dim playerOneWins As Integer 'Declares variable storing the number of wins each player has in a series of round
    Dim playerTwoWins As Integer
    Dim playerOneConnectFours As Integer 'Declares variables storing the total connect fours each player has made and total points variable for scoring
    Dim playerTwoConnectFours As Integer
    Dim playerOneTotalPoints As Integer
    Dim playerTwoTotalPoints As Integer
    Dim finalScore As Integer 'Declares variable storing the final score of the winner
    Dim rounds As Integer 'Declares rounds storing how many round played for calculated variable
    Dim themeColor As Color 'Declares theme color variable storing the theme color
    Dim path As String = My.Application.Info.DirectoryPath
    Dim hfile As String = IO.Path.Combine(path, "HighScores.txt")

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Makes sure all color options for color dialog form color radiobuttons are visible
        ChipColorDialogPlayerTwoForm.radRedChip.Visible = True
        ChipColorDialogPlayerTwoForm.radOrangeChip.Visible = True
        ChipColorDialogPlayerTwoForm.radYellowChip.Visible = True
        ChipColorDialogPlayerTwoForm.radTealChip.Visible = True
        ChipColorDialogPlayerTwoForm.radBlueChip.Visible = True
        ChipColorDialogPlayerTwoForm.radPurpleChip.Visible = True
        ChipColorDialogPlayerTwoForm.radWhiteChip.Visible = True
        ChipColorDialogPlayerTwoForm.radBlackChip.Visible = True

        'Changes theme color of form to dark blue if the user doesn't select a theme color and
        'assigns the theme color to the background of all buttons (boardspaces) to the theme color
        If MenuForm.themeColor = Nothing Then
            themeColor = Color.DarkBlue
        Else
            themeColor = MenuForm.themeColor
        End If

        Me.BackColor = themeColor
        For row As Integer = 0 To 5
            For column As Integer = 0 To 6
                GetButtonFromRowAndColumn(row, column).BackColor = themeColor
            Next
        Next

        'Declares and opens the game options window to ask user for game options
        Dim gameOptions As New GameOptionsDialogBoxForm()
        Do
            GameOptionsDialogBoxForm.ShowDialog()
        Loop While GameOptionsDialogBoxForm.DialogResult = Windows.Forms.DialogResult.Cancel

        'Checks to see if the user pressed OK on the game options form
        If GameOptionsDialogBoxForm.DialogResult = Windows.Forms.DialogResult.OK Then

            'Assigns player one and two's chip/chipwin images as red and yellow if default chip colors are selected
            If GameOptionsDialogBoxForm.radDefaultColorChips.Checked Then
                playerOneChipImage = My.Resources.YellowChip
                playerOneChipImageWin = My.Resources.YellowChipWin
                playerTwoChipImage = My.Resources.RedChip
                playerTwoChipImageWin = My.Resources.RedChipWin
            ElseIf GameOptionsDialogBoxForm.radCustomColorChips.Checked Then

                'Otherwise, a form is delcared and opened asking both player one and player two for their chip color
                'After, it will assign player one and two's chip/chipwin images corresponding to the color they picked to ensure the same color is not chosen
                'The color first player picked will have its options made invisible in the second form
                'The forms also keeps opening if they press cancel
                Dim chipColorPlayerOne As New ChipColorDialogPlayerOneForm()

                Do
                    ChipColorDialogPlayerOneForm.ShowDialog()

                    If ChipColorDialogPlayerOneForm.DialogResult = Windows.Forms.DialogResult.OK Then
                        If ChipColorDialogPlayerOneForm.radRedChip.Checked Then
                            playerOneChipImage = My.Resources.RedChip
                            playerOneChipImageWin = My.Resources.RedChipWin
                            ChipColorDialogPlayerTwoForm.radRedChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radOrangeChip.Checked Then
                            playerOneChipImage = My.Resources.OrangeChip
                            playerOneChipImageWin = My.Resources.OrangeChipWin
                            ChipColorDialogPlayerTwoForm.radOrangeChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radYellowChip.Checked Then
                            playerOneChipImage = My.Resources.YellowChip
                            playerOneChipImageWin = My.Resources.YellowChipWin
                            ChipColorDialogPlayerTwoForm.radYellowChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radTealChip.Checked Then
                            playerOneChipImage = My.Resources.TealChip
                            playerOneChipImageWin = My.Resources.TealChipWin
                            ChipColorDialogPlayerTwoForm.radTealChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radBlueChip.Checked Then
                            playerOneChipImage = My.Resources.BlueChip
                            playerOneChipImageWin = My.Resources.BlueChipWin
                            ChipColorDialogPlayerTwoForm.radBlueChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radPurpleChip.Checked Then
                            playerOneChipImage = My.Resources.PurpleChip
                            playerOneChipImageWin = My.Resources.PurpleChipWin
                            ChipColorDialogPlayerTwoForm.radPurpleChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radWhiteChip.Checked Then
                            playerOneChipImage = My.Resources.WhiteChip
                            playerOneChipImageWin = My.Resources.WhiteChipWin
                            ChipColorDialogPlayerTwoForm.radWhiteChip.Visible = False
                        End If
                        If ChipColorDialogPlayerOneForm.radBlackChip.Checked Then
                            playerOneChipImage = My.Resources.BlackChip
                            playerOneChipImageWin = My.Resources.BlackChipWin
                            ChipColorDialogPlayerTwoForm.radBlackChip.Visible = False
                        End If
                    End If
                Loop While ChipColorDialogPlayerOneForm.DialogResult = Windows.Forms.DialogResult.Cancel

                Dim chipColorPlayerTwo As New ChipColorDialogPlayerTwoForm()
                Do
                    ChipColorDialogPlayerTwoForm.ShowDialog()

                    If ChipColorDialogPlayerTwoForm.DialogResult = Windows.Forms.DialogResult.OK Then
                        If ChipColorDialogPlayerTwoForm.radRedChip.Checked Then
                            playerTwoChipImage = My.Resources.RedChip
                            playerTwoChipImageWin = My.Resources.RedChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radOrangeChip.Checked Then
                            playerTwoChipImage = My.Resources.OrangeChip
                            playerTwoChipImageWin = My.Resources.OrangeChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radYellowChip.Checked Then
                            playerTwoChipImage = My.Resources.YellowChip
                            playerTwoChipImageWin = My.Resources.YellowChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radTealChip.Checked Then
                            playerTwoChipImage = My.Resources.TealChip
                            playerTwoChipImageWin = My.Resources.TealChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radBlueChip.Checked Then
                            playerTwoChipImage = My.Resources.BlueChip
                            playerTwoChipImageWin = My.Resources.BlueChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radPurpleChip.Checked Then
                            playerTwoChipImage = My.Resources.PurpleChip
                            playerTwoChipImageWin = My.Resources.PurpleChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radWhiteChip.Checked Then
                            playerTwoChipImage = My.Resources.WhiteChip
                            playerTwoChipImageWin = My.Resources.WhiteChipWin
                        End If
                        If ChipColorDialogPlayerTwoForm.radBlackChip.Checked Then
                            playerTwoChipImage = My.Resources.BlackChip
                            playerTwoChipImageWin = My.Resources.BlackChipWin
                        End If
                    End If
                Loop While ChipColorDialogPlayerTwoForm.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

            'Assigns the number of rounds the user picked to rounds variable
            If GameOptionsDialogBoxForm.rad1round.Checked Then
                rounds = 1
            ElseIf GameOptionsDialogBoxForm.rad3round.Checked Then
                rounds = 3
            ElseIf GameOptionsDialogBoxForm.rad5round.Checked Then
                rounds = 5
            ElseIf GameOptionsDialogBoxForm.rad7round.Checked Then
                rounds = 7
            ElseIf GameOptionsDialogBoxForm.rad9round.Checked Then
                rounds = 9
            End If
        End If
    End Sub

    Private Sub ChipRow_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click
        Dim chipColumnClicked As Button = sender 'Declares chipColumnClicked to keep track of what column the current player selected to drop their chip in
        Dim rowOfChipSpot As Integer 'Stores row of chip spot which is currently unknown but will use the IsValid function to calculate where the chip would drop to
        Dim columnOfChipSpot As Integer = Val((chipColumnClicked.Tag).Chars(0)) 'Finds the number of the chip column in the gameboard array from tag of button selected
        Static roundsPassed As Integer = 0 'Counter to count the number of rounds passed

        'Delcares gameBoard as a 6x7 two dimensional array storing the gameboard
        'Each spot contains either a 0, for no chip, 1 for player ones chip, or 2 for player 2's chip
        Static gameBoard(5, 6) As Integer

        'Uses IsValid function to find both if the column the user selects is valid to drop a chip in, and if so will receive the value of the row the chip will fall into
        If IsValid(gameBoard, rowOfChipSpot, columnOfChipSpot) Then
            'If valid move, the current player's number is entered in the array in the position of where the chip would fall after being put in the slot
            gameBoard(rowOfChipSpot, columnOfChipSpot) = player

            'Declares button variable storing the where the chip is placed by using getButton function with the row and column of the chip after being dropped in the column
            Dim chipSpot As Button = GetButtonFromRowAndColumn(rowOfChipSpot, columnOfChipSpot)

            'Changes the image of the chipSpot button to the players chip image, along with changing the background color to royalblue
            'Also changes the background of the chip drop in button they selected to the next players chip so for aestheic purposes 
            '(Recreates the user holding a chip over a slot before dropping in)
            If player = 1 Then
                chipSpot.Image = playerOneChipImage
                chipSpot.BackColor = Color.RoyalBlue
                chipSpot.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
                chipColumnClicked.Image = playerTwoChipImage
            Else
                chipSpot.Image = playerTwoChipImage
                chipSpot.BackColor = Color.RoyalBlue
                chipSpot.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
                chipColumnClicked.Image = playerOneChipImage
            End If

            'Switches the player after their move to the other
            If player = 2 Then
                player = 1
            Else
                player = 2
            End If
        Else
            MessageBox.Show("Invalid Move!") 'Shows invalid move if IsValid returns false
        End If

        'Checks for win using the vertical horzontal and diagonals win functions
        If VerticalWin(gameBoard) Or HorizontalWin(gameBoard) Or DiagonalDownToRight(gameBoard) Or DiagonalDownToLeft(gameBoard) Then

            'If there is a win the other players (since player has been switched to next player already) wins is incrmented by 1 and points for the round is calculated and added to total points
            'Players connect fours is also reset for next round
            If player = 2 Then
                playerOneWins += 1
                playerOneTotalPoints += GetPoints(gameBoard, 1, playerOneConnectFours)
                playerOneConnectFours = 0
            Else
                playerTwoWins += 1
                playerTwoTotalPoints += GetPoints(gameBoard, 2, playerTwoConnectFours)
                playerTwoConnectFours = 0
            End If

            roundsPassed += 1 'number of rounds passed incremented by 1 at the end of the round

            'Messagebox shown indicating which player won the round
            If player = 2 Then
                MessageBox.Show("Player 1 wins this round!")
            Else
                MessageBox.Show("Player 2 wins this round!")
            End If

            'Assigns player 1 to ensure at the begging of next round player 1 goes first
            player = 1

            'Resets the board by going through each element, resetting the array to all zeroes (no chip),
            'along with changing the all corresponding buttons to have the emptychip image as their background, 
            'backcolor to be reset to themecolor, and color shown when mouse is hovered over to transparent so background of form (which is theme color) can be seen
            For row As Integer = 0 To 5
                For column As Integer = 0 To 6
                    gameBoard(row, column) = 0
                    GetButtonFromRowAndColumn(row, column).Image = My.Resources.EmptyChip
                    GetButtonFromRowAndColumn(row, column).BackColor = themeColor
                    GetButtonFromRowAndColumn(row, column).FlatAppearance.MouseOverBackColor = Color.Transparent
                Next
            Next

            'If rounds passed reaches amount of rounds selected it sees who has more total round wins
            'Message boxs shown saying they are the winner and their total points
            If roundsPassed = rounds Then
                If playerOneWins > playerTwoWins Then
                    MessageBox.Show("Game Over. Player 1 wins the game!")
                    finalScore = Int(playerOneTotalPoints / playerOneWins)
                    MessageBox.Show("Player 1 got a score of " & finalScore & " points.")
                Else
                    MessageBox.Show("Game Over. Player 2 wins the game!")
                    finalScore = Int(playerTwoTotalPoints / playerTwoWins)
                    MessageBox.Show("Player 2 got a score of " & finalScore & " points.")
                End If

                'Also checks if the score is a new high score and if so updates the score board by using the IsHighScore function
                If IsHighScore(MenuForm.highScores, MenuForm.highScoresNames, finalScore) Then
                End If

                'Declares and opens the score board and once it is closed the game window closes
                Dim highScoresForm As New HighScores()
                HighScores.ShowDialog()

                Me.Close()
            End If
        End If
    End Sub

    'Detects if there is a empty spot in the array column selected for the player to place their chip and returns a Boolean
    'It does this by going through each row of the column selected and finds the lowest empty spot, and changes the row value passed to this row
    'If none are empty, it will return false
    'Pre: 6x7 array as argument
    'Post: Returns true are false and changes row and column variables to chip slot calculated if true
    Function IsValid(ByVal gameBoard(,) As Integer, ByRef row As Integer, ByVal column As Integer)
        Dim valid As Boolean = False
        For x As Integer = 0 To 5
            If gameBoard(x, column) = 0 Then
                row = x
                valid = True
            End If
        Next
        Return valid
    End Function

    'Detects if there is a vertical connect four
    'Does this by going through each array value (chip slot) in the first three rows and checking if the three array values beneath it (3 chip slots under on board) match
    'If this is true, it must mean the player going has completed a vertical connect four
    'If so, it will check which players chip is in the connect four, and 
    'use the getButton function to change the buttons images 
    'corresponding to the chips of the connect four and change them to the players winning chip image

    'Pre: 6x7 array as argument
    'Post: returns true if there was a vertical connect four and false if there was not
    Function VerticalWin(ByVal gameBoard(,) As Integer)
        Dim vertWin As Boolean = False

        For row As Integer = 0 To 2
            For column As Integer = 0 To 6
                If gameBoard(row, column) <> 0 Then
                    If gameBoard(row, column) = gameBoard(row + 1, column) And gameBoard(row + 1, column) = gameBoard(row + 2, column) _
                        And gameBoard(row + 2, column) = gameBoard(row + 3, column) Then
                        If gameBoard(row, column) = 1 Then
                            GetButtonFromRowAndColumn(row, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column).Image = playerOneChipImageWin
                            playerOneConnectFours += 1
                        Else
                            GetButtonFromRowAndColumn(row, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column).Image = playerTwoChipImageWin
                            playerTwoConnectFours += 1
                        End If
                        vertWin = True
                    End If
                End If
            Next
        Next

        Return vertWin
    End Function

    'Detects if there is a horzontal connect four
    'Does this by going through each array value (chip slot) in the first four columns and checking if the three array values to the left of it (3 chip slots left on board) match
    'If this is true, it must mean the player going has completed a horzontal connect four
    'If so, it will check which players chip is in the connect four, and 
    'use the getButton function to change the buttons images 
    'corresponding to the chips of the connect four and change them to the players winning chip image
    'Pre: 6x7 array as argument
    'Post: returns true if there was a vertical connect four and false if there was not
    Function HorizontalWin(ByVal gameBoard(,) As Integer)
        Dim horzWin As Boolean = False

        For row As Integer = 0 To 5
            For column As Integer = 0 To 3
                If gameBoard(row, column) <> 0 Then
                    If gameBoard(row, column) = gameBoard(row, column + 1) And gameBoard(row, column + 1) = gameBoard(row, column + 2) _
                        And gameBoard(row, column + 2) = gameBoard(row, column + 3) Then
                        If gameBoard(row, column) = 1 Then
                            GetButtonFromRowAndColumn(row, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row, column + 1).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row, column + 2).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row, column + 3).Image = playerOneChipImageWin
                            playerOneConnectFours += 1
                        Else
                            GetButtonFromRowAndColumn(row, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row, column + 1).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row, column + 2).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row, column + 3).Image = playerTwoChipImageWin
                            playerTwoConnectFours += 1
                        End If
                        horzWin = True
                    End If
                End If
            Next
        Next

        Return horzWin
    End Function

    'Detects if there is a diagonal connect four going down to the right
    'Does this by going through the first three values of the first four columns in the array, and checking if 
    'the three array values going diagonally down to the right match
    'If this is true, it must mean the player going has completed a diagonal connect four going down to the right
    'If so, it will check which players chip is in the connect four, and 
    'use the getButton function to change the buttons images 
    'corresponding to the chips of the connect four and change them to the players winning chip image
    'Pre: 6x7 array as argument
    'Post: returns true if there was a diagonal down to right connect four and false if there was not
    Function DiagonalDownToRight(ByVal gameBoard(,) As Integer)
        Dim diagDownToRightWin As Boolean = False

        For row As Integer = 0 To 2
            For column As Integer = 0 To 3
                If gameBoard(row, column) <> 0 Then
                    If gameBoard(row, column) = gameBoard(row + 1, column + 1) And gameBoard(row + 1, column + 1) = gameBoard(row + 2, column + 2) _
                        And gameBoard(row + 2, column + 2) = gameBoard(row + 3, column + 3) Then
                        If gameBoard(row, column) = 1 Then
                            GetButtonFromRowAndColumn(row, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column + 1).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column + 2).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column + 3).Image = playerOneChipImageWin
                            playerOneConnectFours += 1
                        Else
                            GetButtonFromRowAndColumn(row, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column + 1).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column + 2).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column + 3).Image = playerTwoChipImageWin
                            playerTwoConnectFours += 1
                        End If
                        diagDownToRightWin = True
                    End If
                End If
            Next
        Next

        Return diagDownToRightWin
    End Function

    'Detects if there is a diagonal connect four going down to the left
    'Does this by going through the first three values of the last four columns in the array, and checking 
    'if the three array values going diagonally down to the left match
    'If this is true, it must mean the player going has completed a diagonal connect four going down to the left
    'If so, it will check which players chip is in the connect four, and 
    'use the getButton function to change the buttons images 
    'corresponding to the chips of the connect four and change them to the players winning chip image
    'Pre: 6x7 array as argument
    'Post: returns true if there was a diagonal down to left connect four and false if there was not
    Function DiagonalDownToLeft(ByVal gameBoard(,) As Integer)
        Dim diagDownToRightWin As Boolean = False

        For row As Integer = 0 To 2
            For column As Integer = 3 To 6
                If gameBoard(row, column) <> 0 Then
                    If gameBoard(row, column) = gameBoard(row + 1, column - 1) And gameBoard(row + 1, column - 1) = gameBoard(row + 2, column - 2) _
                        And gameBoard(row + 2, column - 2) = gameBoard(row + 3, column - 3) Then
                        If gameBoard(row, column) = 1 Then
                            GetButtonFromRowAndColumn(row, column).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column - 1).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column - 2).Image = playerOneChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column - 3).Image = playerOneChipImageWin
                            playerOneConnectFours += 1
                        Else
                            GetButtonFromRowAndColumn(row, column).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 1, column - 1).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 2, column - 2).Image = playerTwoChipImageWin
                            GetButtonFromRowAndColumn(row + 3, column - 3).Image = playerTwoChipImageWin
                            playerTwoConnectFours += 1
                        End If
                        diagDownToRightWin = True
                    End If
                End If
            Next
        Next

        Return diagDownToRightWin
    End Function

    'Recreation of player holding chip over slot before dorpping it in
    'Detects when the users mouse goes over the column drop in buttons, and will show their chip in the button until their is no longer over the buttons
    'Upon the user not hovering over the column drop in buttons, the image will be removed and text will be displayed again
    Private Sub ChipRow_MouseEnter(sender As Object, e As System.EventArgs) Handles btn0.MouseEnter, btn1.MouseEnter, btn2.MouseEnter, btn3.MouseEnter, btn4.MouseEnter, btn5.MouseEnter, btn6.MouseEnter
        Dim chipRowClicked As Button = sender

        chipRowClicked.Text = Nothing

        If player = 1 Then
            chipRowClicked.Image = playerOneChipImage
        Else
            chipRowClicked.Image = playerTwoChipImage
        End If
    End Sub

    Private Sub ChipRow_MouseLeave(sender As Object, e As System.EventArgs) Handles btn0.MouseLeave, btn1.MouseLeave, btn2.MouseLeave, btn3.MouseLeave, btn4.MouseLeave, btn5.MouseLeave, btn6.MouseLeave
        Dim chipRowClicked As Button = sender

        chipRowClicked.Text = "↓"
        chipRowClicked.Image = Nothing
    End Sub

    'Function to get a button corresponding to its row and column in the array (game board)
    'Does this by appending the row and column to btn and returning the button with that name
    'Since buttons are named corresponding to the array rows and columns, it works!
    Function GetButtonFromRowAndColumn(ByVal row As Integer, ByVal column As Integer) As Button
        Return CType(Me.Controls("btn" & row.ToString & column.ToString), Button)
    End Function

    'Gets the number of ppoints for the winner of the round
    'Essentially does this by calculating based on how many extra chips the user placed that are not within connect fours
    Function GetPoints(ByVal gameBoard(,) As Integer, ByVal player As Integer, ByVal playerConnectFours As Integer)
        'Declares points variable and variables to find out how many extra chips they placed
        Dim points As Integer
        Dim totalChipsPlaced As Integer
        Dim winChipsPlaced As Integer
        Dim extraChipsPlaced As Integer

        'Goes through the gamebaord array and counts the total number of player values (chips)
        For row As Integer = 0 To 5
            For column As Integer = 0 To 6
                If gameBoard(row, column) = player Then
                    totalChipsPlaced += 1
                End If
            Next
        Next

        'Goes through the gameboard array, finds the corresponding button on the form, and checks if its image is set to the players win image
        'This allows it to count how many chips the player has that are part of a connect four
        For row As Integer = 0 To 5
            For column As Integer = 0 To 6
                If GetButtonFromRowAndColumn(row, column).Image Is playerOneChipImageWin Or GetButtonFromRowAndColumn(row, column).Image Is playerTwoChipImageWin Then
                    winChipsPlaced += 1
                End If
            Next
        Next

        extraChipsPlaced = totalChipsPlaced - winChipsPlaced 'Find extra chips placed 

        'Calculates points by multiplying 10000 for every connect four and dividing by extrachips plus one
        'One is added because if the user had no extrachips it would result in dividing by zero
        points = 10000 * playerConnectFours / (extraChipsPlaced + 1)

        Return points
    End Function

    'Calculates if the user has a new highscore or not
    Function IsHighScore(ByRef highScores() As Integer, ByRef highScoresNames() As String, ByVal finalScore As Integer)
        Dim highScoreBoolean As Boolean = False 'Declares boolean representing ig they got a new highscore or not

        'Compares highscore between each value of the highscoreboard and to see where it would fall between when placed on the board
        'If it falls in on the board anywhere, the lower highscores and corresponding are shifted down by one in their arrays
        'The new highscore is entered in the empty highscores array spot and a new name is entered in the empty highscoresnames array spot



        If finalScore >= highScores(4) And finalScore < highScores(3) Then
            highScoreBoolean = True
            highScores(4) = finalScore
            Do
                highScoresNames(4) = InputBox("New highscore! Enter a name.")
            Loop While highScoresNames(4) = Nothing

        ElseIf finalScore >= highScores(3) And finalScore < highScores(2) Then
            highScoreBoolean = True
            highScores(4) = highScores(3)
            highScoresNames(4) = highScoresNames(3)
            highScores(3) = finalScore
            Do
                highScoresNames(3) = InputBox("New highscore! Enter a name.")
            Loop While highScoresNames(3) = Nothing

        ElseIf finalScore >= highScores(2) And finalScore < highScores(1) Then
            highScoreBoolean = True
            highScores(4) = highScores(3)
            highScoresNames(4) = highScoresNames(3)
            highScores(3) = highScores(2)
            highScoresNames(3) = highScoresNames(2)
            highScores(2) = finalScore
            Do
                highScoresNames(2) = InputBox("New highscore! Enter a name.")
            Loop While highScoresNames(2) = Nothing

        ElseIf finalScore >= highScores(1) And finalScore < highScores(0) Then
            highScoreBoolean = True
            highScores(4) = highScores(3)
            highScoresNames(4) = highScoresNames(3)
            highScores(3) = highScores(2)
            highScoresNames(3) = highScoresNames(2)
            highScores(2) = highScores(1)
            highScoresNames(2) = highScoresNames(1)
            highScores(1) = finalScore
            Do
                highScoresNames(1) = InputBox("New highscore! Enter a name.")
            Loop While highScoresNames(1) = Nothing

        ElseIf finalScore >= highScores(0) Then
            highScoreBoolean = True
            highScores(4) = highScores(3)
            highScoresNames(4) = highScoresNames(3)
            highScores(3) = highScores(2)
            highScoresNames(3) = highScoresNames(2)
            highScores(2) = highScores(1)
            highScoresNames(2) = highScoresNames(1)
            highScores(1) = highScores(0)
            highScoresNames(1) = highScoresNames(0)
            highScores(0) = finalScore
            Do
                highScoresNames(0) = InputBox("New highscore! Enter a name.")
            Loop While highScoresNames(0) = Nothing
        End If

        'Then the highscore file is cleared and the updated highscore table is written line by line
        'Writes the score, and then the name on the next line and repeats for the five highscores
        IO.File.WriteAllText(hfile, Nothing)

        Dim fs As New FileStream(hfile, FileMode.Append, FileAccess.Write)
        Dim highScoreFile As New StreamWriter(fs)

        highScoreFile.WriteLine(highScores(0))
        highScoreFile.WriteLine(highScoresNames(0))
        highScoreFile.WriteLine(highScores(1))
        highScoreFile.WriteLine(highScoresNames(1))
        highScoreFile.WriteLine(highScores(2))
        highScoreFile.WriteLine(highScoresNames(2))
        highScoreFile.WriteLine(highScores(3))
        highScoreFile.WriteLine(highScoresNames(3))
        highScoreFile.WriteLine(highScores(4))
        highScoreFile.WriteLine(highScoresNames(4))

        highScoreFile.Close()
        fs.Close()

        Return highScoreBoolean
    End Function
End Class