Public Class 密碼轉換

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str As String = question.Text : Dim ans As String = ""

        For i = 1 To Len(str)

            Dim a As Integer = 0 : Dim b As String = ""  'a存字元的ascii碼 b存字元

            b = Mid(str, i, 1) : a = AscW(b)

            If a >= 121 And a <= 122 Then
                ans = ans & ChrW(a - 24)
            ElseIf a >= 89 And a <= 90 Then
                ans = ans & ChrW(a - 24)
            ElseIf a >= 56 And a <= 57 Then
                ans = ans & ChrW(a - 8)
            Else
                ans &= ChrW(a + 2)
            End If

        Next

        answer.Text = ans
    End Sub
End Class
