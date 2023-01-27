Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim a As String = "12" : Dim b As String = "48" '資料
        Dim num(15) As String '放數字字串 
        Dim sum As Long = 0 '放入"乘出來的結果"
        Dim c As Long = 0 '索引
        Dim g As String = "" '放入答案
        Dim remain As Long '放剩下的數字
        Dim carry As Long '進位數字
        For i = Len(a) To 1 Step -1
            For j = Len(b) To 1 Step -1
                sum = num(c) + Mid(a, i, 1) * Mid(a, j, 1)
                remain = sum Mod 10
                carry = sum \ 10
                num(c) = remain
                num(c + 1) = carry '放到下一位在加起來
                c += 1
            Next
        Next
        For k = UBound(num) To 1 Step -1
            g &= num(k)
        Next
        MsgBox(g)
        Me.Close()
    End Sub
End Class
