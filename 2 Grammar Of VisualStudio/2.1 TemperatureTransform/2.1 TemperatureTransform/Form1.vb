Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim C As Single
        Dim F As Single = 78
        C = 5 / 9 * (F - 32)
        txtTemperature.Text = C
    End Sub
End Class
