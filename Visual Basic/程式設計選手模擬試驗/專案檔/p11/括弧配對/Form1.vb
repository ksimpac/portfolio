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

            Dim a As Integer '計算"("
            Dim b As Integer '計算")"
            Dim c As Integer '計算"["
            Dim d As Integer '計算"]"
            Dim data As String = ""
            For k = 1 To Len(s)
                data = Mid(s, k, 1)
                Select Case data
                    Case "("
                        a += 1
                    Case ")"
                        b += 1
                    Case "["
                        c += 1
                    Case "]"
                        d += 1
                End Select
            Next

            Dim flag As Boolean = False

            If a <> b Or c <> d Then
                PrintLine(3, "No")
            Else
                flag = z(s)

                If Len(s) <= 128 And flag = True Then
                    PrintLine(3, "Yes")
                Else
                    PrintLine(3, "No")
                End If

            End If

            a = 0
            b = 0
            c = 0
            d = 0
        Next
    End Sub

    Function z(ByVal s As String)

        Dim check(130) As String
        Dim data As String = ""
        Dim flag = True
        Dim index As Integer = Len(s)

        For i = Len(s) To 1 Step -1
            data = Mid(s, i, 1)
            check(index) = data
            For j = i To Len(s) - 1

                If check(j) = "[" And check(j + 1) = "]" Then

                    check(j) = ""
                    check(j + 1) = ""
                    index = j + 2

                ElseIf check(j) = "(" And check(j + 1) = ")" Then

                    check(j) = ""
                    check(j + 1) = ""
                    index = j + 2

                End If
            Next
            index -= 1
        Next

        For k = 0 To UBound(check)
            If check(k) <> "" Then
                flag = False
                Exit For
            End If
        Next

        Return flag
    End Function
End Class
