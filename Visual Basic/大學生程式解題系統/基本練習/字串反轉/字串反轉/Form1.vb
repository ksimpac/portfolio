Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)


        Call x(1)
        PrintLine(3, "")
        Call x(2)

        Me.Close()
    End Sub
    Sub x(ByVal fn As Long)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s1 As String = LineInput(fn)
            Dim s2 As String = StrReverse(s1)
            PrintLine(3, s2)
        Next
    End Sub
End Class
