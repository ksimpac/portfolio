Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide() '把表單隱藏

        Dim s As String = InputBox("請輸入身分證字號")
        s = Trim(s) '去最左和最右的空白(不包刮中間空白)
        Dim a() As String = {"10", "11", "12", "13", "14", "15", "16", "17", "34", "18", "19", "20", "21", "22",
                            "35", "23", "24", "25", "26", "27", "28", "29", "32", "30", "31", "33"} '儲存每個字母對應號碼
        Dim ans As Boolean = False '答案


        s = Replace(s, Microsoft.VisualBasic.Left(s, 1), a(AscW(Microsoft.VisualBasic.Left(s, 1)) - 65)) '把前面子母換成對應號碼

        Dim num As Integer = 0 '計算身分證字號總和

        For i = 1 To Len(s) '計算總和

            Select Case i
                Case 1, 10, 11
                    num += Val(Mid(s, i, 1)) * 1
                Case Else
                    num += Val(Mid(s, i, 1)) * (11 - i)
            End Select

        Next

        If num Mod 10 = 0 Then '能不能被10整除
            ans = True
        Else
            ans = False
        End If

        MsgBox(ans)

        Me.Close() '把表單關閉

    End Sub
End Class
