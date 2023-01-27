Public Class Form1
    Dim result As New List(Of String)
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

        Dim n As Integer = Trim(LineInput(fn))

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0
                s = Replace(s, "  ", " ")
            Loop

            Dim data() As String = Split(s, " : ") : Dim goal As Integer = data(1)

            Dim ss() As String = Split(data(0), " ")

            Call z("+-*/", "", UBound(ss)) : Dim p As Integer = 0 : Dim ans As String = ""

            For j = 0 To result.Count - 1

                For k = 0 To UBound(ss)

                    If k = 0 Then

                        Select Case Mid(result(j), k + 1, 1)
                            Case "+" : p = Val(ss(k)) + Val(ss(k + 1))
                            Case "-" : p = Val(ss(k)) - Val(ss(k + 1))
                            Case "*" : p = Val(ss(k)) * Val(ss(k + 1))
                            Case "/" : p = Val(ss(k)) / Val(ss(k + 1))
                        End Select

                    Else

                        Select Case Mid(result(j), k + 1, 1)
                            Case "+" : p += Val(ss(k + 1))
                            Case "-" : p -= Val(ss(k + 1))
                            Case "*" : p *= Val(ss(k + 1))
                            Case "/" : p /= Val(ss(k + 1))
                        End Select

                    End If

                Next

                If p = goal Then ans = result(j) : Exit For

            Next

            Dim effect As String = ""

            If ans = "" Then
                PrintLine(3, "F")
            Else

                For m = 0 To UBound(ss)
                    effect &= ss(m) & Mid(ans, m + 1, 1)
                Next

                PrintLine(3, effect)

            End If

            result.Clear()

        Next

    End Sub
    Sub z(ByRef stepp As String, ByRef st As String, ByVal times As Integer)

        Dim stm As String = ""

        If Len(st) < times Then

            For i = 1 To Len(stepp)
                stm = Mid(stepp, i, 1) : Call z(stepp, st & stm, times)
            Next

        Else

            If result.IndexOf(st) = -1 Then result.Add(st)

        End If

    End Sub
End Class
