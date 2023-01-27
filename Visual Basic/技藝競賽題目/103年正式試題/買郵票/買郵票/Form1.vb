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

        Dim a, b, c, d As Integer
        Dim x, y, num1 As Integer
        For i = 1 To n
            Dim s As String = Trim(LineInput(fn))
            Dim array1 = Split(s, ",")
            a = array1(0)
            b = array1(1)
            c = array1(2)
            d = array1(3)
            num1 = b * 1 - c * 1
            If num1 = 0 Then
                If (d * 1 - a * c) / num1 = 0 Then
                    x = 0
                    y = d / c
                    PrintLine(3, x & "," & y)
                ElseIf (b * a - d * 1) / num1 = 0 Then
                    y = 0
                    x = d / b
                    PrintLine(3, x & "," & y)
                End If
            Else
                x = (d * 1 - a * c) / num1
                y = (b * a - d * 1) / num1
                PrintLine(3, x & "," & y)
            End If
        Next
    End Sub
End Class
