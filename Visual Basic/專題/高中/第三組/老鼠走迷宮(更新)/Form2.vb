Public Class Form2
    Dim now_index As Integer : Dim road(399) As PictureBox : Dim cheese As Integer : Dim eat_cheese As Integer : Dim time As Integer : Dim plus_time As Integer : Const warp As String = vbCrLf : Dim deduct_time As Integer
    Private Sub Form2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Dim a As Integer = now_index '用來走到牆壁時，儲存原本的位置

        Select Case e.KeyCode '偵測按什麼方向鍵

            Case 37 '左
                now_index -= 1
            Case 38 '上
                now_index -= 19
            Case 39 '右
                now_index += 1
            Case 40 '下
                now_index += 19

        End Select

        road(a).Image = Nothing : road(a).BackColor = Color.White

        If now_index = 379 Then

            Call Walk()

            If eat_cheese = cheese Then '如果cheese吃完的話就結束
                Timer1.Enabled = False : Call Walk() : MsgBox("恭喜您過關了")
                Call ask()
            Else '如果cheese還沒吃完的話再回去吃
                now_index = a : road(now_index).BackColor = Color.Empty : road(now_index).Image = Image.FromFile("哈姆太郎.jpg")
                road(379).BackColor = Color.Empty : road(379).Image = Image.FromFile("exit.jpg") : MsgBox("還沒吃掉所有起司喔!")
            End If

        ElseIf road(now_index).ImageLocation = "" And road(now_index).BackColor = Color.White Then  '如果不是牆壁的話
            Call Walk()
        ElseIf road(now_index).ImageLocation = "cheese.jpg" Then '吃到cheese的話
            eat_cheese += 1 : Call Walk()
            eat_cheese_num.Text = "您" & warp & "已" & warp & "經" & warp & "吃" & warp & "了" & warp & eat_cheese & warp & "個" & warp & "起" & warp & "司"
        ElseIf road(now_index).ImageLocation = "warning.jpg" Then '走到回答問題的區域
            Call Walk() : Call question()
        ElseIf road(now_index).ImageLocation = "tree.jpg" Then '如果是牆壁的話
            now_index = a : road(now_index).Image = Image.FromFile("哈姆太郎.jpg")
        End If

    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

            If MsgBox("離開遊戲?", MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
                e.Cancel = True
            Else
                End
            End If

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Call map_inz()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick '時間計時器

        If time > 0 Then
            time -= 1 : left_time.Text = "剩" & warp & "餘" & warp & "時" & warp & "間" & warp & time & warp & "秒"
        Else
            Timer1.Enabled = False : left_time.Text = "剩" & warp & "餘" & warp & "時" & warp & "間" & warp & time & warp & "秒" : MsgBox("時間到，您還需要多努力！")
            Call ask()
        End If

        If time Mod 60 = 0 And time <> 0 Then
            My.Computer.Audio.Play(Application.StartupPath & "\sound\時針跑的音效.wav", AudioPlayMode.Background)
        ElseIf time = 3 Then
            My.Computer.Audio.Play(Application.StartupPath & "\sound\三秒倒數+時間到音效.wav", AudioPlayMode.Background)
        End If

    End Sub
    Sub Walk() '走路
        road(now_index).ImageLocation = "" : road(now_index).BackColor = Color.Empty : road(now_index).Image = Image.FromFile("哈姆太郎.jpg")
    End Sub
    Sub question()

        Me.Hide() : Timer1.Stop()

        Dim flag As Boolean = False

        Dim s As String = ""

        System.Diagnostics.Process.Start(".\問題.exe")

        '偵測問題.exe有沒有在執行

        Dim processList() As Process
        processList = Process.GetProcesses

        Dim closed As Boolean = False

        Do Until closed = True

            closed = True

            processList = Process.GetProcesses

            For i As Integer = 0 To processList.Length - 1
                If processList(i).ProcessName = "問題" Then
                    closed = False
                    Exit For
                End If
            Next

        Loop

        '----------------------------------------------------

        s = My.Computer.FileSystem.ReadAllText(".\result.txt")

        Select Case Trim(s)
            Case "FALSE"
                flag = False : My.Computer.Audio.Play(Application.StartupPath & "\sound\錯.wav", AudioPlayMode.Background)
            Case "TRUE"
                flag = True : My.Computer.Audio.Play(Application.StartupPath & "\sound\對.wav", AudioPlayMode.Background)
        End Select

        If flag = False Then '答錯的時候

            time -= deduct_time

            Randomize() : Dim num As Integer = Int(Rnd() * 358) + 22

            '隨機丟到一個白色的地方

            Do Until road(num).BackColor = Color.White
                Randomize() : num = Int(Rnd() * 358) + 22
            Loop

            road(now_index).BackColor = Color.White : road(now_index).Image = Nothing : now_index = num : Call Walk()
        Else
            time += plus_time : Call Walk()
        End If

        Me.Show() : Timer1.Start() : My.Computer.FileSystem.WriteAllText(".\result.txt", "", False)



    End Sub
    Public Sub map_inz() '地圖初始化

        Dim i As Integer

        For i = 1 To UBound(road)
            road(i) = Me.Controls("PictureBox" & i) : road(i).BackColor = Color.Empty : road(i).Image = Nothing
            road(i).ImageLocation = ""
        Next

        Randomize() : Dim num As Integer = Int(Rnd() * 5) + 1

        FileOpen(1, ".\map\cheese\map" & num & ".txt", OpenMode.Input)

        Dim n As Integer = LineInput(1) : Dim a As String = "" : Dim times As Integer = 1

        For j = 1 To n

            a = LineInput(1)

            For k = 1 To Len(a)

                Dim b As String = Mid(a, k, 1)

                Select Case b

                    Case "0" '路
                        road(times).BackColor = Color.White : road(times).ImageLocation = ""
                    Case "1", "4" '牆壁
                        road(times).Image = Image.FromFile("tree.jpg") : road(times).ImageLocation = "tree.jpg"
                    Case "7" '答題

                        If Form1.ques = True Then
                            road(times).Image = Image.FromFile("warning.jpg") : road(times).ImageLocation = "warning.jpg"
                        Else
                            road(times).BackColor = Color.White : road(times).ImageLocation = ""
                        End If

                    Case "2" 'cheese
                        road(times).Image = Image.FromFile("cheese.jpg") : road(times).ImageLocation = "cheese.jpg"
                End Select

                times += 1

            Next

        Next

        Call start_exit_time_music_inz()

        FileClose(1)

        plus_time = Form1.plus_time : deduct_time = Form1.deduct_time
        cheese_num.Text = "地" & warp & "圖" & warp & "上" & warp & "有" & warp & cheese & warp & "個" & warp & "起" & warp & "司"
        eat_cheese_num.Text = "您" & warp & "已" & warp & "經" & warp & "吃" & warp & "了" & warp & eat_cheese & warp & "個" & warp & "起" & warp & "司"

    End Sub
    Sub start_exit_time_music_inz() '起點、終點、時間、音樂的初始化

        cheese = Val(LineInput(1)) : eat_cheese = 0 '取得地圖的cheese個數,以及初始化

        road(21).BackColor = Color.Empty
        road(21).Image = Image.FromFile("哈姆太郎.jpg") : now_index = 21 '設定小老鼠的起點(21)

        road(379).BackColor = Color.Empty : road(379).Image = Image.FromFile("exit.jpg")

        time = Form1.game_time + 1 : Timer1.Enabled = True : Timer1.Interval = 1000 : left_time.Text = "剩" & warp & "餘" & warp & "時" & warp & "間" & warp & time - 1 & warp & "秒"

        'My.Computer.Audio.Play(Application.StartupPath & "\sound\背景音樂.wav", AudioPlayMode.BackgroundLoop) '背景音樂(一直播放到終點)

    End Sub
    Sub ask()

        If MsgBox("還想要繼續玩嗎?", MsgBoxStyle.YesNo, "提醒") = MsgBoxResult.Yes Then
            Form1.Show() : Form1.Visible = True : Me.Hide()
        Else

            Select Case MsgBox("離開遊戲?", MsgBoxStyle.OkCancel, "提醒")

                Case MsgBoxResult.Ok : End

                Case MsgBoxResult.Cancel
                    Form1.Show() : Form1.Visible = True : Me.Hide()

            End Select

        End If

    End Sub
End Class