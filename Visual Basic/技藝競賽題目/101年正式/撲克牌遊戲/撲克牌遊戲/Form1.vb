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

            Dim card() As String
            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0 '避免無限空白
                s = Replace(s, "  ", " ")
            Loop

            card = Split(s, " ")

            Dim sum As Integer = 0
            Dim num(UBound(card)) As Integer

            For j = 0 To UBound(num)

                If card(j) Mod 13 = 11 Or card(j) Mod 13 = 12 Or card(j) Mod 13 = 0 Then
                    num(j) = 10
                ElseIf card(j) Mod 13 = 1 Then
                    num(j) = 11
                Else
                    num(j) = card(j) Mod 13
                End If

                sum += num(j)
            Next

            If sum <= 21 Then
                PrintLine(3, sum.ToString)
            Else

                sum = 0

                For l = 0 To UBound(num)

                    If num(l) = 11 Then
                        num(l) = 1
                        Exit For
                    End If

                Next

                For j = 0 To UBound(num)
                    sum += num(j)
                Next

                If sum > 21 Then
                    PrintLine(3, "F")
                Else
                    PrintLine(3, sum.ToString)
                End If

            End If

        Next
    End Sub
End Class
