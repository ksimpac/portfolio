Public Class Form1
    Dim path(,) As Integer : Dim root As Integer : Dim goal As Integer : Dim goal_path As New List(Of Integer) : Dim flag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in-2-2.txt", OpenMode.Input)
        FileOpen(3, "out-2-2.txt", OpenMode.Output)

        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim n As Integer = Val(LineInput(fn)) : Dim goal_str As String = LineInput(fn)
        Dim node_to_num As New List(Of String) '用類似對照表的方式編號 以便放進陣列
        ReDim path(n - 1, n - 1)

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, " ") = 0
                s = Replace(s, " ", "")
            Loop

            Dim node() As String = Split(s, ",")

            If node_to_num.IndexOf(node(0)) = -1 Then node_to_num.Add(node(0))
            If node_to_num.IndexOf(node(1)) = -1 And node(1) <> "---" Then node_to_num.Add(node(1))

            If node(1) = "---" Then
                root = node_to_num.IndexOf(node(0))
            Else
                path(node_to_num.IndexOf(node(1)), node_to_num.IndexOf(node(0))) = 1
            End If

        Next

        goal = node_to_num.IndexOf(goal_str) : flag = False

        Call walk(root)

        goal_path.Reverse() : Dim ans As String = ""

        For j = 0 To goal_path.Count - 1

            If j <> goal_path.Count - 1 Then
                ans &= node_to_num(goal_path(j)) & " "
            Else
                ans &= node_to_num(goal_path(j))
            End If

        Next

        PrintLine(3, ans)

        goal_path.Clear()

    End Sub
    Sub walk(ByRef now_root As Integer)

        If now_root = goal Then
            flag = True
        Else

            For i = 0 To UBound(path)
                If path(now_root, i) = 1 And flag = False Then Call walk(i)
            Next

        End If

        If flag = True Then goal_path.Add(now_root)

    End Sub
End Class
