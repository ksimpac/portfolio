
Public Class Form1
    Dim num(5) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 1 To 5
            num(i) = Int(Rnd() * 90) + 10
        Next

        num1.Text = num(1) : num2.Text = num(2) : num3.Text = num(3) : num4.Text = num(4) : num5.Text = num(5) : Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        num1.Text = "" : num2.Text = "" : num3.Text = "" : num4.Text = "" : num5.Text = "" : Timer1.Stop() : Call check()
    End Sub
    Sub check()

        Dim ans As Integer = 0

        For i = 1 To 5
            ans = InputBox("第" & i & "個數字為：", "輸入答案")
            If ans = num(i) Then
                MsgBox("答對了，你是金頭腦！", , "恭喜")
            Else
                MsgBox("答錯了，要補充DHA哦！", , "再挑戰")
            End If
        Next

    End Sub
End Class
