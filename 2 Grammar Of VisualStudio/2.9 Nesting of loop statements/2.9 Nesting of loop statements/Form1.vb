Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim i, j As Integer
        Dim a As Single
        Dim strPrize As String
        strPrize = ""
        For i = 1 To 3
            j = Int(10 * Rnd())
            strPrize = strPrize & j
            For a = 1 To 10000 Step 0.001
            Next a
            txtPrize.Text = strPrize
            txtPrize.Refresh()
        Next i


    End Sub
End Class
