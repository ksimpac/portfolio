Public Class Form1
    Dim btree(2 * 1000 - 1) As Integer : Dim path(2 * 1000 - 1, 2 * 1000 - 1) As Integer : Dim node As New List(Of Integer)
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

        Array.Clear(path, 0, path.Length) : node.Clear()

        For i = 0 To UBound(btree)
            btree(i) = -1
        Next

        Dim n As Integer = LineInput(fn) : Dim s As Integer = Val(Trim(LineInput(fn)))

        btree(1) = s '根節點

        Dim level As Integer = 0 : Dim level_max As Integer = 0

        For j = 2 To n

            s = Val(Trim(LineInput(fn)))

            level = 1

            Do While btree(level) <> -1 '如果該編號的節點不為空值的話

                If s > btree(level) Then
                    level = level * 2 + 1 '右子樹
                Else
                    level = level * 2 '左子樹
                End If

            Loop

            btree(level) = s

            If level > level_max Then level_max = level

        Next

        For k = 1 To level_max

            Dim index As Integer = k * 2

            If btree(k) <> -1 Then
                If btree(index + 1) <> -1 Then path(btree(k), btree(index + 1)) = 1
                If btree(index) <> -1 Then path(btree(k), btree(index)) = 1
            End If

        Next

        Dim root As Integer = btree(1) : Call Preorder_Traversal(root)

        For m = 0 To node.Count - 1
            PrintLine(3, node(m).ToString)
        Next

    End Sub
    Sub Preorder_Traversal(ByRef now_root As Integer)

        node.Add(now_root)

        For i = 0 To UBound(path)
            If path(now_root, i) = 1 Then Call Preorder_Traversal(i)
        Next

    End Sub
End Class
