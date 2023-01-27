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

    Sub y(ByVal fn As Long)
        Dim n As Long = LineInput(fn)

        For i = 1 To n
            Dim str = LineInput(fn)
            Dim str1() As String
            str1 = Split(str, " ")
            If str1(0) = str1(1) Then
                PrintLine(3, "Yes")
            Else
                PrintLine(3, "No")
            End If
        Next
    End Sub
End Class
