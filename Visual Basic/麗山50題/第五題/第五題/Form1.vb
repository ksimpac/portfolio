Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(s)

            If s(i) = "" Then Exit For

            Do Until InStr(s(i), " ") = 0 And InStr(s(i), "％") = 0
                s(i) = Replace(s(i), "％", "%")
                s(i) = Replace(s(i), " ", "")
            Loop

            Dim ss() As String = Split(s(i), "，")

            Dim ans, RATE, Start_Money As Single : Dim N As Integer

            If Val(ss(0)) - Int(Val(ss(0))) = 0 Then
                Start_Money = Val(ss(0))
                N = Val(ss(2))
                RATE = Val(Mid(ss(1), InStr(ss(1), "年利率") + 3, 3)) / 100
                ans = Start_Money * (1 + RATE / 365) ^ N
                My.Computer.FileSystem.WriteAllText(".\out.txt", ans.ToString & "元" & vbCrLf, True)
            Else
                Start_Money = 0
                ans = Val(ss(0))
                N = Val(ss(2))
                RATE = Val(Mid(ss(1), InStr(ss(1), "年利率") + 3, 3)) / 100
                Start_Money = Int(ans / Math.Pow((1 + RATE / 365), N) + 0.5)
                My.Computer.FileSystem.WriteAllText(".\out.txt", Start_Money & "元" & vbCrLf, True)
            End If

            ans = 0 : RATE = 0 : Start_Money = 0 : N = 0

        Next

    End Sub
End Class
