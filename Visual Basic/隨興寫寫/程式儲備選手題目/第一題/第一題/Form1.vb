Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide() '把表單隱藏

        Dim s As String = InputBox("請輸入字串") : Dim num As Integer = 0
        s = Trim(s) '去最左和最右的空白(不包刮中間空白)

        '利用Ascii碼判斷是不是數字

        For i = 1 To Len(s)
            If AscW(Mid(s, i, 1)) >= 48 And AscW(Mid(s, i, 1)) <= 57 Then num += Val(Mid(s, i, 1))
        Next

        MsgBox(num)

        Me.Close() '把表單關閉

    End Sub
End Class
