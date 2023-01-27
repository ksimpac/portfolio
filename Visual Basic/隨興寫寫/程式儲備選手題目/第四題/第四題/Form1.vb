Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide() '把表單隱藏

        Dim s As Integer = Val(Trim(InputBox("請輸入公里數")))

        If s - 20 < 0 Then '如果扣掉免費里程的值小於零的話就免費，就不用繼續算下去了！
            s = 0 : MsgBox(0) : Me.Close()
        End If

        s = s - 20

        s = Int(s + 0.5) '用Int函數實現四捨五入法

        Dim i As Integer
        Dim money As Integer = 0 '費用
        Dim hundred_km_money As Integer = 0 '針對100公里的優惠做另外計算

        For i = 21 To s '計算里程費用

            Select Case i
                Case 21 To 50 : money += 8
                Case 51 To 100 : money += 5
                Case Is > 100 : hundred_km_money += 3
            End Select

        Next

        money += Int(hundred_km_money * 0.7 + 0.5) '一樣小數點四捨五入

        MsgBox(money)

        Me.Close() '把表單關閉

    End Sub
End Class
