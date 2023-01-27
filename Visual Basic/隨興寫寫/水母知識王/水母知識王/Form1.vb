Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        title.Text = "請問水母沒有研究哪一個東西?"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ans4.Checked = True Then
            MsgBox("妳答對了!!!!")
        Else
            MsgBox("妳答錯了，妳還不夠了解水母喔!")
        End If
    End Sub
End Class
