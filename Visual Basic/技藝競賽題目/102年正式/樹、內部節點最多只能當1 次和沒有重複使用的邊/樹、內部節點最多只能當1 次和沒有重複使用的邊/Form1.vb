Public Class Form1
    Dim path(,,) As Integer : Dim not_tree As New List(Of Boolean) : Dim internal_node() As String : Dim check_tree As String : Dim flag As Boolean : Dim root As Integer = 0
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

            check_tree = "" : not_tree.Clear()

            If i <> 1 Then Dim temp As String = LineInput(fn)

            Dim s As Integer = LineInput(fn)
            Dim check As New List(Of String) : ReDim path(s, 60, 60)

            For j = 1 To s

                Dim ss As String = LineInput(fn)

                Do Until InStr(ss, "  ") = 0 '去除多餘空白
                    ss = Replace(ss, "  ", " ")
                Loop

                Dim data() As String = Split(ss, " ")

                For k = 0 To UBound(data) '處理路徑兼檢查路徑是否有重複使用的邊

                    Dim node() As String = Split(data(k), "-")

                    If check.Count = 0 Then

                        check.Add(node(0) & "-" & node(1))
                        root = Val(node(0)) : path(j, Val(node(1)), Val(node(0))) = 1 : path(j, Val(node(0)), Val(node(1))) = 1

                    ElseIf check.IndexOf(node(0) & "-" & node(1)) = -1 And check.IndexOf(node(1) & "-" & node(0)) = -1 Then

                        check.Add(node(0) & "-" & node(1))
                        path(j, Val(node(1)), Val(node(0))) = 1 : path(j, Val(node(0)), Val(node(1))) = 1

                    Else
                        not_tree.Add(True)
                    End If

                Next

                If not_tree.IndexOf(True) <> -1 Then

                    If j <> s Then

                        For pp = 1 To s - j
                            Dim temp = LineInput(fn)
                        Next

                    End If

                    Exit For
                End If

            Next

            If not_tree.IndexOf(True) <> -1 Then PrintLine(3, "F") : Continue For

            Dim aa As String = "" : Dim times As Integer = 0 : ReDim internal_node(s)

            '檢查內部節點是否重複

            For m = 1 To s

                For j = 1 To 60

                    For k = 1 To 60
                        If path(m, j, k) = 1 Then times += 1
                    Next

                    If times > 1 Then aa &= j.ToString & " "

                    times = 0

                Next

                internal_node(m) = Trim(aa) : aa = "" : times = 0

            Next

            Dim flag1 As Boolean = False '檢查內部節點是否重複

            For sm = 1 To UBound(internal_node) Step 2

                Dim a() As String = Split(internal_node(sm), " ")
                Dim b() As String = Split(internal_node(sm + 1), " ")

                For fa = 0 To UBound(a)

                    For fb = 0 To UBound(b)
                        If a(fa) = b(fb) Then flag1 = True : Exit For
                    Next

                    If flag1 = True Then Exit For

                Next

                If flag1 = True Then Exit For

            Next

            If flag1 = True Then PrintLine(3, "F") : Continue For

            For pk = 1 To s
                flag = True : flag = walk(pk, root)
                not_tree.Add(flag) : check_tree = ""
            Next

            If not_tree.IndexOf(True) <> -1 Then
                PrintLine(3, "F")
            Else
                PrintLine(3, "T")
            End If

        Next

    End Sub
    Function walk(ByVal num As Integer, ByVal now As Integer) As Boolean

        If check_tree <> "" And InStr(check_tree, now) <> 0 Then
            flag = False
        Else

            For i = 1 To 60
                If path(num, now, i) = 1 And InStr(check_tree, i) = 0 Then check_tree &= now : walk(num, i)
            Next

        End If

    End Function
End Class
