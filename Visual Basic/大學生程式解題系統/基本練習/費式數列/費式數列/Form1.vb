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
            Dim fibfindnum As Integer = LineInput(fn)
            Dim fib(48) As Long
            fib(0) = 0 : fib(1) = 1
            For j = 2 To 48
                fib(j) = fib(j - 2) + fib(j - 1)
            Next
            PrintLine(3, fib(fibfindnum).ToString)
        Next
    End Sub
End Class
