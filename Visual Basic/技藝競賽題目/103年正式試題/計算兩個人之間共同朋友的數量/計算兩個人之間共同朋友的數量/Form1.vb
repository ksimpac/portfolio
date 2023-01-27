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
        Dim times As Integer = 0
        For i = 1 To n
            Dim user1() As String = Split(LineInput(fn), " ")
            Dim user2() As String = Split(LineInput(fn), " ")

            For j = 1 To UBound(user1)
                For k = 1 To UBound(user2)
                    If user1(j) = user2(k) Then
                        times += 1
                    End If
                Next
            Next
            If times = 0 Then
                PrintLine(3, "0")
            Else
                PrintLine(3, times.ToString)
            End If
            times = 0
        Next
    End Sub
End Class
