Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()

        Dim fib(10) As Integer

        fib(1) = 1
        fib(2) = 1

        For i = 3 To 10
            fib(i) = fib(i - 1) + fib(i - 2)
        Next

        MsgBox(fib(10))

        Me.Close()

    End Sub
End Class
