Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)
        PrintLine(3, "")
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s As String = LineInput(fn)
            Dim data As String = LineInput(fn)
            Dim data1() = Split(data, " ")
            Dim card(5) As Long

            For j = 0 To 5
                card(j) = Val(data1(j))
            Next
            Array.Sort(card)

            Dim score As Long = 0
            Dim a(2) As Long : Dim index As Integer = 0
            For k = 0 To 1
                Dim card1(4) As Long
                card1(0) = card(k)
                card1(1) = card(k + 1)
                card1(2) = card(k + 2)
                card1(3) = card(k + 3)
                card1(4) = card(k + 4)
                score = s(card1)
                a(index) = score
                index += 1
            Next
            Array.Sort(a)
            PrintLine(3, a(2).ToString)
        Next
    End Sub
    Function s(ByVal card() As Long)
        Dim pattern(4) As Long
        Dim score As Long = 0
        For i = 0 To UBound(pattern)
            pattern(i) = (card(i) Mod 13) + 1
        Next
        score = z(card, pattern)
        If score <> 0 Then
            Return score
        End If

        Dim a(4) As String : Dim index As Long = 0
        For j = 0 To 3
            If card(j) = card(j + 1) Then
                a(index) += 1
            Else
                index += 1
            End If
        Next

        Array.Sort(a)
        Dim b As String = ""
        For k = 4 To 0
            If a(k) <> 0 Then
                b &= a(k)
            End If
        Next

        Select Case b
            Case "41" : score = 6
            Case "32" : score = 5
            Case "311" : score = 3
            Case "221" : score = 2
            Case "2111" : score = 1
            Case Else : score = 0
        End Select
        Return score
    End Function
    Function z(ByVal card() As Long, ByVal pattern() As Long) '檢查同花順.順子
        Dim flag, flag1 As Boolean
        For i = 0 To 3
            If pattern(i) = pattern(i + 1) Then
                flag = True
            Else
                flag = False
                Exit For
            End If
        Next

        For j = 0 To 3
            If card(j) + 1 = card(j + 1) Then
                flag1 = True
            Else
                flag = False
                Exit For
            End If
        Next

        If flag = True And flag1 = True Then
            Return 7
        ElseIf flag1 = True And flag1 = False Then
            Return 4
        Else
            Return 0
        End If
    End Function
End Class
