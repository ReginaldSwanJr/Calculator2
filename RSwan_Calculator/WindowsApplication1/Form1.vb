'Name: regiinald Swan, Jr.
'Date: 3/10/2016

Public Class Calculator
    Dim strMemory As String  ' the first memory holds numbers as a string
    Dim strMemory2 As String ' Secondary memory used when additional calculations are made
    Dim intOperation As Integer     ' A number that holds the operation code the op code tells what operand is used ie: * / + -
    Dim blClear As Boolean = True    ' boolean variable used to tell if strMemory has been used
    Dim blDbl As Boolean = False     ' boolean variable that determines if in double mode

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtScreen.Text = txtScreen.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtScreen.Text = txtScreen.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtScreen.Text = txtScreen.Text + "9"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtScreen.Text = txtScreen.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtScreen.Text = txtScreen.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtScreen.Text = txtScreen.Text + "6"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtScreen.Text = txtScreen.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtScreen.Text = txtScreen.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtScreen.Text = txtScreen.Text + "3"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtScreen.Text = txtScreen.Text + "0"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        txtScreen.Text = txtScreen.Text + "."
        blDbl = True
    End Sub





    ' OPERATION BUTTONS

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        strMemory = txtScreen.Text
        txtScreen.Text = ""

        intOperation = 1
        If blClear = False Then
            intOperation = 5
        End If

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        strMemory = txtScreen.Text
        txtScreen.Text = ""

        intOperation = 2
        If blClear = False Then
            intOperation = 6
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        strMemory = txtScreen.Text
        txtScreen.Text = ""

        intOperation = 3
        If blClear = False Then
            intOperation = 7
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        strMemory = txtScreen.Text
        txtScreen.Text = ""

        intOperation = 4
        If blClear = False Then
            intOperation = 8
        End If
    End Sub


    ' EQUAL BUTTON
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim intLeft As Double
        Dim intLeft2 As Double
        Dim intRight As Double

        If blDbl Then
            intLeft = Convert.ToDouble(strMemory)
            intLeft2 = Convert.ToDouble(strMemory2)
            intRight = Convert.ToDouble(txtScreen.Text)

        Else
            intLeft = Convert.ToInt32(strMemory)
            intLeft2 = Convert.ToInt32(strMemory2)
            intRight = Convert.ToInt32(txtScreen.Text)
        End If
        Select Case intOperation
            Case 1
                txtScreen.Text = intLeft / intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 2
                txtScreen.Text = intLeft * intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 3
                txtScreen.Text = intLeft + intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 4
                txtScreen.Text = intLeft - intRight
                strMemory2 = txtScreen.Text
                blClear = False

            Case 5
                txtScreen.Text = intLeft / intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 6
                txtScreen.Text = intLeft * intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 7
                txtScreen.Text = intLeft + intRight
                strMemory2 = txtScreen.Text
                blClear = False
            Case 8
                txtScreen.Text = intLeft - intRight
                strMemory2 = txtScreen.Text
                blClear = False
        End Select

        If intRight = 0 And intOperation = 1 Then
            MsgBox("cant divide zero")
            btnClear.PerformClick()
        End If
        If intRight = 0 And intOperation = 5 Then
            MsgBox("cant divide zero")
            btnClear.PerformClick()
        End If

    End Sub



    ' CLEAR BUTTON
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScreen.Text = "0"
        strMemory = "0"
        strMemory2 = "0"
        blClear = True
    End Sub
End Class
