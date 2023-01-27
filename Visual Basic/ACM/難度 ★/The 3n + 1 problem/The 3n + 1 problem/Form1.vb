Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        FileOpen(3, "out.txt", OpenMode.Output)
        Call y(Trim(filereader))


        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, "  ") = 0
            filereader = Replace(filereader, "  ", " ")
        Loop

        Dim data() As String = Split(filereader, vbCrLf)

        For I = 0 To UBound(data)

            Dim S() As String = Split(data(I), " ")

            Dim MAX_Cycle_lenght As Integer = 0

            Dim MAX As Integer = Math.Max(Val(S(0)), Val(S(1))) : Dim MIN As Integer = Math.Min(Val(S(0)), Val(S(1)))
            Dim result As New List(Of String)


            For J = MIN To MAX

                Dim N As Integer = J : result.Clear() : result.Add(N)

                Do Until N = 1

                    If N Mod 2 = 1 Then
                        N = 3 * N + 1
                    Else
                        N = N / 2
                    End If

                    result.Add(N)

                Loop

                If result.Count > MAX_Cycle_lenght Then MAX_Cycle_lenght = result.Count


            Next

            PrintLine(3, S(0) & " " & S(1) & " " & MAX_Cycle_lenght.ToString)

        Next

    End Sub
End Class
