Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As String = TextBox1.Text : Dim num2 As String = TextBox2.Text

        If Mid(num1, 1, 1) = "-" Or Mid(num2, 1, 1) = "-" Then
            MsgBox("其中一格有數字以外的符號喔！" & vbCrLf & "本計算機不接受負數" & vbCrLf & "請重新輸入！")
        ElseIf IsNumeric(num1) = False Or IsNumeric(num2) = False Then
            MsgBox("其中一格有數字以外的符號喔！" & vbCrLf & "請重新輸入！")
        Else

            If Len(num1) > Len(num2) Then

                Do Until Len(num2) = Len(num1)
                    num2 = "0" & num2
                Loop

            ElseIf Len(num2) > Len(num1) Then

                Do Until Len(num1) = Len(num2)
                    num1 = "0" & num1
                Loop

            End If

            Dim flag As Boolean = False 'true要進位
            Dim ans As String = ""

            For i = Len(num1) To 1 Step -1
                Dim a As Integer
                a = Val(Mid(num1, i, 1)) + Val(Mid(num2, i, 1))
                If flag = True Then a += 1 : flag = False
                If a >= 10 Then a = a Mod 10 : ans &= a.ToString : flag = True : Continue For
                ans &= a.ToString
            Next
            If Val(Mid(num1, 1, 1)) + Val(Mid(num2, 1, 1)) >= 10 Then ans &= "1"
            ans = StrReverse(ans) : MsgBox(ans)

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num1 As String = TextBox1.Text : Dim num2 As String = TextBox2.Text

        
        If Mid(num1, 1, 1) = "-" Or Mid(num2, 1, 1) = "-" Then
            MsgBox("其中一格有數字以外的符號喔！" & vbCrLf & "本計算機不接受負數" & vbCrLf & "請重新輸入！")
        ElseIf IsNumeric(num1) = False Or IsNumeric(num2) = False Then
            MsgBox("其中一格有數字以外的符號喔！" & vbCrLf & "請重新輸入！")
        Else

            If Len(num1) > Len(num2) Then

                Do Until Len(num2) = Len(num1)
                    num2 = "0" & num2
                Loop

            ElseIf Len(num2) > Len(num1) Then

                Do Until Len(num1) = Len(num2)
                    num1 = "0" & num1
                Loop

            End If

            Dim flag As Boolean = False 'true要借位
            Dim ans As String = ""

            For i = Len(num1) To 1 Step -1
                Dim a As Integer
                a = Val(Mid(num1, i, 1)) - Val(Mid(num2, i, 1))
                If flag = True Then a -= 1 : flag = False
                If a < 0 Then a += 10 : ans &= a.ToString : flag = True : Continue For
                ans &= a.ToString
            Next

            Dim b As String = ""

            b = StrReverse(ans) : ans = ""

            For j = 2 To Len(b)
                ans &= Mid(b, j, 1)
            Next

            MsgBox(ans)

        End If

    End Sub
End Class
