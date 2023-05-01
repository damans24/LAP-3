Public Class Form1


    Private payment As Double
    Private fiftyPercent As Double
    Private twentyAnnual As Double
    Private winnings As Integer
    Private message As String
    Private luckyNumber As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'back coor of form

        BackColor = Color.GreenYellow
    End Sub

    Private Sub fiftyButton_Click(sender As Object, e As EventArgs) Handles fiftyButton.Click


        fiftyButton.BackColor = Color.LightBlue




    End Sub

    Private Sub twentyButton_Click(sender As Object, e As EventArgs) Handles twentyButton.Click


        twentyButton.BackColor = Color.LightBlue



    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click

        Dim randomGenerator As New Random
        Dim randomNumber As Integer





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

        randomNumber = randomGenerator.Next(1, 3) + 1
        If randomNumber = luckyNumber Then
            resultText.Text = "Congratulations!! The random number is " & randomNumber.ToString &
                ". You have won!"

        Else
            resultText.Text = "The random number is " & randomNumber.ToString & ". Sorry. Try again"
        End If


    End Sub
End Class
