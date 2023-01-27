Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        title.Text = "請問水母腦袋是不是都裝水呢?"
        tips.Text = "答案只有是或不是，沒有其他答案喲！"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim answer As String = ans.Text

        If answer = "是" Then
            MsgBox("妳不誠實喔~ 小心鼻子變長 :P", 48, "水母神回復")
        ElseIf answer = "不是" Then
            MsgBox("妳最誠實了 給妳口頭獎勵一次", 48, "水母神回復")
        Else
            MsgBox("不要亂打!!!", 48, "水母警告妳")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ans.Text = ""
    End Sub
End Class
