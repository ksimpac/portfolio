Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim num As Long = 0 : Dim str As String = ""
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Dim array = Split(filereader, vbCrLf)
            For j = 1 To UBound(array) '從第二行開始取資料
                For k = 1 To Len(array(j))
                    If Mid(array(j), k, 1) = " " Then
                    Else
                        num = AscW(Mid(array(j), k, 1))
                        num += 3
                        If num >= 91 Then
                            str &= ChrW(num - 26)
                        Else
                            str &= ChrW(num)
                        End If
                    End If
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
End Class
