
Imports System.Math

Public Class Form1


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim a, b, c, disc, RPart, IPart As Single
        Dim x1, x2 As String
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)

        If a = 0 Then
            x1 = -b / c
            x2 = "无解"
        Else
            disc = b ^ 2 - 4 * a * c
            If disc = 0 Then
                x1 = -b / (2 * a)
                x2 = x1
            ElseIf disc > 0 Then
                x1 = (-b + Sqrt(disc)) / (2 * a)
                x2 = (-b - Sqrt(disc)) / (2 * a)
            Else
                RPart = -b / (2 * a)
                IPart = Sqrt(-disc) / (2 * a)
                x1 = RPart & "+" & IPart
                x2 = RPart & "-" & IPart
            End If

        End If
        txtX1.Text = x1
        txtX2.Text = x2

    End Sub
End Class
