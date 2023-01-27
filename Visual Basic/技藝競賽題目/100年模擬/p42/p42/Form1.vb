Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in-4-2-1.txt", OpenMode.Input)
        FileOpen(2, "in-4-2-2.txt", OpenMode.Input)
        FileOpen(3, "out-4-2.txt", OpenMode.Output)

        Call y(1)
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim num As Integer = 100 - Val(LineInput(fn))
            Dim fifty, ten, five As Integer

            fifty = num \ 50 : num = num - 50 * fifty
            ten = num \ 10 : num = num - 10 * ten
            five = num \ 5 : num = num - 5 * five
            PrintLine(3, "50," & fifty & " " & "10," & ten & " " & "5," & five & " " & "1," & num)
        Next

    End Sub
End Class
