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
        Dim n As Integer = LineInput(fn) : Dim fifth, twenty, ten, five, one As Integer

        For i = 1 To n
            Dim s As Integer = 100 - Val(LineInput(fn))

            fifth += s \ 50 : s = s - 50 * (s \ 50)
            twenty += s \ 20 : s = s - 20 * (s \ 20)
            ten += s \ 10 : s = s - 10 * (s \ 10)
            five += s \ 5 : s = s - 5 * (s \ 5)
            one += s

            If i <> n Then Continue For

            PrintLine(3, "50," & fifth & " " & "20," & twenty & " " & "10," & ten & " " & "5," & five & " " & "1," & one)
            fifth = 0 : twenty = 0 : ten = 0 : five = 0 : one = 0
        Next

    End Sub
End Class
