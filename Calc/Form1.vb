Public Class Form1
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        'declare variables
        Dim answer As Integer
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        'input
        firstNumber = txtFirst.Text
        secondNumber = txtSecond.Text

        'processing
        answer = firstNumber + secondNumber

        'output
        lblAnswer.Text = answer

    End Sub

    Private Sub cmdSubtract_Click(sender As Object, e As EventArgs) Handles cmdSubtract.Click
        'declare variables
        Dim answer As Integer
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        'input
        firstNumber = txtFirst.Text
        secondNumber = txtSecond.Text

        'processing
        answer = firstNumber - secondNumber

        'output
        lblAnswer.Text = answer

    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        'declare variables
        Dim answer As Integer
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        'input
        firstNumber = txtFirst.Text
        secondNumber = txtSecond.Text

        'processing
        answer = firstNumber * secondNumber

        'output
        lblAnswer.Text = answer

    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        'declare variables
        Dim answer As Integer
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        'input
        firstNumber = txtFirst.Text
        secondNumber = txtSecond.Text

        'processing
        answer = firstNumber / secondNumber

        'output
        lblAnswer.Text = answer

    End Sub
End Class