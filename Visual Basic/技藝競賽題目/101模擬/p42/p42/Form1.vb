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

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0
                s = Replace(s, "  ", " ")
            Loop

            Dim data() As String = Split(s, " ") : Dim card(UBound(data)) As Integer

            For j = 0 To UBound(data)
                card(j) = Val(Microsoft.VisualBasic.Right(data(j), Len(data(j)) - 1))
            Next

            Array.Sort(card) : Array.Reverse(card)

            Dim total As Integer = 0

            For k = 0 To UBound(card)

                If card(k) > 10 Then
                    total += 10
                ElseIf card(k) = 1 Then

                    If total + 11 <= 21 Then
                        total += 11
                    Else
                        total += 1
                    End If

                Else
                    total += card(k)
                End If

            Next

            If total <= 21 Then
                PrintLine(3, total.ToString)
            Else
                PrintLine(3, "F")
            End If

        Next

    End Sub
End Class
