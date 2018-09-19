Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strNumber As String
        strNumber = txtNumber.Text
        If strNumber = "123" Then
            labResult.Text = "恭喜你获得一等奖！"
        ElseIf strNumber Like "12?" Then
            labResult.Text = "恭喜你获得二等奖！"
        ElseIf strNumber Like "1??" Then
            labResult.Text = "还不错哟，三等奖！"
        Else
            labResult.Text = "谢谢参与！"

        End If
    End Sub
End Class
