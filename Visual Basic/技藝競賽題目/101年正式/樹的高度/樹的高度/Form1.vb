Public Class Form1
    Dim length(), path(,) As Integer
    Dim index As Integer
    Dim root, ans As Integer
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

            Dim t As Integer = LineInput(fn)
            ReDim path(t - 1, t - 1)
            ans = 0

            For j = 1 To t - 1

                Dim s() = Split(Trim(LineInput(fn)), ",")

                If s(0) = "0" Or s(1) = "0" Then
                    root = 0
                    path(Val(s(1)), Val(s(0))) = 1
                Else
                    path(Val(s(1)), Val(s(0))) = 1
                End If

            Next

            ReDim length(999)

            z(root, 1)

            Array.Sort(length) : Array.Reverse(length)

            ans = length(0)

            PrintLine(3, ans.ToString)

            If i <> n Then Dim temp = LineInput(fn)

        Next

    End Sub
    Sub z(ByVal nowroot As Integer, ByVal lengh As Integer)

        For i = 1 To UBound(path)

            If path(nowroot, i) = 1 Then
                Call z(i, lengh + 1) : length(index) = lengh + 1 : index += 1
            End If

        Next

    End Sub
End Class
