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

            Dim s As String = Trim(LineInput(fn)) : Dim ans As String = ""

            Dim str As String = ""

            For j = 1 To 8

                str &= Mid(s, j, 1)

                If j = 4 Or j = 8 Then

                    Dim total As Integer = 0 : Dim num As Integer = 3

                    For k = 1 To 4
                        total += Val(Mid(str, k, 1)) * 2 ^ num : num -= 1
                    Next

                    Select Case total
                        Case 10 : ans &= "A"
                        Case 11 : ans &= "B"
                        Case 12 : ans &= "C"
                        Case 13 : ans &= "D"
                        Case 14 : ans &= "E"
                        Case 15 : ans &= "F"
                        Case Else : ans &= total.ToString
                    End Select

                    str = ""

                End If

            Next

            PrintLine(3, ans)

        Next

    End Sub
End Class
