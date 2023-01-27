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
            Dim s As String = LineInput(fn)
            Dim num() As String
            num = Split(s, " ")
            Dim a, b, c As Integer

            a = num(0) : b = num(1)

            While b <> 0
                c = a Mod b
                a = b
                b = c
            End While

            PrintLine(3, a.ToString)

            a = 0 : b = 0 : c = 0
        Next
    End Sub
End Class
