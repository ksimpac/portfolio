Public Class Form1
    Public ques As Boolean : Public plus_time As Integer : Public deduct_time As Integer : Public game_time As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        easy.Text = "簡單" : middle.Text = "中等" : hard.Text = "困難" : Me.MaximizeBox = False
    End Sub

    Private Sub easy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles easy.Click
        ques = False : plus_time += 10 : deduct_time = 10 : game_time = 120
        Call call_game()
    End Sub

    Private Sub middle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles middle.Click
        ques = True : plus_time += 7 : deduct_time = 15 : game_time = 140
        Call call_game()
    End Sub

    Private Sub hard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hard.Click
        ques = True : plus_time += 5 : deduct_time = 40 : game_time = 240
        Call call_game()
    End Sub
    Sub call_game()
        Me.Hide() : Me.Visible = False : Call Form2.map_inz() : Form2.Show() : Form2.Visible = True : Form2.MaximizeBox = False
    End Sub
End Class
