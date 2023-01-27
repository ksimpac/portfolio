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
            Dim str1 As String = "a" '控制要找小寫的字元
            Dim str2 As String = "A" '控制要找大寫的字元
            Dim ans As String = ""
            Dim a As String = ""

            Do Until Len(ans) = Len(s)

                For k = 1 To Len(s)
                    a = Mid(s, k, 1)
                    If a = str1 Then
                        ans &= a
                    End If
                Next

                For l = 1 To Len(s)
                    a = Mid(s, l, 1)
                    If a = str2 Then
                        ans &= a
                    End If
                Next

                str1 = ChrW(AscW(str1) + 1)
                str2 = ChrW(AscW(str2) + 1)
            Loop

            PrintLine(3, ans)
        Next
    End Sub
End Class
