Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim s As Integer = 0
        'Do While i <= 100
        Do Until i > 100
            s = s + i
            i = i + 1
        Loop
        TextBox1.Text = s
    End Sub
End Class
