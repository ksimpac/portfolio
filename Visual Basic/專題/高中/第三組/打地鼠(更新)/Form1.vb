Public Class Form1
    Public deduct As Integer : Public show_time As Integer : Public hide_time As Integer : Public plus As Integer
    'deduct 扣分 show_time 老鼠顯示在表單上的時間 hide_time 多少時間後老鼠隱藏 plus 加分
    '單位請用ms(毫秒) 1 second = 1000 millisecond ; 1(s) = 1000(ms)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        easy.Text = "簡單" : middle.Text = "中等" : hard.Text = "困難" : Me.MaximizeBox = False
    End Sub
    Private Sub easy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles easy.Click
        deduct = 0 : show_time = 2000 : hide_time = 4000 : plus = 5
        Call call_game()
    End Sub

    Private Sub middle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles middle.Click
        deduct = 1 : show_time = 1000 : hide_time = 2000 : plus = 2
        Call call_game()
    End Sub

    Private Sub hard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hard.Click
        deduct = 5 : show_time = 500 : hide_time = 1000 : plus = 1
        Call call_game()
    End Sub
    Sub call_game()
        Me.Hide() : Me.Visible = False : Form2.inz() : Form2.Show() : Form2.Visible = True : Form2.MaximizeBox = False
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("關閉視窗?", MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If

    End Sub
End Class
