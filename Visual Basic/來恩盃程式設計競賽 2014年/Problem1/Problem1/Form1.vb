Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer = Val(TextBox1.Text)
        Dim ans As Integer = re(num)
        ansbox.Text = ans.ToString
    End Sub

    Function re(ByVal num As Integer)

        If num = 1 Then
            Return 3
        ElseIf num = 2 Then
            Return 5
        Else
            Return 3 * re(num - 1) - re(num - 2)
        End If

    End Function
End Class
