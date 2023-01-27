Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim pattern As String = "" : Dim num As Integer '花色跟數字
        Dim array2(4) As String : Dim array3(4) As Integer 'array2存花色,array3存數字
        Dim a As Long = 0
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Dim array1 = Split(filereader, vbCrLf)
            For j = 1 To UBound(array1)
                Dim card = Split(array1(j), " ")
                For k = 0 To UBound(card)
                    If card(k) <= 13 Then
                        pattern &= "spade" '黑桃
                    ElseIf card(k) > 13 And card(k) <= 26 Then
                        pattern &= "heart" '紅心
                    ElseIf card(k) > 26 And card(k) <= 39 Then
                        pattern &= "diamond" '方塊
                    ElseIf card(k) > 39 And card(k) <= 52 Then
                        pattern &= "club" '梅花
                    End If
                    array2(k) = pattern
                    num = Val(card(k)) Mod 13
                    If num = 0 Then
                        num = "13"
                    Else
                        num = num.ToString
                    End If
                    array3(k) = num
                    pattern = ""
                    num = 0
                Next
                a = fivecard(array2, array3)
                PrintLine(filenum, a.ToString)
            Next
            PrintLine(filenum)
            ReDim array2(4) : ReDim array3(4)
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
    Private Function fivecard(ByVal card() As String, ByVal num() As Integer)
        Dim times As Long = 0
        Array.Sort(num)
        If card(1) = card(2) And card(2) = card(3) And card(3) = card(4) Then '判斷同花順
            If num(0) = "11" And num(1) = "12" And num(2) = "13" And num(3) = "1" And num(4) = "2" Then
                Return 0
            ElseIf num(0) + 1 = num(1) And num(1) + 1 = num(2) And num(2) + 1 = num(3) And num(3) + 1 = num(4) Then
                Return 7
            End If
        End If
        If num(0) + 1 = num(1) And num(1) + 1 = num(2) And num(2) + 1 = num(3) And num(3) + 1 = num(4) Then '順子
            If num(0) = "11" And num(1) = "12" And num(2) = "13" And num(3) = "1" And num(4) = "2" Then
                Return 0
            Else
                Return 4
            End If
        End If
        If num(0) = num(1) And num(1) = num(2) And num(2) = num(3) Or num(1) = num(2) And num(2) = num(3) And num(3) = num(4) Then '判斷四條
            Return 6
        End If
        If num(0) = num(1) And num(1) = num(2) Then '判斷葫蘆跟三條
            If num(3) = num(4) Then
                Return 5
            Else
                Return 3
            End If
        ElseIf num(1) = num(2) And num(2) = num(3) Then
            Return 3
        ElseIf num(2) = num(3) And num(3) = num(4) Then
            If num(0) = num(1) Then
                Return 5
            Else
                Return 3
            End If
        End If
        For i = 0 To UBound(num) - 1
            If num(i) = num(i + 1) Then
                times += 1
            End If
        Next
        If times = 2 Then
            Return 2
        ElseIf times = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
