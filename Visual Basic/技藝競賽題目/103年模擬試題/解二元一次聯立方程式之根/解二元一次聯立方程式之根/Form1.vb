Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim a, b, c, d, f, g As Long
        Dim num1 As Long = 0 '分母
        Dim x, y As Long
        Dim check As Long = 0
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Dim array = Split(filereader, vbCrLf)
            For j = 1 To UBound(array)
                Dim data = Split(array(j), ",")
                a = Val(data(0)) : b = Val(data(1)) : c = Val(data(2))
                d = Val(data(3)) : f = Val(data(4)) : g = Val(data(5))
                num1 = (a * f - b * d)
                If a = 0 And b = 0 And c = 0 And d = 0 Then
                    x = 0
                    y = 0
                    PrintLine(filenum, x.ToString() & "," & y.ToString())
                ElseIf a = 0 And f = 0 Then
                    y = c / b
                    x = g / d
                    PrintLine(filenum, x.ToString() & "," & y.ToString())
                ElseIf b = 0 And d = 0 Then
                    x = c / a
                    y = g / f
                    PrintLine(filenum, x.ToString() & "," & y.ToString())
                Else
                    x = (c * f - g * b) / num1
                    y = (a * g - c * d) / num1
                    PrintLine(filenum, x.ToString() & "," & y.ToString())
                    num1 = 0
                    x = 0
                    y = 0
                End If
            Next
            If i = 1 Then
                PrintLine(filenum)
            End If
            num1 = 0
            x = 0
            y = 0
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
End Class
