﻿Public Class Form1
    Dim path(,) As Integer : Dim visited_path(,) As String : Dim all_node As New List(Of Integer) : Dim bool As New List(Of Boolean) : Dim check As String : Dim root As Integer : Dim ans As Integer = 0
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

            Dim data() As String = Split(s, " ") : ReDim path(20, 20) : ReDim visited_path(20, 20)
            all_node.Clear() : bool.Clear() : check = "" : root = 0 : ans = 0

            If s = "0,0" Then PrintLine(3, "T") : Continue For

            Dim flag As Boolean = False

            For j = 0 To UBound(data)
                Dim node() As String = Split(data(j), ",")
                If node(0) = "0" And node(1) = "0" Then Exit For
                If node(0) = node(1) Then flag = True : Exit For
                If all_node.IndexOf(Val(node(0))) = -1 Then all_node.Add(Val(node(0))) : bool.Add(False)
                If all_node.IndexOf(Val(node(1))) = -1 Then all_node.Add(Val(node(1))) : bool.Add(False)
                path(Val(node(0)), Val(node(1))) = 1 : path(Val(node(1)), Val(node(0))) = 1
            Next

            If flag = True Then PrintLine(3, "T") : Continue For

            bool(all_node.IndexOf(root)) = True : Call walk(root)

            If ans <> -1 And bool.IndexOf(False) = -1 Then
                PrintLine(3, "T")
            Else
                PrintLine(3, "F")
            End If


        Next

    End Sub
    Sub walk(ByRef now_root As Integer)

        For i = 0 To UBound(path)

            If path(now_root, i) = 1 And visited_path(now_root, i) = 0 And visited_path(i, now_root) = 0 And InStr(check, i) = 0 And ans <> -1 Then
                visited_path(now_root, i) = 1 : visited_path(i, now_root) = 1 : check &= now_root & " " : bool(all_node.IndexOf(now_root)) = True : Call walk(i)
            ElseIf path(now_root, i) = 1 And visited_path(now_root, i) = 0 And visited_path(i, now_root) = 0 And InStr(check, i) <> 0 Then
                ans = -1 : Exit For
            ElseIf i = UBound(path) And visited_path(now_root, i) = 0 And visited_path(i, now_root) = 0 And InStr(check, i) = 0 Then
                bool(all_node.IndexOf(now_root)) = True
            End If

        Next

    End Sub
End Class
