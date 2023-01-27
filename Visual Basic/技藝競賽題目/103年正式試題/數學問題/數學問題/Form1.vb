Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call z(1)
        PrintLine(3, "")
        Call z(2)

        FileClose(1)
        FileClose(2)
        FileClose(3)
        Me.Close()
    End Sub
    Sub z(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        Dim a, b As Integer
        For i = 1 To n
            Dim s As String = Trim(LineInput(fn))
            Dim array1 = Split(s, ",")
            a = array1(0)
            b = array1(1)
            If a = b + 2 Or b = a + 2 Then
                If y(a, b) = True Then
                    PrintLine(3, "Y")
                Else
                    PrintLine(3, "N")
                End If
            Else
                PrintLine(3, "N")
            End If
        Next
    End Sub
    Function y(ByRef num1 As Integer, ByRef num2 As Integer)
        Dim flag = True
        For i = 2 To num1 - 1
            If num1 Mod i <> 0 Then
                flag = True
            Else
                flag = False
                Return flag
            End If
        Next
        For j = 2 To num2 - 1
            If num2 Mod j <> 0 Then
                flag = True
            Else
                flag = False
                Return flag
            End If
        Next
        Return flag
    End Function
End Class
