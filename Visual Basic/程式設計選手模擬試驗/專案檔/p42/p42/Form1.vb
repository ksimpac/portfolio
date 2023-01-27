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
            Dim data = Split(s, " ")
            Dim a As Integer = data(0) : Dim b As Integer = data(1)
            Dim ans As String = ""

            ans = z(a, b)
            PrintLine(3, ans)
        Next
    End Sub
    Function z(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim num(500000) As Integer : Dim index As Integer = 0
        Dim times = 0
        For i = 2 To num1
            If num1 Mod i = 0 Then
                num(index) = i
                index += 1
            End If
        Next

        For k = 0 To UBound(num)
            If num(k) <> 0 Then
                If num(k) Mod num2 = 0 Then
                    times += 1
                End If
            Else
                Exit For
            End If
        Next
        Return times
    End Function
End Class
