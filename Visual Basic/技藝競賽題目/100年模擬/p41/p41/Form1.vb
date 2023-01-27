Public Class Form1
    Dim ans As String : Dim pattern As New List(Of String)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in-4-1-1.txt", OpenMode.Input)
        FileOpen(2, "in-4-1-2.txt", OpenMode.Input)
        FileOpen(3, "out-4-1.txt", OpenMode.Output)

        Call y(1)
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n

            Dim s() As String = Split(LineInput(fn), " ")

            For j = 0 To UBound(s)
                pattern.Add(Mid(s(j), 1, 1))
                s(j) = Replace(s(j), Mid(s(j), 1, 1), "")
            Next

            Dim card(UBound(s)) As Integer

            For k = 0 To UBound(s)
                card(k) = Val(s(k))
            Next

            Call judge(card)

            If ans <> "0" Then
                PrintLine(3, ans)
                Continue For
            End If

            Call fivecard(card)

            PrintLine(3, ans)
        Next

    End Sub

    Sub judge(ByVal card() As Integer)

        Dim flag As Boolean = False : Dim flag1 As Boolean = False 'flag為花色檢查 flag1為數字檢查

        Array.Sort(card)

        For i = 1 To pattern.Count - 1

            If pattern.Item(i - 1) = pattern.Item(i) Then
                flag = True
            Else
                flag = False
                Exit For
            End If

        Next

        If card(0) = 1 And card(1) = 2 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then
            ans = "0"
            Exit Sub
        ElseIf card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 And flag = True Then
            ans = "123456"
            Exit Sub
        ElseIf card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 And flag = False Then
            ans = "12345"
            Exit Sub
        End If

        For j = 1 To UBound(card)

            If card(j) = card(j) + 1 Then
                flag1 = True
            Else
                flag1 = False
                Exit For
            End If

        Next


        If flag = True And flag1 = True Then
            ans = "123456"
        ElseIf flag = False And flag1 = True Then
            ans = "12345"
        Else
            ans = "0"
        End If

    End Sub
    Sub fivecard(ByVal card() As Integer)
        Array.Sort(card)

        If card(0) = 1 And card(1) = 2 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then
            ans = "0"
            Exit Sub
        ElseIf card(0) = 1 And card(1) = 10 And card(2) = 11 And card(3) = 12 And card(4) = 13 Then
            ans = "12345"
            Exit Sub
        End If

        Dim s(UBound(card)) As Integer : Dim index As Integer = 0

        For i = 0 To UBound(card) - 1

            Dim flag As Boolean : If flag = False Then s(index) = 1

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

        Dim sk As String = ""

        Array.Sort(s) : Array.Reverse(s)

        For n = 0 To UBound(s)

            If s(n) <> 0 Then
                sk &= s(n)
            End If

        Next

        Select Case sk
            Case "41"
                ans = "4"
            Case "32"
                ans = "32"
            Case "311"
                ans = "3"
            Case "221"
                ans = "22"
            Case "2111"
                ans = "1"
            Case Else
                ans = "0"
        End Select

    End Sub
End Class
