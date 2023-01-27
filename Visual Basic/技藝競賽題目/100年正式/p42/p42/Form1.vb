Public Class Form1
    Dim a As New List(Of String) : Dim ss As New List(Of Integer) : Dim ans As Integer
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

        Dim n As Integer = Trim(LineInput(fn))

        For i = 1 To n '一次把牌判斷完

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0
                s = Replace(s, "  ", " ")
            Loop

            a.Add(s)

            Dim data() As String = Split(s, " ")

            Dim card(UBound(data)) As Integer : Dim pattern(UBound(data)) As String

            For j = 0 To UBound(card)
                pattern(j) = Mid(data(j), 1, 1) : card(j) = Val(Replace(data(j), pattern(j), ""))
            Next

            Array.Sort(card) : Call judge(card, pattern)

            If ans <> 0 Then ss.Add(ans) : Continue For

            Call five_card(card) : ss.Add(ans)

        Next

    End Sub
    Sub judge(ByVal card() As Integer, ByVal pattern() As String)

        Dim card_flag As Boolean = True : Dim pattern_flag As Boolean = True

        If card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then '偷懶的方式 (正規應該要如果遇到13 1要變成14 這樣只要用迴圈就好 不需要再用條件判斷牌)

            card_flag = True

        Else

            For i = 1 To UBound(card)
                If card(i) <> card(i - 1) + 1 Then card_flag = False : Exit For
            Next

        End If

        

        For j = 1 To UBound(pattern)
            If pattern(j) <> pattern(j - 1) Then pattern_flag = False : Exit For
        Next

        If card_flag = True And pattern_flag = True Then
            ans = 7
        ElseIf card_flag = True And pattern_flag = False Then
            ans = 4
        Else
            ans = 0
        End If



    End Sub
    Sub five_card(ByVal card() As Integer)

        Dim s(5) As String : s(0) = "1" : Dim index As Integer = 0

        For i = 1 To UBound(card)
            If card(i) = card(i - 1) Then
                s(index) += 1
            Else
                s(index + 1) = 1 : index += 1
            End If
        Next

        Dim a As String = ""

        Array.Sort(s) : Array.Reverse(s)

        For j = 0 To UBound(s)
            a &= s(j)
        Next

        Select Case a
            Case "41" : ans = 6
            Case "32" : ans = 5
            Case "311" : ans = 3
            Case "221" : ans = 2
            Case "2111" : ans = 1
            Case Else : ans = 0
        End Select

    End Sub
End Class
