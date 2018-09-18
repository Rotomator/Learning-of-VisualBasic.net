Public Class Form1
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        TextBox1.Text = TextBox1.Text + "MouseDown事件" + vbCrLf
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        TextBox1.Text = TextBox1.Text + "MouseUp事件" + vbCrLf
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox1.Text = TextBox1.Text + "Click事件" + vbCrLf
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        TextBox1.Text = TextBox1.Text + "DoubleClick事件" + vbCrLf
    End Sub
End Class
