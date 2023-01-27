Public Class Form1

    Public Sub check()
        If TextBox1.Text = "" Then
            MsgBox("三個空格中其中一個是空白的喲!")
        ElseIf TextBox2.Text = "" Then
            MsgBox("三個空格中其中一個是空白的喲!")
        ElseIf TextBox3.Text = "" Then
            MsgBox("三個空格中其中一個是空白的喲!")
        Else
            TextBox4.Text = 17
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call check()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call check()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call check()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call check()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
