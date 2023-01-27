Public Class Form1
    Dim root As Integer : Dim path(,) As Integer : Dim foliage As New List(Of String) : Dim node As New List(Of String) '節點與索引對照
    Dim legth As New List(Of Integer)
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

        Dim n As Integer = LineInput(fn) : ReDim path(n - 1, n - 1)

        For i = 1 To n

            Dim s As String = LineInput(fn)

            Do Until InStr(s, " ") = 0 '避免空白出現
                s = Replace(s, " ", "")
            Loop

            Dim data() As String = Split(s, ",")
            node.Add(data(0))
            If data(1) = "---" Then root = node.Count - 1 : Continue For

            path(node.IndexOf(data(1)), node.IndexOf(data(0))) = 1

        Next

        Dim flag As Boolean = False

        For j = 0 To n - 1 '兩個迴圈判斷是不是終端節點

            For k = 0 To n - 1

                If path(j, k) = 1 Then flag = True : Exit For

                If k = n - 1 And flag = False Then foliage.Add(node.Item(j))

            Next

            flag = False

        Next

        For m = 0 To foliage.Count - 1 '把每個終端節點下去跑一次，計算走到該節點要幾個邊
            Call walk(root, 0, node.IndexOf(foliage.Item(m)))
        Next



        For ans = 0 To foliage.Count - 1
            PrintLine(3, foliage.Item(ans) & " " & legth.Item(ans))
        Next


        foliage.Clear() : legth.Clear() : node.Clear()

    End Sub
    Sub walk(ByRef root_1 As Integer, ByRef legeth As Integer, ByVal goal As Integer) '跑樹的路徑

        If root_1 = goal Then
            legth.Add(legeth) '紀錄經過幾個邊
        Else

            For i = 0 To UBound(path)
                If path(root_1, i) = 1 Then Call walk(i, legeth + 1, goal) '有路就往下走(堆疊(stack))
            Next

        End If

    End Sub
End Class
