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
            Dim data() As String
            data = Split(s, " ")
            Dim a As String = data(0) : Dim b As String = data(1)

            If a = "0" And b = "0" Then
                Exit Sub
            End If

            If Len(a) <> Len(b) Then
                If Len(a) > Len(b) Then
                    Do Until Len(b) = Len(a)
                        b = "0" & b
                    Loop
                Else
                    Do Until Len(a) = Len(b)
                        a = "0" & a
                    Loop
                End If
            End If



            Dim num1(Len(a)) As String : Dim num2(Len(b)) As String : Dim sum(Len(a)) As Integer

            For k = 1 To UBound(num1)
                num1(k) = Mid(a, k, 1)
                num2(k) = Mid(b, k, 1)
            Next

            For m = 1 To UBound(sum)
                sum(m) = Val(num1(m)) + Val(num2(m))
            Next

            Dim times = 0

            For l = 1 To UBound(sum)
                If sum(l) > 9 Then
                    times += 1
                End If
            Next
            PrintLine(3, times.ToString)
        Next
    End Sub
End Class
