Public Class Form1
    Dim hamming_code(21) As Integer : Dim check(,) As Integer
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
            Dim s As String = LineInput(fn) : Dim aa As String = hex_to_bin(s)
            Dim strnum As Integer = 1 : ReDim check(21, 5)

            For j = 1 To 21

                Select Case j
                    Case 1, 2, 4, 8, 16
                        Continue For
                    Case Else
                        hamming_code(j) = Mid(aa, strnum, 1) : strnum += 1
                End Select

            Next

            For k = 1 To 21

                Dim ff As String = ""

                If hamming_code(k) = 1 Then

                    ff = dec_to_bin(k)

                    For m = 1 To 5
                        check(k, m) = Mid(ff, m, 1)
                    Next

                End If

            Next

            Dim ans As String = ""

            For o = 1 To 5

                Dim loopnum As Integer = 1 : Dim times As Integer = 0

                Do Until loopnum = 22
                    If check(loopnum, o) = 1 Then times += 1 '計算1個個數
                    loopnum += 1
                Loop

                If times Mod 2 = 0 Then
                    ans = ans & "0"
                Else
                    ans = ans & "1"
                End If

            Next

            PrintLine(3, StrReverse(ans))

        Next

    End Sub
    Function hex_to_bin(ByVal num As String) '十六進位轉二進位
        Dim sss As String = ""

        For i = 1 To Len(num)
            Select Case Mid(num, i, 1)
                Case "0" : sss &= "0000"
                Case "1" : sss &= "0001"
                Case "2" : sss &= "0010"
                Case "3" : sss &= "0011"
                Case "4" : sss &= "0100"
                Case "5" : sss &= "0101"
                Case "6" : sss &= "0110"
                Case "7" : sss &= "0111"
                Case "8" : sss &= "1000"
                Case "9" : sss &= "1001"
                Case "A" : sss &= "1010"
                Case "B" : sss &= "1011"
                Case "C" : sss &= "1100"
                Case "D" : sss &= "1101"
                Case "E" : sss &= "1110"
                Case "F" : sss &= "1111"
            End Select
        Next

        Return sss

    End Function
    Function dec_to_bin(ByVal num As Integer) '十進位轉二進位

        Dim quotient As Integer = 1 : Dim remainder As Integer : Dim a As String = ""

        Do Until quotient = 0 '模擬短除法
            remainder = num Mod 2 : a &= remainder : quotient = num \ 2 : num = quotient
        Loop

        a = StrReverse(a) '因為短除法除完後是由下往上取餘數

        If Len(a) <> 5 Then '補足五個數字

            Do Until Len(a) = 5
                a = "0" & a
            Loop

        End If



        Return a

    End Function
End Class
