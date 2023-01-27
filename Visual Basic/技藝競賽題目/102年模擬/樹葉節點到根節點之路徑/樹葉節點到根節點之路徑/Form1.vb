Public Class Form1
    Dim path(,) As Integer : Dim replace_path(,) : Dim root As Integer : Dim ter_path As New List(Of Integer) : Dim ter_node As New List(Of Integer) : Dim flag As Boolean
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

            ReDim path(t - 1, t - 1) : ReDim replace_path(t - 1, t - 1)

            For j = 1 To t

                Dim s As String = Trim(LineInput(fn))

                Do Until InStr(s, " ") = 0
                    s = Replace(s, " ", "")
                Loop

                Dim data() As String = Split(s, ",")

                If data(1) = "99" Then
                    root = Val(data(0))
                Else
                    path(Val(data(1)), Val(data(0))) = 1
                End If

            Next

            Array.Copy(path, replace_path, path.Length)

            For k = 0 To UBound(path)

                Dim times As Integer = 0

                For m = 0 To UBound(path)
                    If path(k, m) = 1 Then times += 1
                Next

                If times = 0 Then ter_node.Add(k)

            Next


            For p = 0 To ter_node.Count - 1

                Call walk(root, ter_node(p))

                If ter_path.Count <> 0 Then

                    Dim ans As String = ""

                    For r = 0 To ter_path.Count - 1

                        If r <> ter_path.Count - 1 Then
                            ans &= ter_path(r) & ", "
                        Else
                            ans &= ter_path(r)
                        End If

                    Next

                    PrintLine(3, ter_node(p) & ":" & "{" & ans & "}") : ter_path.Clear() : flag = False

                    Array.Copy(replace_path, path, path.Length)

                Else
                    PrintLine(3, ter_node(p) & ":N")
                End If

            Next

            ter_node.Clear()

            If i <> n Then Dim temp As String = LineInput(fn) : PrintLine(3, "")

        Next

    End Sub
    Sub walk(ByRef now_root As Integer, ByVal goal As Integer)

        If now_root = goal Then
            flag = True : Exit Sub
        Else

            For i = 0 To UBound(path)

                If path(now_root, i) = 1 And flag = False Then
                    Call walk(i, goal)
                ElseIf flag = True Then
                    Exit For
                End If

            Next

        End If

        If flag = True And now_root <> root Then ter_path.Add(now_root)


    End Sub
End Class
