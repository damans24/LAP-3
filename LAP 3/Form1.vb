
'MIS 322
'Damanbir Singh
'10/21/2022
'LAP 3


Option Explicit On
Option Strict On

Public Class Form1

    Private payment As Double
    Private fiftyPercent As Double
    Private twentyAnnual As Double
    Private winnings As Integer
    Private message, paymentText As String
    Private luckyNumber As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'back coor of form

        BackColor = Color.GreenYellow
    End Sub

    Private Sub fiftyButton_Click(sender As Object, e As EventArgs) Handles fiftyButton.Click

        'select 50 percent upfront payment

        fiftyButton.BackColor = Color.LightBlue
        twentyButton.BackColor = Nothing



    End Sub

    Private Sub twentyButton_Click(sender As Object, e As EventArgs) Handles twentyButton.Click

        'select 20 annual payments option

        twentyButton.BackColor = Color.LightBlue
        fiftyButton.BackColor = Nothing


    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click

        'generate a random number and if number matches the lucky number input
        'then determine winnings, payment and tax rate

        Dim randomGenerator As New Random
        Dim randomNumber As Integer
        Dim winningGenerator As New Random
        Dim winningNumber As Double
        Dim taxRate As String



        If luckyNumberText.Text = "1" Then
            luckyNumber = 1
        ElseIf luckyNumberText.Text = "2" Then
            luckyNumber = 2
        ElseIf luckyNumberText.Text = "3" Then
            luckyNumber = 3
        Else
            message = "Please enter a lucky number"
            MessageBox.Show(message, "Invalid selection")
            Exit Sub
        End If

        If fiftyButton.BackColor = Color.LightBlue Then
            paymentText = " 50% upfront payment"
        ElseIf twentyButton.BackColor = Color.LightBlue Then
            paymentText = " 20 annual payments"
        Else
            message = "Please select a payment type"
            MessageBox.Show(message, "No selection")
            Exit Sub
        End If


        randomNumber = randomGenerator.Next(1, 4)
        winningNumber = winningGenerator.Next(1, 2000001)

        fiftyPercent = winningNumber / 2
        twentyAnnual = winningNumber / 20

        If fiftyButton.BackColor = Color.LightBlue Then
            payment = fiftyPercent
        ElseIf twentyButton.BackColor = Color.LightBlue Then
            payment = twentyAnnual
        End If

        If payment >= 500000 Then
            taxRate = "30%"
        ElseIf payment >= 300000 And payment <= 499999 Then
            taxRate = "25%"
        ElseIf payment >= 100000 And payment <= 299999 Then
            taxRate = "20%"
        ElseIf payment >= 10000 And payment <= 99999 Then
            taxRate = "10%"
        ElseIf payment < 10000 Then
            taxRate = "5%"
        End If

        If randomNumber = luckyNumber Then
            resultText.Text = "Congratulations!! The random number is " & randomNumber.ToString &
                ". You have won!" & vbNewLine & "Your winnings are " & winningNumber.ToString("C2") & "." &
                vbNewLine & "Your payment choice is" & paymentText & vbNewLine &
                "Your payment amount is " & payment.ToString("C2") & vbNewLine &
                "Your tax rate is " & taxRate
        Else
            resultText.Text = "The random number is " & randomNumber.ToString &
                vbNewLine & "Sorry. Try again"
        End If


    End Sub
End Class
