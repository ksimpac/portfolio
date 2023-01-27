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
            Dim s As Integer = LineInput(fn)
            Dim flag = False
            For j = 2 To s \ 2
                If s Mod j = 0 Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                PrintLine(3, "not prime")
            Else
                PrintLine(3, "prime")
            End If
        Next
    End Sub
End Class
