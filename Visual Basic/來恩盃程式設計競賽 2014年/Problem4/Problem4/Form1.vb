Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String = TextBox1.Text
        Dim str2 As String = StrReverse(TextBox1.Text)

        If str = str2 Then
            TextBox2.Text = "迴文"
        Else
            TextBox2.Text = "非迴文"
        End If

    End Sub
End Class
