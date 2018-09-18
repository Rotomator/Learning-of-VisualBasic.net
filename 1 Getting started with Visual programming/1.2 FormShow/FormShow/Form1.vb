Public Class Form1


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim formshow As New FormShow() '定义新的窗体
        formshow.Show() '使用窗体的方法 Show加载并显示窗体
    End Sub
End Class
