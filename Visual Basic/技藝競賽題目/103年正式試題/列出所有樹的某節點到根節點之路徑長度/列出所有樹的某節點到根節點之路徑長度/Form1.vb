Public Class Form1
    Dim path(,,) As Integer
    Dim root, treenum, nodenum, findnode, legth As Integer
    Dim a As New List(Of Integer)
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

            Dim t() As String = Split(LineInput(fn), ",") '分割節點個數,樹的數目,以及要找的節點
            ReDim path(Val(t(1)), Val(t(0)) - 1, Val(t(0)) - 1) : Dim j As Integer
            root = 0 : treenum = 0 : nodenum = 0 : findnode = 0 : legth = 0

            For j = 1 To Val(t(0)) '從節點數下手

                Dim s As String = LineInput(fn)

                '避免無限的空白

                Do Until InStr(s, "  ") = 0
                    s = Replace(s, "  ", " ")
                Loop

                Dim data() As String = Split(s, " ")
                Dim k As Integer

                For k = 1 To Val(t(1)) '從第一棵樹開始

                    If data(1) = "999" Then '如果有999的表示是這棵樹的根結點(root)
                        root = Val(data(0)) : Exit For
                    Else
                        path(k, data(k), data(0)) = 1 'path(第幾棵樹,父節點,子節點)
                    End If

                Next

            Next

            treenum = Val(t(1)) : nodenum = Val(t(0)) : findnode = t(2)

            For n = 1 To treenum '一棵一棵樹慢慢處理
                treenum = n '控制副程式要處理第幾棵樹
                z(root, 0)
                a.Add(legth) '答案放到a這個List(串列) '可隨時變動長度
                legth = 0
            Next

            Dim ans As String = ""

            For p = 0 To a.Count - 1

                If p <> a.Count - 1 Then
                    ans &= a.Item(p) & ","
                Else
                    ans &= a.Item(p)
                End If

            Next

            PrintLine(3, ans)
            a.Clear()

        Next

    End Sub
    Sub z(ByRef nowroot As Integer, ByRef lett As Integer) 'lett為長度

        If nowroot = findnode Then '如果跑到的節點如果是題目要找的節點的話直接結束遞迴並把路徑算出來用全域變數保存
            legth = lett
            Exit Sub
        Else
            For i = 0 To nodenum - 1
                If path(treenum, nowroot, i) = 1 Then Call z(i, lett + 1)
            Next
        End If

    End Sub
End Class
