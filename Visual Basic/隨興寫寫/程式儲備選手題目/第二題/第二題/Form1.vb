Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide() '把表單隱藏

        Dim s As String = InputBox("請輸入二進位數字")
        s = Trim(s) '去最左和最右的空白(不包刮中間空白)
        Dim num As Integer = Len(s) - 1 '拿來做次方
        Dim ans As Integer = 0 '十進位答案

        '模擬二進位轉十進位的算法

        For i = 1 To Len(s)
            ans += Val(Mid(s, i, 1)) * 2 ^ num
            num -= 1
        Next

        MsgBox(ans)

        Me.Close() '把表單關閉

    End Sub
End Class
