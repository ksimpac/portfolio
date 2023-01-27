Public Class Form1

    Private Sub num1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num1.Click

        Dim x1, y1, x2, y2, x3, y3, x4, y4 As Integer '座標

        x1 = Val(num1.Text) : y1 = Val(num2.Text)
        x2 = Val(num3.Text) : y2 = Val(num4.Text)
        x3 = Val(num5.Text) : y3 = Val(num6.Text)
        x4 = Val(num7.Text) : y4 = Val(num8.Text)

        Dim m1, m2 As Integer '計算線段一跟線段二的斜率

        m1 = (x2 - x1) / (y2 - y1)
        m2 = (x4 - x3) / (y4 - y3)

        If m1 * m2 = -1 Then
            MsgBox("垂直")
        ElseIf m1 = m2 Then
            MsgBox("平行")
        Else
            MsgBox("兩者皆非")
        End If

    End Sub
End Class
