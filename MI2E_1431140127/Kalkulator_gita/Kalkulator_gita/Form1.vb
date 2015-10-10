Public Class Form1

    Dim num1 As Double, num2 As Double, hasil As Double
    Dim pilih As String
    Dim operation As Boolean

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If operation = False Then
            num1 = num1 & 1 
            TextBox1.Text = num1
        Else
            num2 = num2 & 1
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If operation = False Then
            num1 = num1 & 2
            TextBox1.Text = num1
        Else
            num2 = num2 & 2
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If operation = False Then
            num1 = num1 & 3
            TextBox1.Text = num1
        Else
            num2 = num2 & 3
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If operation = False Then
            num1 = num1 & 4
            TextBox1.Text = num1
        Else
            num2 = num2 & 4
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If operation = False Then
            num1 = num1 & 5
            TextBox1.Text = num1
        Else
            num2 = num2 & 5
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If operation = False Then
            num1 = num1 & 6
            TextBox1.Text = num1
        Else
            num2 = num2 & 6
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If operation = False Then
            num1 = num1 & 7
            TextBox1.Text = num1
        Else
            num2 = num2 & 7
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If operation = False Then
            num1 = num1 & 8
            TextBox1.Text = num1
        Else
            num2 = num2 & 8
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If operation = False Then
            num1 = num1 & 9
            TextBox1.Text = num1
        Else
            num2 = num2 & 9
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If operation = False Then
            num1 = num1 & 0
            TextBox1.Text = num1
        Else
            num2 = num2 & 0
            TextBox1.Text = num2
        End If
    End Sub

    Private Sub bntMin_Click(sender As Object, e As EventArgs) Handles bntMin.Click
        operation = True
        pilih = "-"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        operation = True
        pilih = "+"
    End Sub

    Private Sub btnSD_Click(sender As Object, e As EventArgs) Handles btnSD.Click
        num2 = TextBox1.Text
        operation = False
        Select Case pilih
            Case "-"
                hasil = num1 - num2
                TextBox1.Text = hasil
                num1 = hasil
                num2 = 0
            Case "+"
                hasil = num1 + num2
                TextBox1.Text = hasil
                num1 = hasil
                num2 = 0
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        operation = False
        TextBox1.Text = "0"
        num1 = 0
        num2 = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operation = False
        TextBox1.Text = 0
    End Sub
End Class
