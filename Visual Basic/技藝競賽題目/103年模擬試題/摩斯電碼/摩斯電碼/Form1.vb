Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim str As String = ""
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Dim array = Split(filereader, vbCrLf)
            For j = 1 To UBound(array)
                Dim data = Split(array(j), " ")
                For k = 0 To UBound(data)
                    str &= tra(data(k))
                Next
                PrintLine(filenum, str)
                str = ""
            Next
            If i = 1 Then
                PrintLine(filenum, vbCrLf)
            End If
        Next
        FileClose(filenum)
        Me.Close()
    End Sub

    Private Function tra(ByVal a As String)
        Select Case a
            Case Is = ".-"
                Return "A"
            Case Is = "-..."
                Return "B"
            Case Is = "-.-."
                Return "C"
            Case Is = "-.."
                Return "D"
            Case Is = "."
                Return "E"
            Case Is = "..-."
                Return "F"
            Case Is = "--."
                Return "G"
            Case Is = "...."
                Return "H"
            Case Is = ".."
                Return "I"
            Case Is = ".---"
                Return "J"
            Case Is = "-.-"
                Return "K"
            Case Is = ".-.."
                Return "L"
            Case Is = "--"
                Return "M"
            Case Is = "-."
                Return "N"
            Case Is = "---"
                Return "O"
            Case Is = ".--."
                Return "P"
            Case Is = "--.-"
                Return "Q"
            Case Is = ".-."
                Return "R"
            Case Is = "..."
                Return "S"
            Case Is = "-"
                Return "T"
            Case Is = "..-"
                Return "U"
            Case Is = "...-"
                Return "V"
            Case Is = ".--"
                Return "W"
            Case Is = "-..-"
                Return "X"
            Case Is = "-.--"
                Return "Y"
            Case Is = "--.."
                Return "Z"
        End Select
    End Function
End Class
