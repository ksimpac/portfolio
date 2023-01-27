Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, " ") = 0
            filereader = Replace(filereader, " ", "")
        Loop

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(s)

            If s(i) = "" Then Exit For

            Dim ss As String = Mid(s(i), InStr(s(i), "起始時間") + 4, InStr(s(i), "通話時間") - (InStr(s(i), "起始時間") + 4))
            Dim a As String = Mid(s(i), InStr(s(i), "通話時間") + 4, Len(s(i)) - (InStr(s(i), "通話時間") + 4))

            Dim hr, talk_time As Integer

            hr = Val(Mid(ss, 1, InStr(ss, ":")))
            talk_time = Val(a)

            Dim price As Single = 0

            If talk_time <= 5 Then My.Computer.FileSystem.WriteAllText(".\out.txt", "1.7元" & vbCrLf, True)

            If talk_time Mod 5 <> 0 Then

                Do Until talk_time Mod 5 = 0
                    talk_time += 1
                Loop

            End If

            If hr >= 8 And hr <= 18 Then

                If talk_time >= 60 Then
                    price = (talk_time / 5) * 1.7 * 0.85 * 1.04
                Else
                    price = (talk_time / 5) * 1.7 * 1.04
                End If

            Else

                If talk_time >= 60 Then
                    price = (talk_time / 5) * 0.5 * 1.7 * 0.85 * 1.04
                Else
                    price = (talk_time / 5) * 0.5 * 1.7 * 1.04
                End If

            End If

            My.Computer.FileSystem.WriteAllText(".\out.txt", price.ToString & "元" & vbCrLf, True)

        Next

        
    End Sub
End Class
