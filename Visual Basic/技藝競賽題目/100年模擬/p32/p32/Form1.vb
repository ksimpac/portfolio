Public Class Form1
    Dim check(,) As Integer : Dim checknum() As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in-3-2-1.txt", OpenMode.Input)
        FileOpen(2, "in-3-2-2.txt", OpenMode.Input)
        FileOpen(3, "out-3-2.txt", OpenMode.Output)

        Call y(1)
        Call y(2)


        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s As String = LineInput(fn) : Dim ascii As String = "" 'ascii十進位與二進位共用
            ascii = AscW(s).ToString '先把字母轉換成ascii碼(十進位)
            ascii = z(ascii) '再轉成二進位
            ReDim check(11, 4) : ReDim checknum(11) : Dim str_num As Integer = 1

            For j = 1 To UBound(checknum)

                Select Case j
                    Case 1, 2, 4, 8
                        Continue For
                    Case Else
                        checknum(j) = Mid(ascii, str_num, 1) : str_num += 1
                        If checknum(j) <> 1 Then Continue For
                        Dim b As String = z(j) : Dim b_str_num As Integer = 1

                        If Len(b) <> 4 Then

                            Do Until Len(b) = 4
                                b = "0" & b
                            Loop

                        End If

                        For k = 1 To Len(b)
                            check(j, k) = Mid(b, b_str_num, 1) : b_str_num += 1
                        Next

                End Select

            Next

            Dim ans As String = "" : Dim one_times As Integer = 0

            For m = 1 To 4

                For n = 1 To 11
                    If check(n, m) = 1 Then one_times += 1
                Next

                If one_times Mod 2 = 0 Then
                    ans &= 0
                Else
                    ans &= 1
                End If

                one_times = 0

            Next


            PrintLine(3, StrReverse(ans)) '我也不知道為什麼會相反

        Next

    End Sub
    Function z(ByVal ascii As Integer)

        Dim s As New List(Of String) : Dim quotient As Integer = 1 : Dim remainder As Integer = 1

        Do Until quotient = 0
            quotient = ascii \ 2
            remainder = ascii Mod 2
            s.Add(remainder)
            ascii = quotient
        Loop

        s.Reverse()

        For i = 0 To s.Count - 1
            ascii &= s.Item(i)
        Next

        Return ascii

    End Function
End Class
