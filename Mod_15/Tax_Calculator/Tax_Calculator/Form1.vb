'Jacob Jordan
'Tax-Deductible Calculator
'11/28

Public Class Form1
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class

'Create an interface that provides text boxes for entering the following business expenses: lodging, travel, meals, and entertainment.
'Lodging And travel are 100% tax deductible; meals And entertainment are only 50% tax deductible. 
'The application should calculate And display the total expenses, the amount that Is tax deductible, 
'And the percentage that Is tax deductible. Each text box should accept only numbers, one period, And the Backspace key. 
'(Notice that Each text box should Not allow the user To enter more than one period.)