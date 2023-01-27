Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim array = Split(filereader, vbCrLf)
        For j = 0 To UBound(array)
            If Val(array(j)) = 1 Then
                PrintLine(filenum, "Not Prime")
            Else
                For k = 2 To Val(array(j)) - 1
                    If array(j) Mod k <> 0 Then
                        PrintLine(filenum, "Prime")
                        Exit For
                    Else
                        PrintLine(filenum, "Not Prime")
                        Exit For
                    End If
                Next
            End If
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
End Class
