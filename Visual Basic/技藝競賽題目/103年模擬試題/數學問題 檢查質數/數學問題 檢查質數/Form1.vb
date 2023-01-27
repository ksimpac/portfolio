Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim num As Long = 0
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim filereader As String = ""
        Dim flag As Boolean
        For i = 1 To 2
            filereader = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Dim array = Split(filereader, vbCrLf)
            For j = 1 To UBound(array)
                num = array(j)
                flag = count(num)
                If flag = True Then
                    PrintLine(filenum, "Y")
                Else
                    PrintLine(filenum, "N")
                End If
            Next
            If i = 1 Then
                PrintLine(filenum, vbNewLine)
            End If
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
    Private Function count(ByVal a As Long) As Boolean
        Dim flag As Boolean = True
        For i = 2 To a - 1
            If a Mod i <> 0 Then
                flag = True
            Else
                flag = False
                Exit For
            End If
        Next
        If flag = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
