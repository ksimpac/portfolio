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

        Dim data() As String = Split(Trim(filereader), vbCrLf) : Dim searchstr As String = data(0) : Dim freq As Integer = 0

        For i = 1 To UBound(data)

            If data(i) = "EOF" Then Exit For
            If data(i) = "" Then Continue For

            Dim array1() As String = Split(Trim(data(i)), " ")

            For j = 0 To UBound(array1)
                If LCase(array1(j)) = searchstr Then freq += 1
            Next

        Next

        My.Computer.FileSystem.WriteAllText(".\out.txt", freq.ToString & vbCrLf, True)

    End Sub
End Class
