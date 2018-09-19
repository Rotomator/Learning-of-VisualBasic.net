Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim s As Integer = 0
        For i = 1 To 100
            s = s + i

        Next i
        TextBox1.Text = s

    End Sub
End Class
