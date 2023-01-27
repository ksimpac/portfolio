Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim num As Integer = Val(num_box.Text)
        Dim a As Integer = num ^ 2 + num + 41
        Dim flag As Boolean = False

        For i = 2 To a \ 2

            If a Mod i = 0 Then
                flag = True : Exit For
            End If

        Next

        If flag = True Then
            ansbox.Text = "非質數"
        Else
            ansbox.Text = "質數"
        End If

    End Sub
End Class
