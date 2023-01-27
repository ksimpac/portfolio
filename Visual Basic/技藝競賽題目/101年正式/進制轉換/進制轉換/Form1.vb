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

            Dim s As String = Trim(LineInput(fn))
            Dim Octal, Hexadecimal As String '八進位,十六進位
            Dim s1 As String = ""
            Dim sum As Integer = 0
            Dim num As Integer = Len(s) - 1 '次方

            For k = 1 To Len(s)
                sum += Val(Mid(s, k, 1)) * 2 ^ num
                num -= 1
            Next

            Hexadecimal = Hex(sum)

            s1 = Trim(s)

            Do Until Len(s) Mod 3 = 0
                s = "0" & s
            Loop


            If Microsoft.VisualBasic.Left(s, 3) = "000" Then Octal &= "0"

            Do Until Len(s1) Mod 4 = 0
                s1 = "0" & s1
            Loop

            If Microsoft.VisualBasic.Left(s1, 4) = "0000" Then Hexadecimal = "0" & Hexadecimal

            Octal &= z(sum)

            PrintLine(3, Hexadecimal & "," & Octal)

            Hexadecimal = "" : Octal = ""

        Next

    End Sub
    Function z(ByVal num As Integer) '十進位轉八進位

        Dim Quotient, Remainder(999) As Integer : Dim index As Integer = 0 '商數與餘數

        Quotient = 1

        Do Until Quotient = 0
            Quotient = num \ 8
            Remainder(index) = num Mod 8
            num = Quotient
            index += 1
        Loop

        Dim str As String = ""

        For i = 0 To index - 1
            str &= Remainder(i)
        Next

        Return StrReverse(str)

    End Function
End Class
