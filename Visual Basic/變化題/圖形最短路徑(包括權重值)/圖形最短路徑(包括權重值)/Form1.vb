Public Class Form1
    Dim path(,) As Integer : Dim visited_path(,) As Integer : Dim root, goal As Integer : Dim node_weight As New SortedList : Dim not_visit_path As New List(Of String) : Dim weight() As Integer : Dim data() As String : Dim short_path As New List(Of Integer) : Dim flag As Boolean
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

        Dim N As Integer = LineInput(fn)

        For I = 1 To N

            ReDim path(1000, 1000) : ReDim visited_path(1000, 1000)
            Dim S As String = Trim(LineInput(fn)) : Dim SS As String = Trim(LineInput(fn))

            Do Until InStr(S, "  ") = 0 And InStr(SS, "  ") = 0
                S = Replace(S, "  ", " ") : SS = Replace(SS, "  ", " ")
            Loop

            Dim A() As String = Split(S, " ") : Dim B() As String = Split(SS, " "), C(UBound(B)) As Integer
            ReDim data(UBound(A) - 1) : ReDim weight(UBound(C))
            Dim D() As String = Split(A(UBound(A)), "-") : root = Val(D(0)) : goal = Val(D(1))


            Array.Copy(A, data, A.Length - 1)

            For J = 0 To UBound(B) '把字串的權重值轉數字
                C(J) = Val(B(J))
            Next

            Array.Copy(C, weight, C.Length) : Array.Sort(weight, data)

            For K = 0 To UBound(data) '路徑
                Dim E() As String = Split(data(K), ",") : path(Val(E(0)), Val(E(1))) = 1 : path(Val(E(1)), Val(E(0))) = 1
            Next

            not_visit_path.Clear() : Call count_weight(root, 0)  '計算每個節點的最小成本(權重值)

            flag = False : ReDim visited_path(1000, 1000) : Call find_short_path(root, 0) '找成本最小的路徑

            Dim Ans As String = "最短路徑為:"

            If short_path.Count <> 0 And flag = True Then

                For M = 0 To short_path.Count - 1

                    If M <> short_path.Count - 1 Then
                        Ans &= short_path(M) & " -> "
                    Else
                        Ans &= short_path(M)
                    End If

                Next

            Else
                Ans = "找不到最短路徑"
            End If

            PrintLine(3, Ans) : short_path.Clear() : node_weight.Clear()

            If I <> N Then Dim temp As String = LineInput(fn)

        Next

    End Sub
    Sub count_weight(ByRef now_root As Integer, ByRef accumulate_weight As Integer) '算所有節點的最小成本(使用BFS)

        For I = 0 To UBound(path)

            If path(now_root, I) = 1 And visited_path(now_root, I) = 0 And visited_path(I, now_root) = 0 Then
                not_visit_path.Add(now_root & "," & I & "," & accumulate_weight) '先串可以走的路、在串目前的累積的權重值
            End If

        Next

        If now_root = root Then
            node_weight.Add(now_root, accumulate_weight)
        Else

            If node_weight.IndexOfKey(now_root) = -1 Then
                node_weight.Add(now_root, accumulate_weight)
            Else '如果有另外一個路到同一個節點

                If node_weight(now_root) > accumulate_weight Then '比較上次走的路所走出來的累計權重值跟這次的走出來的累計權重值有沒有比較小
                    node_weight(now_root) = accumulate_weight
                End If

            End If

        End If

        If not_visit_path.Count <> 0 Then

            Dim R As String = not_visit_path(0) : not_visit_path.Remove(R) : Dim S() As String = Split(R, ",")
            visited_path(Val(S(0)), Val(S(1))) = 1 : visited_path(Val(S(1)), Val(S(0))) = 1

            Dim A As Integer = 0

            If Array.IndexOf(data, S(0) & "," & S(1)) <> -1 Then
                A = Array.IndexOf(data, S(0) & "," & S(1))
            Else
                A = Array.IndexOf(data, S(1) & "," & S(0))
            End If

            Call count_weight(Val(S(1)), Val(S(2)) + weight(A))

        End If

    End Sub
    Sub find_short_path(ByRef now_root As Integer, ByRef now_weight As Integer)

        If now_root = goal And now_weight = node_weight(now_root) Then ''如果走的路徑是最小的成本值的話
            short_path.Add(now_root) : flag = True
        ElseIf now_root = goal And now_weight <> node_weight(now_root) Then '如果走的路徑不是最小的成本值的話就重走
            Exit Sub
        Else

            For I = 0 To UBound(path)

                If path(now_root, I) = 1 And visited_path(now_root, I) = 0 And visited_path(I, now_root) = 0 And flag = False Then

                    Dim A As Integer = 0

                    If Array.IndexOf(data, now_root & "," & I) <> -1 Then
                        A = Array.IndexOf(data, now_root & "," & I)
                    Else
                        A = Array.IndexOf(data, I & "," & now_root)
                    End If

                    short_path.Add(now_root) : visited_path(now_root, I) = 1 : visited_path(I, now_root) = 1 : Call find_short_path(I, now_weight + weight(A))

                ElseIf path(now_root, I) = 0 And I = UBound(path) And flag = False Then
                    short_path.Remove(now_root)
                End If

            Next

        End If

    End Sub
End Class
