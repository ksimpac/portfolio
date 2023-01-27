Public Class Form1
    Dim corrent_ans As Integer : Dim current_ans As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "心算遊戲"
        Lb_plus.Text = "+"
        Lb_equal.Text = "="
        tip.Text = ""
        ans.Enabled = False
        Call random()

    End Sub
    Sub random()

        Randomize()
        Dim num1, num2 As Integer

        num1 = Int(Rnd() * 9000) + 1000
        num2 = Int(Rnd() * 9000) + 1000
        corrent_ans = num1 + num2
        lb1.Text = num1.ToString
        lb2.Text = num2.ToString
        countdown.Start() : ans.Text = "" : ans.Enabled = True

    End Sub

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick

        countdown.Stop()
        ans.Enabled = False
        Dim flag As Integer = 0
        Call show_ans(flag)

    End Sub
    Sub show_ans(ByVal flag As Integer)

        countdown.Stop()

        If flag = 1 Then
            tip.Text = "答錯了，答案是" & corrent_ans.ToString
        Else
            tip.Text = "時間到，答案是" & corrent_ans.ToString
        End If

        showtime.Start()

    End Sub

    Private Sub showtime_Tick(sender As Object, e As EventArgs) Handles showtime.Tick
        tip.Text = "" : Call random() : showtime.Stop()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("離開遊戲?", MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If

    End Sub

    Private Sub ans_KeyDown(sender As Object, e As KeyEventArgs) Handles ans.KeyDown

        If e.KeyCode <> Keys.Enter Then Exit Sub

        ans.Enabled = False : current_ans = Val(ans.Text)

        Dim a As String = ans.Text

        For i = 1 To Len(a)

            If (AscW(Mid(a, i, 1)) < 48 OrElse AscW(Mid(a, i, 1)) > 57) Then
                tip.Text = "請重新輸入" : ans.Text = ""
                ans.Enabled = True : Exit Sub
            End If

        Next

        If current_ans = corrent_ans Then
            tip.Text = "答對了!" : showtime.Start()
        Else
            Dim flag As Integer = 1
            Call show_ans(flag)
        End If

    End Sub
End Class
