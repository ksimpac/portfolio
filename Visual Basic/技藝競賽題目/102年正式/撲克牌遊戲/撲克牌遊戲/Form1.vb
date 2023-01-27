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
            Dim pattern(4) As String
            Dim data() As String : Dim card(4) As Integer

            data = Split(LineInput(fn), " ")

            For m = 0 To UBound(data)
                card(m) = Val(data(m))
            Next


            For j = 0 To UBound(pattern)

                If card(j) > 0 And card(j) <= 13 Then
                    pattern(j) = "1"
                ElseIf card(j) > 13 And card(j) <= 26 Then
                    pattern(j) = "2"
                    card(j) = card(j) Mod 13
                ElseIf card(j) > 26 And card(j) <= 39 Then
                    pattern(j) = "3"
                    card(j) = card(j) Mod 13
                Else
                    pattern(j) = "4"
                    card(j) = card(j) Mod 13
                End If

            Next

            '寫一個迴圈把card陣列裡所有的0變13

            For k = 0 To UBound(card)

                If card(k) = 0 Then
                    card(k) = 13
                End If

            Next

            Dim ans As String = ""

            ans = judgeS(card, pattern)

            If ans = "雜牌" Then
                ans = z(card)
                PrintLine(3, ans)
            Else
                PrintLine(3, ans)
            End If
        Next
    End Sub
    Function z(ByVal card() As Integer)
        Dim s(5) As String : Dim index As Integer = 0

        For i = 0 To UBound(card) - 1

            Dim flag As Boolean
            If flag = False Then
                s(index) = "1"
            End If

            If card(i) = card(i + 1) Then
                s(index) += 1
                flag = True
            Else
                If flag = True Then
                    s(index + 1) = 1
                    index += 1
                    flag = False
                Else
                    index += 1
                    s(index) = 1
                    flag = False
                End If
            End If

        Next

        Dim ans As String = ""

        Array.Sort(s) : Array.Reverse(s)

        For j = 0 To UBound(s)
            ans &= s(j)
        Next

        Select Case ans
            Case "311"
                Return "三條"
            Case "41"
                Return "四條"
            Case "32"
                Return "葫蘆"
            Case "221"
                Return "兩對"
            Case "2111"
                Return "一對"
            Case Else
                Return "雜牌"
        End Select
    End Function

    Function judgeS(ByVal card() As Integer, ByVal pattern() As String)
        Dim ss(3), s(3) As Boolean

        Array.Sort(card)

        If card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then
            Dim flag2 As Boolean = True

            For o = 0 To 3
                If pattern(o) = pattern(o + 1) Then s(o) = True
            Next

            For p = 0 To UBound(s)
                If s(p) = False Then
                    flag2 = False
                    Exit For
                End If
            Next

            If flag2 = True Then
                Return "同花順"
            Else
                Return "順子"
            End If
        End If


        For i = 0 To 3
            If Val(card(i) + 1) = Val(card(i + 1)) Then ss(i) = True
            If pattern(i) = pattern(i + 1) Then s(i) = True
        Next

        Dim flag = True : Dim flag1 = True

        For j = 0 To UBound(ss)

            If ss(j) = False Then
                flag = False
                Exit For
            End If

        Next

        For k = 0 To UBound(s)

            If s(k) = False Then
                flag1 = False
                Exit For
            End If

        Next

        If flag = True And flag1 = True Then
            Return "同花順"
        ElseIf flag = True And flag1 = False Then
            Return "順子"
        Else
            Return "雜牌"
        End If

    End Function
End Class
