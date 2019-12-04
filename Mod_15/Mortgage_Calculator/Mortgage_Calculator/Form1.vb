' Jacob Jordan
' Mortgage Calculator
' 11/28
Public Class Form1
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill list box with term lengths.

        For intRates As Double = 2 To 8 Step 0.5
            cboInterest.Items.Add(intRates.ToString)
        Next intRates
        cboInterest.SelectedItem = "3.0"

        For termLengths As Integer = 15 To 30 Step 5
            cboTerm.Items.Add(termLengths.ToString("N1"))
        Next termLengths

    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim initialAmount, intRate, fifteenYear, twentyYear, twentyFiveYear, thirtyYear, termLength As Double

        Integer.TryParse(txtInitial.Text, initialAmount)
        Double.TryParse(cboInterest.SelectedItem.ToString, intRate)
        Double.TryParse(cboTerm.SelectedItem.ToString, termLength)

        'For termLength As Integer = 15 To 30 Step 5
        '    dblAmount = -Financial.Pmt(intRate / 12, termLength * 12, initialAmount)
        'Next termLength

        termLength = cboTerm.SelectedItem

        fifteenYear = -Financial.Pmt(intRate / 12, 15 * 12, initialAmount)
        twentyYear = -Financial.Pmt(intRate / 12, 20 * 12, initialAmount)
        twentyFiveYear = -Financial.Pmt(intRate / 1200, 25 * 12, initialAmount)
        thirtyYear = -Financial.Pmt(intRate / 1200, 30 * 12, initialAmount)

        lblFifteenYear.Text = fifteenYear.ToString("C2")
        lblTwentyYear.Text = twentyYear.ToString("C2")
        lblTwentyFiveYear.Text = twentyFiveYear.ToString("C2")
        lblThirtyYear.Text = thirtyYear.ToString("C2")
    End Sub
    Private Sub CmbInterest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInterest.SelectedIndexChanged

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class


'Create an application that calculates and displays four monthly mortgage payments. 
'The application should use the loan amount And annual interest rate provided by the user, 
'along With terms Of 15 years, 20 years, 25 years, And 30 years. Use a combo box To Get the annual interest rate, 
'which should range from 2% through 8% In increments Of 0.5%. 
'The application should also display the total amount paid at the 
'End Of 15 years, 20 years, 25 years, And 30 years.