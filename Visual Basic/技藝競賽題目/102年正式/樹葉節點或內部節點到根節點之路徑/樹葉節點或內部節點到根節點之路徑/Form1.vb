Public Class Form1
    Dim path(,) As String
    Dim root, ans, L As Integer
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
            Dim t() As String = Split(Replace(LineInput(fn), " ", ""), ",")
            ReDim path(Val(t(0)) - 1, Val(t(0)) - 1)
            L = Val(t(1)) : ans = 0

            For j = 1 To Val(t(0))
                Dim s() As String = Split(Replace(LineInput(fn), " ", ""), ",")
                If s(1) = "99" Then
                    root = Val(s(0))
                Else
                    path(Val(s(1)), Val(s(0))) = 1
                End If
            Next
            Call x(root, 0)
            PrintLine(3, Trim(ans))
            If i <> n Then Dim temp As String = LineInput(fn)
        Next
        

    End Sub
    Sub x(ByVal now As Integer, ByVal lengh As Integer)
        If L = lengh Then
            ans += 1
        Else
            For i = 0 To UBound(path)
                If path(now, i) = 1 Then Call x(i, lengh + 1)
            Next
        End If
    End Sub
End Class
