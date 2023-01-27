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
            Dim ans As String = ""

            For j = 1 To Len(s)
                If AscW(Mid(s, j, 1)) >= 48 And AscW(Mid(s, j, 1)) <= 57 Then ans &= Mid(s, j, 1)
            Next

            If ans <> "" Then
                PrintLine(3, ans)
            Else
                PrintLine(3, "N")
            End If

        Next

    End Sub
End Class
