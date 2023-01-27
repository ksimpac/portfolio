Public Class Form1
    Dim path(,,) As Integer : Dim visited_path(,,) As Integer : Dim check As String : Dim root As Integer : Dim flag As Boolean : Dim all_node1, all_node2 As New List(Of Integer) : Dim bool_1, bool_2 As New List(Of Boolean)
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

            Dim repeat_side As New List(Of String) : Dim check_path As String = ""

            Dim data1() As String : Dim data2() As String

            For j = 1 To 2

                Dim s As String = Trim(LineInput(fn))

                Do Until InStr(s, "  ") = 0
                    s = Replace(s, "  ", " ")
                Loop

                If j = 1 Then
                    data1 = Split(s, " ")
                Else
                    data2 = Split(s, " ")
                End If

            Next

            'path(第幾棵數,節點,節點) = 0 (沒路) 或 1 (有路)

            ReDim path(2, 80, 80) : ReDim visited_path(2, 80, 80) : check = ""

            For k = 0 To UBound(data1) '檢查重複邊 也幫第一棵樹跟第二棵樹作路徑 因為是圖形(無向)所有兩個方向都可以(把它想成雙向道)

                Dim node() As String = Split(data1(k), "-") : path(1, Val(node(0)), Val(node(1))) = 1 : path(1, Val(node(1)), Val(node(0))) = 1

                If all_node1.IndexOf(Val(node(0))) = -1 Then all_node1.Add(Val(node(0))) : bool_1.Add(False)
                If all_node1.IndexOf(Val(node(1))) = -1 Then all_node1.Add(Val(node(1))) : bool_1.Add(False)


                If Array.IndexOf(data2, node(0) & "-" & node(1)) <> -1 Or Array.IndexOf(data2, node(1) & "-" & node(0)) <> -1 Then
                    repeat_side.Add(data1(k))

                    If Array.IndexOf(data2, node(0) & "-" & node(1)) <> -1 Then
                        repeat_side.Add(data2(Array.IndexOf(data2, node(0) & "-" & node(1))))
                    Else
                        repeat_side.Add(data2(Array.IndexOf(data2, node(1) & "-" & node(0))))
                    End If

                End If

                Array.Clear(node, 0, node.Length) : node = Split(data2(k), "-")
                path(2, Val(node(0)), Val(node(1))) = 1 : path(2, Val(node(1)), Val(node(0))) = 1

                If all_node2.IndexOf(Val(node(0))) = -1 Then all_node2.Add(Val(node(0))) : bool_2.Add(False)
                If all_node2.IndexOf(Val(node(1))) = -1 Then all_node2.Add(Val(node(1))) : bool_2.Add(False)

            Next

            Dim ind_node As New List(Of Integer)

            For p = 1 To 2

                flag = True
                Dim times As Integer = 0

                For q = 1 To 80

                    For r = 1 To 80
                        If path(p, q, r) = 1 Then times += 1
                    Next

                    If times >= 2 Then ind_node.Add(q)

                    times = 0

                Next

                If p = 1 Then
                    bool_1(all_node1.IndexOf(ind_node(0))) = True : Call walk(p, ind_node(0))
                Else
                    bool_2(all_node2.IndexOf(ind_node(0))) = True : Call walk(p, ind_node(0))
                End If

                If flag = True And p = 1 And bool_1.IndexOf(False) = -1 Then

                    Dim ans As String = ""

                    For pp = 0 To ind_node.Count - 1

                        If pp <> ind_node.Count - 1 Then
                            ans &= ind_node(pp) & ", "
                        Else
                            ans &= ind_node(pp)
                        End If

                    Next

                    If repeat_side.Count <> 0 Then
                        ans &= ": "

                        For qq = p - 1 To repeat_side.Count - 1 Step 2

                            If qq <> repeat_side.Count - 1 Then
                                ans &= repeat_side(qq) & " "
                            Else
                                ans &= repeat_side(qq)
                            End If

                        Next

                    End If

                    PrintLine(3, ans)

                    ind_node.Clear() : check = ""

                ElseIf flag = True And p = 2 And bool_2.IndexOf(False) = -1 Then

                    Dim ans As String = ""

                    For pp = 0 To ind_node.Count - 1

                        If pp <> ind_node.Count - 1 Then
                            ans &= ind_node(pp) & ", "
                        Else
                            ans &= ind_node(pp)
                        End If

                    Next

                    If repeat_side.Count <> 0 Then
                        ans &= ": "

                        For qq = p - 1 To repeat_side.Count - 1 Step 2

                            If qq <> repeat_side.Count - 1 Then
                                ans &= repeat_side(qq) & " "
                            Else
                                ans &= repeat_side(qq)
                            End If

                        Next

                    End If

                    PrintLine(3, ans)

                    ind_node.Clear()

                Else
                    PrintLine(3, "F")

                    ind_node.Clear()
                End If


            Next

            all_node1.Clear() : bool_1.Clear() : all_node2.Clear() : bool_2.Clear()

            If i <> n Then Dim temp As String = LineInput(fn) : PrintLine(3, "")

        Next

    End Sub
    Sub walk(ByVal num As Integer, ByRef now_root As Integer)

        For i = 1 To 80

            If path(num, now_root, i) = 1 And visited_path(num, now_root, i) = 0 And visited_path(num, i, now_root) = 0 And InStr(check, i) = 0 And flag = True Then
                visited_path(num, now_root, i) = 1 : visited_path(num, i, now_root) = 1 : check &= now_root & " "

                If num = 1 Then
                    bool_1(all_node1.IndexOf(now_root)) = True : Call walk(num, i)
                Else
                    bool_2(all_node2.IndexOf(now_root)) = True : Call walk(num, i)
                End If

            ElseIf path(num, now_root, i) = 1 And visited_path(num, now_root, i) = 0 And visited_path(num, i, now_root) = 0 And InStr(check, i) <> 0 Then
                flag = False
            ElseIf i = 80 And visited_path(num, now_root, i) = 0 And visited_path(num, i, now_root) = 0 And InStr(check, i) = 0 Then

                If num = 1 Then
                    bool_1(all_node1.IndexOf(now_root)) = True
                Else
                    bool_2(all_node2.IndexOf(now_root)) = True
                End If

            End If

        Next

    End Sub
End Class
