Public Class Form2

    Dim pic(72) As PictureBox : Dim count As Integer : Dim times As Integer : Dim num As New List(Of Integer) : Const warp As String = vbCrLf
    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click '開始遊戲

        Call inz()

        times = 60 : count = 0

        time.Text = "時" & warp & "間" & warp & ":" & warp & times & warp & "秒"
        score.Text = "分" & warp & "數" & warp & ":" & warp & count & warp & "分"

        Timer1.Interval = Form1.show_time : Timer2.Interval = 1000 : Timer3.Interval = Form1.hide_time
        Timer3.Enabled = True : Timer2.Enabled = True : Timer1.Enabled = True
        Timer1.Start() : Timer2.Start()
        start.Enabled = False
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '初始化
        Call inz()
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("離開遊戲?", MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick '出現老鼠
        Randomize() : Dim a As Integer = Int(Rnd() * 72) + 1
        If num.IndexOf(a) = -1 Then num.Add(a)
        pic(a).Image = Image.FromFile(Application.StartupPath & "\地鼠.jpg") : pic(a).ImageLocation = Application.StartupPath & "\地鼠.jpg"
        Timer3.Start() : Timer3.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick '計算秒數

        If times > 0 Then
            times -= 1
            time.Text = "時" & warp & "間" & warp & ":" & warp & times & warp & "秒"
        Else

            Timer1.Enabled = False
            time.Text = "時" & warp & "間" & warp & ":" & warp & times & warp & "秒"
            Timer2.Enabled = False : start.Enabled = True
            Timer3.Enabled = False : MsgBox("時間到")

            Select Case count
                Case Is < 60
                    MsgBox("請在加油")
                Case Is >= 60
                    MsgBox("不錯")
            End Select

            If MsgBox("還想要繼續玩嗎?", MsgBoxStyle.YesNo, "提醒") = MsgBoxResult.Yes Then
                Form1.Show() : Form1.Visible = True : Me.Hide() : Me.Visible = False
            Else

                If MsgBox("離開遊戲?", MsgBoxStyle.OkCancel, "提醒") = MsgBoxResult.Ok Then
                    End
                Else
                    Form1.Show() : Form1.Visible = True : Me.Hide() : Me.Visible = False
                End If

            End If

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick '隱藏老鼠
        Dim a As Integer = num(0) : num.RemoveAt(num.IndexOf(a))
        pic(a).Image = Nothing
        pic(a).ImageLocation = ""
        Timer3.Stop() : Timer3.Enabled = False
    End Sub
    Sub get_count(ByVal i As Integer)

        My.Computer.Audio.Play(Application.StartupPath & "\weav_sound.wav", AudioPlayMode.Background)

        If pic(i).ImageLocation = "" And Timer2.Enabled = True Then
            count -= Form1.deduct
        ElseIf pic(i).ImageLocation <> "" And Timer2.Enabled = True Then
            pic(i).ImageLocation = "" : pic(i).Image = Nothing
            count += Form1.plus
        End If

        score.Text = "分" & warp & "數" & warp & ":" & warp & count & warp & "分"

    End Sub
    Public Sub inz()

        Dim i As Integer

        For i = 1 To 72
            pic(i) = Me.Controls("PictureBox" & i) : pic(i).Image = Nothing
            pic(i).ImageLocation = ""
        Next

        time.Text = "時" & warp & "間" & warp & ":" & warp & times & warp & "秒"
        score.Text = "分" & warp & "數" & warp & ":" & warp & count & warp & "分"
        Me.Cursor = New Cursor(".\劍.cur")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        get_count(1)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        get_count(2)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        get_count(3)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        get_count(4)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        get_count(5)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        get_count(6)
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        get_count(7)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        get_count(8)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        get_count(9)
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        get_count(10)
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        get_count(11)
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        get_count(12)
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        get_count(13)
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        get_count(14)
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        get_count(15)
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        get_count(16)
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        get_count(17)
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        get_count(18)
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        get_count(19)
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        get_count(20)
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        get_count(21)
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        get_count(22)
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        get_count(23)
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        get_count(24)
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        get_count(25)
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        get_count(26)
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        get_count(27)
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        get_count(28)
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        get_count(29)
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        get_count(30)
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        get_count(31)
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        get_count(32)
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        get_count(33)
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        get_count(34)
    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        get_count(35)
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        get_count(36)
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        get_count(37)
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        get_count(38)
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        get_count(39)
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        get_count(40)
    End Sub

    Private Sub PictureBox41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox41.Click
        get_count(41)
    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click
        get_count(42)
    End Sub

    Private Sub PictureBox43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox43.Click
        get_count(43)
    End Sub

    Private Sub PictureBox44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.Click
        get_count(44)
    End Sub

    Private Sub PictureBox45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox45.Click
        get_count(45)
    End Sub

    Private Sub PictureBox46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.Click
        get_count(46)
    End Sub

    Private Sub PictureBox47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox47.Click
        get_count(47)
    End Sub

    Private Sub PictureBox48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.Click
        get_count(48)
    End Sub

    Private Sub PictureBox49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox49.Click
        get_count(49)
    End Sub

    Private Sub PictureBox50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.Click
        get_count(50)
    End Sub

    Private Sub PictureBox51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox51.Click
        get_count(51)
    End Sub

    Private Sub PictureBox52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.Click
        get_count(52)
    End Sub

    Private Sub PictureBox53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox53.Click
        get_count(53)
    End Sub

    Private Sub PictureBox54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.Click
        get_count(54)
    End Sub

    Private Sub PictureBox55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox55.Click
        get_count(55)
    End Sub

    Private Sub PictureBox56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.Click
        get_count(56)
    End Sub

    Private Sub PictureBox57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox57.Click
        get_count(57)
    End Sub

    Private Sub PictureBox58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox58.Click
        get_count(58)
    End Sub

    Private Sub PictureBox59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox59.Click
        get_count(59)
    End Sub

    Private Sub PictureBox60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.Click
        get_count(60)
    End Sub

    Private Sub PictureBox61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox61.Click
        get_count(61)
    End Sub

    Private Sub PictureBox62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.Click
        get_count(62)
    End Sub

    Private Sub PictureBox63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox63.Click
        get_count(63)
    End Sub

    Private Sub PictureBox64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox64.Click
        get_count(64)
    End Sub

    Private Sub PictureBox65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox65.Click
        get_count(65)
    End Sub

    Private Sub PictureBox66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.Click
        get_count(66)
    End Sub

    Private Sub PictureBox67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox67.Click
        get_count(67)
    End Sub

    Private Sub PictureBox68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.Click
        get_count(68)
    End Sub

    Private Sub PictureBox69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox69.Click
        get_count(69)
    End Sub

    Private Sub PictureBox70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox70.Click
        get_count(70)
    End Sub

    Private Sub PictureBox71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox71.Click
        get_count(71)
    End Sub

    Private Sub PictureBox72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox72.Click
        get_count(72)
    End Sub
End Class