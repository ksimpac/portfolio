Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(s)

            s(i) = Trim(s(i))

            If s(i) = "" Then Exit For

            Dim lg, ng As Single : Dim N As Long = Val(s(i))
            Dim times As Integer = 0
            lg = N + 1 'lg帶比N大的數字

            Do

                If times = 0 Then
                    ng = 0.5 * (lg + N / lg)
                    times += 1
                    My.Computer.FileSystem.WriteAllText(".\out.txt", "第" & times.ToString & "次逼近" & "，" & "lg=" & lg.ToString & "," & "ng=" & ng.ToString & vbCrLf, True)
                Else
                    lg = ng : ng = 0
                    ng = 0.5 * (lg + N / lg)
                    times += 1
                    My.Computer.FileSystem.WriteAllText(".\out.txt", "第" & times.ToString & "次逼近" & "，" & "lg=" & lg.ToString & "," & "ng=" & ng.ToString & vbCrLf, True)
                End If

            Loop Until Math.Abs(lg - ng) <= 0.005

            My.Computer.FileSystem.WriteAllText(".\out.txt", s(i) & "的平方根為" & ng.ToString & vbCrLf, True) : My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)

        Next

    End Sub
End Class
