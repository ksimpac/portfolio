Public Class Form1
    Dim goal As Integer : Dim root As Integer : Dim path(,) As Integer : Dim ans As Integer : Dim path_node As New List(Of String) : Dim flag As Boolean
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

        Dim n() As String = Split(Trim(LineInput(fn)), ", ") : goal = n(1)

        For i = 1 To Val(n(0))

            Dim data() As String = Split(Trim(LineInput(fn)), "  ") : ReDim path(Val(data(0)) - 1, Val(data(0)) - 1)

            For j = 1 To Val(data(0)) - 1
                Dim node() As String = Split(Trim(data(j)), ",") : path(Val(node(1)), Val(node(0))) = 1
            Next

            root = 0 : path_node.Clear() : flag = False

            Call walk(root, 0)

            Dim printformat As String = ""

            For k = 0 To path_node.Count - 1

                If k <> path_node.Count - 1 Then
                    printformat &= path_node(k) & " -> "
                Else
                    printformat &= path_node(k)
                End If

            Next

            PrintLine(3, "路徑長度為" & ans.ToString & ":  " & printformat)

        Next

    End Sub
    Sub walk(ByRef now_root As Integer, ByRef times As Integer)

        If flag = False And now_root = goal Then
            ans = times : path_node.Add(now_root) : flag = True : Exit Sub
        Else

            For i = 0 To UBound(path)
                If path(now_root, i) = 1 And flag = False Then Call walk(i, times + 1)
            Next

        End If

        If flag = True Then path_node.Add(now_root)

    End Sub
End Class
