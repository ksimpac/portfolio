Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Call y(filereader)
            My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        filereader = Replace(filereader, vbCrLf, " ")

        Do Until InStr(filereader, "  ") = 0
            filereader = Replace(filereader, "  ", " ")
        Loop

        Dim data() = Split(filereader, " ") : Array.Sort(data)
        Dim times(200) As Integer : Dim index As Integer = 1

        For i = 0 To UBound(data) - 1

            If LCase(data(i)) = LCase(data(i + 1)) Then
                times(index) += 1
            Else
                times(index) += 1
                index += 1
            End If

        Next

        Array.Sort(times) : Array.Reverse(times)

        Dim ans As String = ""

        For j = 0 To 2

            If j <> 2 Then
                ans &= times(j) & ","
            Else
                ans &= times(j)
            End If

        Next

        My.Computer.FileSystem.WriteAllText(".\out.txt", ans & vbCrLf, True)

    End Sub
End Class
