Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim f, y, k As Integer
        y = Val(txtYear.Text)
        f = Int((y - 1) * (1 + 1 / 4 - 1 / 100 + 1 / 400) + 1)
        k = f - Int(f / 7) * 7
        If k = 0 Then
            txtDay.Text = "日"
        Else
            txtDay.Text = k
        End If

    End Sub
End Class
