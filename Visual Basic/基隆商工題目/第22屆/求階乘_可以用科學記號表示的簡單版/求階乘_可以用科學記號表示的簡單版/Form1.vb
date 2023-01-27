Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim array = Split(filereader, vbCrLf)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim num As Double = 1
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        For i = 0 To UBound(array)
            Select Case Val(array(i))
                Case Is >= 171, Is <= -1
                    PrintLine(filenum, "Error")
                Case Is = 0
                    PrintLine(filenum, 1.ToString())
                Case Else
                    For j = 1 To Val(array(i))
                        num *= j
                    Next
                    PrintLine(filenum, num.ToString())
            End Select
            num = 1
        Next
        Me.Close()
    End Sub
End Class
