Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim array = Split(filereader, "-----")
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim timetable(), question() As String
        Dim data = Split(filereader, vbCrLf)
        Dim sum As Long '測試到第幾個數字
        Dim aa = "" : Dim bb = ""
        For i = 0 To UBound(data)
            If IsNumeric(data(i)) = True And sum Mod 2 = 1 Then
                For k = i + 1 To i + Val(data(i))
                    question = Split(data(k), ",")
                    For m = 0 To UBound(question)
                        If IsNumeric(question) = True Then
                        Else
                            bb = question(m) & question(m + 1)
                        End If
                    Next
                Next
                sum += 1
            ElseIf IsNumeric(data(i)) = True And sum Mod 2 = 0 Then
                For j = i + 1 To Val(data(i))
                    timetable = Split(data(j), ",")
                    For l = 0 To UBound(timetable)
                        If IsNumeric(timetable(l)) = True Then
                        Else
                            aa = timetable(l) & timetable(l + 1)
                        End If
                    Next
                    sum += 1
                Next
            Else
            End If
        Next
        '開始比較
        If aa = bb Then

        End If
    End Sub
End Class
