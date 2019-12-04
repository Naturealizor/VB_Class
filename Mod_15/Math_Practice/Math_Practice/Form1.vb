'Jacob Jordan
'Math Practice
'11/28

Option Explicit Off
Option Infer Off
Public Class Form1
    Dim randA, randB As Integer
    Dim randGen As New Random

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim stuName As String

        randA = randGen.Next(0, 21)
        randB = randGen.Next(0, 21)


    End Sub
    Private Sub BntQuit_Click(sender As Object, e As EventArgs) Handles bntQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles bntRun.Click
        Dim equationAdd As String

        equationAdd = randA + randB
        If rdbAdd.Checked Then
            lblEquation.Text = equationAdd


        End If
    End Sub
End Class


'Create an application that can be used to practice adding, subtracting, multiplying, and dividing numbers. 
'The application should display a math problem On the screen And Then allow the student To enter the answer 
'And also verify that the answer Is correct. The application should give the student As many chances 
'As necessary To answer the problem correctly. The math problems should use random integers from 1 through 20, inclusive. 
'The subtraction problems should never ask the student To subtract a larger number from a smaller one. 
'The division problems should never ask the student To divide a smaller number by a larger number. 
'Also, the answer To the division problems should always result In a whole number. 
'The application should keep track Of the number Of correct And incorrect responses made by the student. 
'The Interface should include a button that allows the user To reset the counters For a different student.