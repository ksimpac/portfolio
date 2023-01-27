Public Class Form1
    Dim btree() As Integer : Dim bool() As Boolean : Dim last_ball_location As New List(Of Integer) : Dim flag As Boolean : Dim foliage As New List(Of Integer)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)


        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim N As Integer = LineInput(fn)

        For I = 1 To N

            Dim S As String = Trim(LineInput(fn))

            Do Until InStr(S, "  ") = 0 '去除多餘空白
                S = Replace(S, "  ", " ")
            Loop


            Dim data() As String = Split(S, " ") : Dim A As Integer = 2 ^ Val(data(0)) - 1
            ReDim btree(A) : ReDim bool(A) : Dim J As Integer

            For J = 1 To UBound(btree)
                btree(J) = J
            Next

            For K = 1 To A '找終端節點(葉子)
                '利用深度與葉子數的關係去判斷是不是葉子
                If K > 2 ^ (Val(data(0)) - 1) - 1 Then foliage.Add(K)
            Next

            last_ball_location.Clear() : last_ball_location.Add(-1) : flag = False

            For M = 1 To Val(data(1)) '一個一個球依序丟下去
                Call drop(1, 1) : flag = False
            Next

            PrintLine(3, last_ball_location(Val(data(1))).ToString) : foliage.Clear()

        Next

    End Sub
    Sub drop(ByRef now_root As Integer, ByRef level As Integer)

        If foliage.IndexOf(now_root) <> -1 And flag = False Then '如果走到終端節點(葉子)
            last_ball_location.Add(now_root) : flag = True : Exit Sub
        ElseIf bool(now_root) = True AndAlso flag = False Then '如果這個點是False的話走左子樹
            level = level * 2 + 1 : bool(now_root) = False : Call drop(btree(level), level)
        ElseIf bool(now_root) = False AndAlso flag = False Then '如果這個點是True的話走左子樹
            level = level * 2 : bool(now_root) = True : Call drop(btree(level), level)
        End If


    End Sub
End Class
