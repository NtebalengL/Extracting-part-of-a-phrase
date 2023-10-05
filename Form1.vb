Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblNum.Click, lblText.Click

    End Sub

    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        Dim MyPhrase As String
        Dim pos, n As Integer
        MyPhrase = txtPhrase.Text
        pos = txtPosition.Text
        n = txtCharacter.Text
        lblText.Text = Mid(MyPhrase, pos, n)

    End Sub
End Class
