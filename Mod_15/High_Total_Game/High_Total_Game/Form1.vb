'Jacob Jordan
'High Game Total
'11/28

Option Explicit Off
Option Infer Off
Public Class Form1

    Private Sub winCount(p1Total)
        Dim winCountP1 As Integer
        Dim winCountP2 As Integer
        Dim totalWinsP1 As Integer = 0
        Dim totalWinsP2 As Integer = 0
        Dim tieCount As Integer = 0
        Dim totalTies As Integer = 0

        If p1Total > p2Total Then
            lblAnnounce.Text = lblP1Lable.Text + " is the winner with " + winCountP1.ToString
            winCountP1 += 1
            'totalWinsP1 = totalWinsP1 + winCountP1
        ElseIf p1Total = p2Total Then
            lblAnnounce.Text = "It was a tie!"
            tieCount += 1
            totalTies = totalTies + tieCount

        Else
            lblAnnounce.Text = lblP2Lable.Text + " is the winner!"
            winCountP2 += 1
            totalWinsP2 = totalWinsP2 + winCountP2

        End If


        lblWinCountP1.Text = winCountP1.ToString
        lblWinCountP2.Text = totalWinsP2.ToString
        lblTieCount.Text = totalTies.ToString
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim randGen As New Random
        Dim p1RandomNumOne, p1RandomNumTwo, p2RandomNumOne, p2RandomNumTwo As Integer
        Dim p1Name, p2Name As String

        Dim p1Total As Integer = 0
        Dim p2Total As Integer = 0

        p1RandomNumOne = randGen.Next(0, 21)
        p1RandomNumTwo = randGen.Next(0, 21)
        p2RandomNumOne = randGen.Next(0, 21)
        p2RandomNumTwo = randGen.Next(0, 21)
        p1Total = p1RandomNumOne + p1RandomNumTwo
        p2Total = p2RandomNumOne + p2RandomNumTwo

        lblP1RandomNumOne.Text = p1RandomNumOne.ToString
        lblP1RandomNumTwo.Text = p1RandomNumTwo.ToString
        lblP2RandomNumOne.Text = p2RandomNumOne.ToString
        lblP2RandomNumTwo.Text = p2RandomNumTwo.ToString
        lblP1Total.Text = p1Total.ToString
        lblP2Total.Text = p2Total.ToString

        winCount()

        'Do
        '    lblAnnounce.Text = lblP1Lable.Text + " is the winner!"
        '    winCountP1 += 1
        'Loop While p1Total > p2Total





    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles bntNewGame.Click
        p1Name = String.Empty
        p2Name = String.Empty
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        p1Name = txtP1Name.Text
        p2Name = txtP2Name.Text
        lblP1Lable.Text = p1Name
        lblP2Lable.Text = p2Name
    End Sub
End Class

'The High Total game requires two players. 
'The application's interface should allow the user to enter each player’s name. 
'When the user clicks a button, the button’s Click event procedure should generate 
'two random numbers For player 1 And two random numbers For player 2. 
'The random numbers should be in the range of 1 through 20, inclusive. 
'The procedure should display the four numbers In the Interface. 
'It should also total the numbers For Each player And Then display both totals In the Interface. 
'If both totals are the same, the application should display the message “Tie”. 
'If player 1's total is greater than player 2’s total, it should display the message “player 1’s name won”. 
'If player 2's total is greater than player 1’s total, it should display the message “player 2’s name won”. 
'The application should keep track Of the number Of times player 1 wins, the number Of times player 2 wins, 
'And the number Of ties. The Interface should also include a button that allows the user To reset the counters 
'And Interface For a New game.