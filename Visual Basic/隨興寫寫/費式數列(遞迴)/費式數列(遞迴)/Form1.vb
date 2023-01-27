Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()

        MsgBox(Fib(10))

        Me.Close()

    End Sub
    Function Fib(ByVal i As Integer) As Integer
        If i = 1 Or i = 2 Then
            Return 1
        Else
            Return Fib(i - 1) + Fib(i - 2)
        End If
    End Function
End Class
