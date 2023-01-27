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

            Dim a As String = LineInput(fn)

            If a = "" Then
                a = LineInput(fn)
            End If

            Dim ball(Val(a) + 1) As String

            For j = 1 To Val(a)
                ball(j) = LineInput(fn)
            Next

            Dim array1() As String
            Dim num(Val(a) * 5) As String : Dim index As Integer = 1

            For k = 1 To UBound(ball)

                If ball(k) = "" Then
                    Exit For
                End If

                array1 = Split(ball(k), ",")

                For l = 0 To UBound(array1)

                    num(index) = Trim(array1(l))
                    index += 1

                Next

            Next

            Dim ans As String = ""

            ans = z(num, a)

            PrintLine(3, ans)

        Next

    End Sub

    Function z(ByVal num() As String, ByVal a As String) '檢查重複次數以及回傳次數最多的號碼
        Array.Sort(num)

        Dim array1(UBound(num)) As String : Dim index As Integer = 1 '不重複數字的陣列

        For i = 1 To UBound(num)

            If num(i) = "" Then
                Exit For
            End If

            Dim flag = False '檢查重複 重複為True 不重複反之

            For j = 1 To UBound(array1)

                If num(i) = array1(j) Then
                    flag = True
                    Exit For
                End If

            Next

            If flag = False Then
                array1(index) = num(i)
                index += 1
            End If

        Next

        Dim times(index - 1) As Integer '重複次數

        For j = 1 To index - 1 'array1

            For k = 1 To UBound(num)

                If num(k) = "" Then
                    Exit For
                End If

                If array1(j) = num(k) Then
                    times(j) += 1
                End If

            Next

        Next

        Dim ans As String = ""

        For l = Val(a) To 1 Step -1

            For m = 1 To UBound(times)

                If times(m) = l Then
                    ans &= array1(m)
                    ans &= ", "
                End If

            Next

            If ans <> "" Then

                For n = Len(ans) To 1 Step -1

                    If Mid(ans, n, 1) = "," Then
                        ans = Mid(ans, 1, n - 1)
                        Exit For
                    End If

                Next

                Exit For

            End If

        Next

        Return ans
    End Function
End Class
