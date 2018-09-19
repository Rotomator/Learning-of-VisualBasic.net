Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, s As Integer
        s = 0
        For i = 100 To 1 Step -1
            s = s + i
            If s >= 5000 Then Exit For
        Next i
        TextBox1.Text = s
    End Sub
End Class
