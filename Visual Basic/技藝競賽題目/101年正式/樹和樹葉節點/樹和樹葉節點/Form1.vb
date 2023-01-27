Public Class Form1
    Dim path(,) As Integer : Dim visited_path(,) As Integer : Dim root As Integer : Dim check As String : Dim ans As Integer : Dim all_node As New List(Of Integer) : Dim node_bool As New List(Of Boolean)
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

            ans = 0

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, "  ") = 0
                s = Replace(s, "  ", " ")
            Loop

            If s = "0,0" Then PrintLine(3, "0") : Continue For

            root = 0

            Dim array1() As String = Split(s, " ") : ReDim path(20, 20) : ReDim visited_path(20, 20) : Dim flag As Boolean = False

            For j = 0 To UBound(array1)

                Dim node() As String = Split(array1(j), ",")

                If node(0) = node(1) And node(0) <> 0 And node(1) <> 0 Then flag = True : Exit For
                If node(0) <> node(1) And all_node.IndexOf(node(0)) = -1 Then all_node.Add(Val(node(0))) : node_bool.Add(False)
                If node(0) <> node(1) And all_node.IndexOf(node(1)) = -1 Then all_node.Add(Val(node(1))) : node_bool.Add(False)

                If node(0) = 0 And node(1) = 0 Then
                    path(Val(node(0)), Val(node(1))) = 1 : path(Val(node(1)), Val(node(0))) = 1
                ElseIf node(0) <> node(1) And node(0) <> 0 Or node(1) <> 0 Then
                    path(Val(node(0)), Val(node(1))) = 1 : path(Val(node(1)), Val(node(0))) = 1
                End If

            Next

            If flag = True Then PrintLine(3, "F") : Continue For

            node_bool(all_node.IndexOf(root)) = True : Call walk(root)

            If ans = -1 Or node_bool.IndexOf(False) <> -1 Then
                PrintLine(3, "F")
            Else
                PrintLine(3, (ans).ToString)
            End If

            check = "" : node_bool.Clear() : all_node.Clear()

        Next

    End Sub
    Sub walk(ByRef now_root As Integer)

        For i = 0 To UBound(path)

            If path(now_root, i) = 1 And visited_path(now_root, i) = 0 And visited_path(i, now_root) = 0 And InStr(check, i) = 0 And ans <> -1 Then
                visited_path(now_root, i) = 1 : visited_path(i, now_root) = 1 : check &= now_root & " " : node_bool(all_node.IndexOf(i)) = True : Call walk(i)
            ElseIf path(now_root, i) = 1 And visited_path(now_root, i) = 0 And visited_path(i, now_root) = 0 And InStr(check, i) <> 0 Then
                ans = -1 : Exit For
            ElseIf i = UBound(path) And InStr(check, now_root) = 0 Then
                ans += 1
            End If

        Next

    End Sub
End Class
