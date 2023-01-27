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
            Dim str1 As String = StrReverse(LineInput(fn))
            Dim str2 As String = StrReverse(LineInput(fn))
            Dim num1(101) As Integer : Dim num2(101) As Integer
            Dim sum(102) As Integer
            For j = 1 To Len(str1)
                num1(j) = Val(Mid(str1, j, 1))
            Next

            For k = 1 To Len(str2)
                num2(k) = Val(Mid(str2, k, 1))
            Next
            '進位處理
            Dim temp = 0
            For l = 1 To UBound(sum) - 1
                sum(l) = num1(l) + num2(l) + temp
                If sum(l) > 9 Then
                    temp = 1
                    sum(l) = sum(l) Mod 10
                Else
                    temp = 0
                End If
            Next

            Dim a As String = ""

            For m = UBound(sum) To 1 Step -1
                a &= sum(m)
            Next


            Dim s As Long = 1
            Do Until Mid(a, s, 1) <> 0
                s += 1
            Loop
            Dim b As String = Microsoft.VisualBasic.Right(a, 103 - s)
            PrintLine(3, b)
        Next
    End Sub
End Class
