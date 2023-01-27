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
            Dim sum As String = "" : Dim num As String = LineInput(fn)

            If sum = "" Then sum = "1"

            For j = 2 To Val(num)
                sum = (z(sum, j))
            Next

            PrintLine(3, sum)
        Next
    End Sub
    Function z(ByVal sum As String, ByVal num As String)
        Dim a(Len(sum)), b(Len(num)) As String
        Dim s As Long = 1

        For i = 1 To Len(sum)
            a(i) = Mid(sum, i, 1)
        Next

        For j = 1 To Len(num)
            b(j) = Mid(num, j, 1)
        Next

        Dim s2 As Long = 1
        Dim fk As Long = Len(sum) + Len(num)
        Dim c(fk) As Integer

        For k = UBound(b) To 1 Step -1
            For l = UBound(a) To 1 Step -1
                c(s) = c(s) + Val(a(l)) * Val(b(k))

                If c(s) > 9 Then
                    c(s + 1) += c(s) \ 10
                    c(s) = c(s) Mod 10
                End If
                s += 1
            Next
            s = s2 + 1 : s2 += 1
        Next

        Dim d As String = ""

        For n = UBound(c) To 1 Step -1
            If c(n) <> 0 Then
                For mm = n To 1 Step -1
                    d &= c(mm)
                Next
                Exit For
            End If
        Next
        Return d
    End Function
End Class