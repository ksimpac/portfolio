Public Class Form1
    Dim path(,) As Integer : Dim ind_node As New List(Of Integer) : Dim root As Integer : Dim ind_path As New List(Of Integer) : Dim flag As Boolean
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

            Dim t As Integer = LineInput(fn) : ReDim path(t - 1, t - 1) : ind_node.Clear()

            For j = 1 To t

                Dim s As String = Trim(LineInput(fn))

                Do Until InStr(s, "  ") = 0
                    s = Replace(s, "  ", " ")
                Loop

                Dim node() As String = Split(s, ",")

                If node(1) = "99" Then
                    root = Val(node(0))
                Else
                    path(Val(node(1)), Val(node(0))) = 1
                End If

            Next

            Dim ind_flag As Boolean = False '檢查是否為終點節點(Left)

            For k = 0 To t - 1 '兩個迴圈找終端節點

                For p = 0 To t - 1
                    If path(k, p) = 1 Then ind_flag = True : Exit For
                Next

                If ind_flag = False Then ind_node.Add(k)

                ind_flag = False

            Next

            For m = 0 To ind_node.Count - 1 '找節點與各終端節點的路徑

                Call walk(root, ind_node(m))

                ind_path.Remove(ind_node(m)) : ind_path.Remove(root)

                If ind_path.Count = 0 Then
                    PrintLine(3, ind_node(m).ToString & ":N")
                Else

                    Dim ans As String = ""

                    For ff = 0 To ind_path.Count - 1

                        If ff <> ind_path.Count - 1 Then
                            ans &= ind_path(ff).ToString & ","
                        Else
                            ans &= ind_path(ff).ToString
                        End If

                    Next

                    PrintLine(3, ind_node(m).ToString & ":{" & ans & "}")

                End If

                ind_path.Clear() : flag = False

            Next

            PrintLine(3, "")

            If i <> n Then Dim temp As String = LineInput(fn)

        Next

    End Sub
    Sub walk(ByRef now_root As Integer, ByVal goal As Integer)

        If now_root = goal Then
            flag = True
        Else

            For i = 0 To UBound(path)
                If path(now_root, i) = 1 And flag = False Then Call walk(i, goal)
            Next

        End If

        If flag = True Then ind_path.Add(now_root)

    End Sub
End Class
