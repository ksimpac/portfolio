Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim a As String = "" : Dim b As String = "" : Dim c() As String : Dim d As String = ""
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Dim array1 = Split(filereader, vbCrLf)
            For j = 1 To UBound(array1) '從第二行開始取資料
                For k = 1 To Len(array1(j)) '從第一個字元檢查數字到最後一個字元
                    b = Mid(array1(j), k, 1)
                    Select Case AscW(b)
                        Case 48 To 57
                            a &= b
                    End Select
                Next
                c = find(a)
                Array.Sort(c)
                For l = 1 To UBound(c)
                    If c(l) <> "" Then
                        If AscW(c(l)) >= 48 And AscW(c(l)) <= 57 Then
                            d &= c(l)
                        End If
                    End If
                Next
                If d <> "" Then
                    PrintLine(filenum, d)
                Else
                    PrintLine(filenum, "N")
                End If
                d = ""
                a = ""
                b = ""
            Next
            If i = 1 Then
                PrintLine(filenum)
            End If
            d = ""
            a = ""
            b = ""
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
    Private Function find(ByVal str As String) '數字字串作排列
        Dim array1(66) As String : Dim array2(66) As String
        Dim index As Integer = 0 'array1的索引
        Dim index1 As Integer = 0 'array2的索引
        Dim a As String = "" : Dim b As String = "" '拿來做比較
        Dim flag As Boolean = False
        For i = 1 To Len(str)
            array1(index) = Mid(str, i, 1)
            index += 1
        Next
        For j = 0 To UBound(array1) '取1到最後的array1
            a = array1(j)
            For k = 0 To UBound(array2) '從一比到最後的array2
                b = array2(k)
                If a = b Then
                    flag = True
                    Exit For
                Else
                    flag = False
                End If
            Next
            If flag = False Then
                array2(index1) = a
                index1 += 1
            End If
        Next
        Return array2
    End Function
End Class
