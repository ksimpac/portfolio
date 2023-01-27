Public Class Form1
    Dim ans As String
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
            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0
                s = Replace(s, "  ", " ")
            Loop

            Dim data() As String = Split(s, " – ") : Dim card(4), pattern(4) As Integer : Dim index As Integer = 0
            Dim num As Integer = 0

            For j = 0 To UBound(data)

                Dim array1() As String = Split(data(j), " ")

                For k = 0 To UBound(array1)

                    pattern(index) = Val(array1(k)) \ 14

                    If Val(array1(k)) Mod 13 = 0 Then
                        card(index) = 13
                    Else
                        card(index) = Val(array1(k)) Mod 13
                    End If

                    index += 1

                    If j = 0 And k = UBound(array1) Then

                        Array.Sort(card) : Array.Reverse(card)

                        For p = 0 To index - 1

                            If j = 0 And card(p) Mod 13 >= 10 Or card(p) Mod 13 = 0 Then
                                num += 10
                            ElseIf j = 0 And card(p) Mod 13 = 1 Then

                                If num + 11 <= 21 Then
                                    num += 11
                                Else
                                    num += 1
                                End If
                            ElseIf j = 0 And Val(card(p)) Mod 13 <> 0 Then
                                num += card(p) Mod 13
                            End If

                        Next

                    End If

                Next

                

            Next

            ans = ""

            Array.Sort(card)

            Call judge(card, pattern)

            If ans <> "雜牌" And num <= 21 Then
                PrintLine(3, num.ToString & ", " & ans) : Continue For
            ElseIf ans <> "雜牌" And num > 21 Then
                PrintLine(3, "F" & ", " & ans) : Continue For
            End If

            Call five_card(card)

            If num <= 21 Then
                PrintLine(3, num.ToString & ", " & ans)
            Else
                PrintLine(3, "F" & ", " & ans)
            End If


        Next

    End Sub
    Sub judge(ByVal card() As Integer, ByVal pattern() As Integer)

        Dim card_flag As Boolean = True : Dim pattern_flag As Boolean = True

        If card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then
            card_flag = True
        Else
            For i = 1 To UBound(card)
                If card(i) - 1 <> card(i - 1) Then card_flag = False : Exit For
            Next

        End If

        For j = 1 To UBound(pattern)
            If pattern(j) <> pattern(j - 1) Then pattern_flag = False : Exit For
        Next

        If card_flag = True And pattern_flag = True Then
            ans = "同花順"
        ElseIf card_flag = True And pattern_flag = False Then
            ans = "順子"
        Else
            ans = "雜牌"
        End If

    End Sub
    Sub five_card(ByVal card() As Integer)
        Dim s(4) As String : Dim index As Integer = 0
        s(0) = 1

        For i = 1 To UBound(card)

            If card(i) = card(i - 1) Then
                s(index) += 1
            Else
                s(index + 1) = 1
                index += 1
            End If

        Next

        Array.Sort(s) : Array.Reverse(s)

        Dim ss As String = ""

        For j = 0 To UBound(s)
            ss &= s(j)
        Next

        Select Case ss
            Case "41" : ans = "四條"
            Case "32" : ans = "葫蘆"
            Case "311" : ans = "三條"
            Case "221" : ans = "兩對"
            Case "2111" : ans = "一對"
            Case Else : ans = "雜牌"
        End Select

    End Sub
End Class
