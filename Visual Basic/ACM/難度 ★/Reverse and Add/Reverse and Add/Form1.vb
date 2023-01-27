Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim N As Integer = LineInput(fn)

        For I = 1 To N

            Dim S As String = LineInput(fn) : Dim Str_S As String = StrReverse(S) : Dim flag As Boolean = False : Dim J As Integer
            S = (Val(S) + Val(Str_S)).ToString : Str_S = StrReverse(S)

            For J = 1 To 1000

                Dim Num As Integer = 0

                If S <> Str_S Then
                    Num = Val(S) + Val(Str_S) : S = Num.ToString : Str_S = StrReverse(S)
                Else
                    flag = True : Exit For
                End If

            Next

            If flag = True Then
                PrintLine(3, J.ToString & " " & S)
            Else
                PrintLine(3, "Not Exist")
            End If

        Next

    End Sub
End Class
