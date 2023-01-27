Public Class Form1
    Dim score(5, 3) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim number As Integer = TextBox1.Text : Const a As String = " 分" : Dim avg As Integer = ((score(number, 1) + score(number, 2) + score(number, 3))) / 3

        Chinese.Text = "國文： " & score(number, 1) & a
        English.Text = "英文： " & score(number, 2) & a
        Math.Text = "數學： " & score(number, 3) & a
        Total.Text = "總分： " & (score(number, 1) + score(number, 2) + score(number, 3)).ToString() & a
        Average.Text = "平均： " & avg & a

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        score(1, 1) = 98 : score(1, 2) = 40 : score(1, 3) = 80
        score(2, 1) = 80 : score(2, 2) = 85 : score(2, 3) = 76
        score(3, 1) = 75 : score(3, 2) = 96 : score(3, 3) = 90
        score(4, 1) = 60 : score(4, 2) = 55 : score(4, 3) = 68
        score(5, 1) = 40 : score(5, 2) = 78 : score(5, 3) = 53
    End Sub
End Class
