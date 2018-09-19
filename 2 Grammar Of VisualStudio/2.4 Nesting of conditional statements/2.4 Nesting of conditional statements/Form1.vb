Public Class Form1
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim x As Single
        Dim y As Single
        x = Val(txtX.Text)
        '使用if then语句
        If x <> 0 Then
            If x > 0 Then
                y = 1

            End If
            If x < 0 Then
                y = -1
            End If
        Else
            y = 0
        End If
        txtY.Text = y
    End Sub
End Class
