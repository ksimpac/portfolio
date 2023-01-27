Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Dim array = Split(filereader, vbCrLf)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim num As Double
        Dim j As Integer
        For i = 0 To UBound(array)
            For j = 1 To Val(array(i))
                num += 2 ^ j
            Next
            PrintLine(filenum, num.ToString())
            num = 0
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
End Class
