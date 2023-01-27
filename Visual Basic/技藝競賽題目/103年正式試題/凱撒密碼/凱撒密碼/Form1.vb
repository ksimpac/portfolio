Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call z(1)
        PrintLine(3, "")
        Call z(2)
        Me.Close()
    End Sub
    Sub z(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s As String = Trim(LineInput(fn))
            Dim t As String = y(s)
            PrintLine(3, t)
        Next
    End Sub
    Function y(ByRef str As String)
        Dim a, b As String
        If Microsoft.VisualBasic.Left(str, 1) = 0 Then
            a = Microsoft.VisualBasic.Left(str, 2)
            b = Microsoft.VisualBasic.Right(str, Len(str) - 2)
        Else
            a = Microsoft.VisualBasic.Left(str, 3)
            b = Microsoft.VisualBasic.Right(str, Len(str) - 3)
        End If
        Dim t As String = x(a, b)
        Dim k As String = s(t)
        Return k
    End Function
    Function x(ByVal a As String, ByVal b As String)
        Dim num As String = ""
        Select Case a
            Case "00"
                num &= 0
            Case "01"
                num &= 1
            Case "100"
                num &= 2
        End Select

        If b = "00" Then
            num &= 0
        ElseIf b = "01" Then
            num &= 1
        ElseIf b = "100" Then
            num &= 2
        ElseIf b = "101" Then
            num &= 3
        ElseIf b = "1100" Then
            num &= 4
        ElseIf b = "1101" Then
            num &= 5
        ElseIf b = "11100" Then
            num &= 6
        ElseIf b = "11101" Then
            num &= 7
        ElseIf b = "111100" Then
            num &= 8
        ElseIf b = "111101" Then
            num &= 9
        End If
        Return num
    End Function
    Function s(ByVal num As String)
        Dim a As Integer = AscW("D")
        If num = "01" Then
            Return "D"
        ElseIf num = "24" Then
            Return "A"
        ElseIf num = "25" Then
            Return "B"
        ElseIf num = "26" Then
            Return "C"
        Else
            Return ChrW(a + Val(num - 1))
        End If
    End Function
End Class
