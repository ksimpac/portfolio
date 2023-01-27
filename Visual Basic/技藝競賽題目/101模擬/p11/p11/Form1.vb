Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next


        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, "  ") = 0 And InStr(filereader, ", ") = 0 And InStr(filereader, "; ") = 0 And InStr(filereader, ". ") = 0
            filereader = Replace(filereader, "  ", " ") : filereader = Replace(filereader, "; ", " ")
            filereader = Replace(filereader, ". ", " ") : filereader = Replace(filereader, ", ", " ")
        Loop


        Dim data() As String = Split(Trim(filereader), vbCrLf) : Dim num(Val(data(0))) As Integer

        For i = 1 To UBound(data)
            Dim word() As String = Split(data(i), " ") : num(i) = word.Length
        Next

        For j = 1 To UBound(num)
            My.Computer.FileSystem.WriteAllText(".\out.txt", num(j).ToString & vbCrLf, True)
        Next

    End Sub
End Class
