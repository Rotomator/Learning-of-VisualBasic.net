Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 1
        Dim s As Integer = 0
        While i <= 100
            s = s + i
            i += 1
        End While
        TextBox1.Text = s
    End Sub
End Class
