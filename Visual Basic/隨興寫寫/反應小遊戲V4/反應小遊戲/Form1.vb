Public Class Form1
    Dim reaction_time As New Stopwatch '計算時間(毫秒)
    Dim times As Integer = 0 '計算次數(只計算開程式到關閉程式之前)
    Dim ms As New List(Of Integer) '存放反應時間
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

        If switch_time.Enabled = False Then '當計時器沒啟動時(表示還沒按下開始)
            Me.BackColor = Color.Red : reaction_time.Reset() : btn_click.Enabled = True
            Randomize() : Dim a As Integer = Int(Rnd() * 10) + 1
            switch_time.Interval = a * 1000 : switch_time.Start()
        Else
            switch_time.Enabled = False : MsgBox("已經開始嚕，請注意！") : switch_time.Enabled = True
        End If

    End Sub

    Private Sub switch_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles switch_time.Tick
        btn_click.Enabled = True : Me.BackColor = Color.Green : reaction_time.Start()
    End Sub

    Private Sub btn_click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_click.Click

        If Me.BackColor <> Color.Green Then

            If Me.BackColor = Color.Red Then
                switch_time.Enabled = False : MsgBox("您有紅綠色盲嗎？") : switch_time.Enabled = True
            Else
                MsgBox("您還沒按下開始喔！") '第一次開不會變色
            End If

        Else
            reaction_time.Stop()
            Dim time As Integer = reaction_time.ElapsedMilliseconds - 1 '減一是因為計時器不能設0

            ms.Add(time)

            Const str As String = "ms (毫秒)"
            Dim sum As Integer = 0 '計算反應時間總和
            Dim average As Integer = 0 '計算平均反應時間

            For i = 0 To ms.Count - 1
                sum += ms.Item(i)
            Next

            average = sum / ms.Count

            times += 1 : MsgBox(time & str & vbCrLf & "您玩了：" & times & "次" & vbCrLf & "平均反應時間：" & average & str)
            btn_click.Enabled = False : switch_time.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
