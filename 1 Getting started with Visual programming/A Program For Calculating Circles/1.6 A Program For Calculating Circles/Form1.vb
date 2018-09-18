Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Single
        r = Val(TextBox1.Text)
        TextBox2.Text = Math.PI * r ^ 2
    End Sub
End Class
