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
            Dim data As String = LineInput(fn)
            Dim s() As String : s = Split(data, " ")
            Dim sum As Long = 0
            Dim ab As Integer = Len(s(1)) - 1 '次方
            If s(0) > 10 Then
                sum = z(s(1), s(0))
            Else
                For k = 1 To Len(s(1))
                    sum += Val(Mid(s(1), k, 1)) * s(0) ^ ab
                    ab -= 1
                Next
            End If

            Dim ans As String = ""

            If s(2) = "8" Then
                ans = x(sum)
            ElseIf s(2) = "16" Then
                ans = Hex(sum)
            End If
            PrintLine(3, ans)
        Next
    End Sub
    Function x(ByVal num As Integer) '8進位
        Dim Quotient As Integer = 0
        Dim Remainder(99999) As Integer : Dim index As Integer = 0
        Dim ans As String = ""
        Do
            Quotient = num \ 8 : Remainder(index) = num Mod 8

            If Quotient = 0 Then
                For i = index To 0 Step -1
                    ans &= Remainder(i)
                Next
                Exit Do
            Else
                num = Quotient
                index += 1
            End If
        Loop

        Return ans
    End Function
    Function z(ByVal data As String, ByVal b As Integer) '其他進位制換算十進位
        Dim sum As Integer
        Dim a As String
        Dim ab As Integer = Len(data) - 1 '次方

        For i = 1 To Len(data)
            a = Mid(data, i, 1)
            If IsNumeric(a) = True Then
                sum += Val(a) * b ^ ab
                ab -= 1
            Else
                sum += (AscW(a) - 55) * b ^ ab
                ab -= 1
            End If
        Next
        Return sum
    End Function
End Class