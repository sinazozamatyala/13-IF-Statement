Public Class Form1
    Private Sub btnMaximum_Click(sender As Object, e As EventArgs) Handles btnMaximum.Click
        Dim firstNumber, secondNumber As Double

        firstNumber = Val(txtNum1.Text)
        secondNumber = Val(txtNum2.Text)

        If firstNumber > secondNumber Then
            txtMaximum.Text = firstNumber
        Else
            txtMaximum.Text = secondNumber
        End If
    End Sub
End Class
