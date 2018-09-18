Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectAll() '选中textbox1的文本内容
        TextBox1.Copy() '复制Textbox1中的内容
        TextBox2.Clear() '清除Textbox2中的内容
        TextBox2.Paste() '将复制内容粘贴到Textbox2中
        TextBox1.SelectionStart = Len(TextBox1.Text) '取消选中状态
    End Sub
End Class
