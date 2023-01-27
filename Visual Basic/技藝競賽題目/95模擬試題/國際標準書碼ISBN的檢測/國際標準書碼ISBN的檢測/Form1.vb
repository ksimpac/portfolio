Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim array = Split(filereader, vbCrLf)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim data As String = "" : Dim isbn As String = ""
        Dim k As String = ""
        Dim m As String = "" : Dim g As Boolean : Dim p As Boolean '檢查
        For i = 0 To UBound(array)
            data = array(i)
            If data = "" Then
            Else
                p = checkisbn(data)
                If p = False Then
                    PrintLine(filenum, "錯誤")
                Else
                    For j = 1 To Len(data)
                        m = Mid(data, j, 1)
                        If m <> " " And m <> "-" Then
                            k &= m
                        End If
                    Next
                    g = checksum(k)
                    If g = True Then
                        PrintLine(filenum, "正確")
                        k = ""
                    Else
                        PrintLine(filenum, "錯誤")
                        k = ""
                    End If
                End If
            End If
        Next
        FileClose(filenum)
        Me.Close()
    End Sub

    Private Function checkisbn(ByVal a As String) As Boolean '檢查資料是否符合格式
        Dim u As String = ""
        For i = 1 To Len(a)
            u = Mid(a, i, 1)
            If AscW(u) >= 48 And AscW(u) <= 57 Then
                Return True
            ElseIf u = " " Or u = "-" Or u = "" Then
            Else
                Return False
                Exit For
            End If
        Next
    End Function
    Private Function checksum(ByVal b As String) As Boolean '檢查最後一個數字是否正確
        Dim sum As Long = 0
        Const last As Long = 11
        Dim a As Long = 0
        For i = 1 To 9
            sum += (last - i) * Val(Mid(b, i, 1))
        Next
        a = sum Mod last
        a = 11 - a
        If a = Val(Mid(b, 10, 1)) Then
            Return True
        ElseIf a = 10 And Mid(b, 10, 1) = "X" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
