Public Class Form1
    Dim ans As String : Dim time As Integer : Dim a(4) As RadioButton
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "問題"

        Dim filereader1 As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\questions.txt", System.Text.Encoding.Default)
        Dim filereader2 As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\answers.txt", System.Text.Encoding.Default)
        Dim question() As String = Split(filereader1, vbCrLf)
        Dim answers() As String = Split(filereader2, vbCrLf)

        Randomize()

        Dim num As Integer = Int(Rnd() * question.Length)

        Label1.Text = question(num)

        Dim a() As String = Split(answers(num), ",") : ans = a(0)

        Dim s As New List(Of Integer)

        Do Until s.Count = 4
            num = Int(Rnd() * 4)
            If s.Contains(num) = False Then s.Add(num)
        Loop

        Call initialization() : option1.Text = a(s(0)) : option2.Text = a(s(1)) : option3.Text = a(s(2)) : option4.Text = a(s(3))

        time = 10 : Label2.Text = "剩餘時間：" & time & " " & "秒" : Timer1.Interval = 1000 : Timer1.Enabled = True


    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If time > 0 Then
            time -= 1 : Label2.Text = "剩餘時間：" & time & " " & "秒"
        Else
            Timer1.Enabled = False : Call check()
        End If

    End Sub
    Sub check()

        Label2.Text = "剩餘時間：" & time & " " & "秒"

        My.Computer.FileSystem.WriteAllText(".\result.txt", "", False)

        Dim flag As Boolean : Dim check As String = ""

        For j = 1 To 4
            If a(j).Checked = True Then check = a(j).Text
        Next

        If check = ans Then
            flag = True
        Else
            flag = False
        End If

        My.Computer.FileSystem.WriteAllText(".\result.txt", UCase(flag), False) : End

    End Sub
    Sub initialization()

        For i = 1 To 4
            a(i) = Me.Controls("option" & i)
            a(i).TabStop = False
        Next

    End Sub

    Private Sub reply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reply.Click
        Call check()
    End Sub
End Class
