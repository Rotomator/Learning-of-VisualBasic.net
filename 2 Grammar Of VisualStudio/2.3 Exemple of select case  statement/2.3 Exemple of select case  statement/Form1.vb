Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strNumber As String
        strNumber = txtNumber.Text
        Select Case strNumber
            Case 123
                labResult.Text = "真幸运，你获得一等奖！"
            Case 120 To 129
                labResult.Text = "恭喜你，你获得二等奖！"
            Case 100 To 199
                labResult.Text = "还不错，你中了三等奖！"
            Case Else
                labResult.Text = "谢谢参与！"

        End Select
    End Sub
End Class
