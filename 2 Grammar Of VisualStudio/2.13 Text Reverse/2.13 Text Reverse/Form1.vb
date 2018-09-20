Public Class Form1
    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim str As String
        str = StrReverse(LCase(Trim(txtInput.Text)))
        txtReverse.Text = str
    End Sub
End Class
