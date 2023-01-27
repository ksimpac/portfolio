Public Class Form1
    Dim path(16, 16) As Integer : Dim flag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText("in2-1.txt")
        FileOpen(3, "out2-1.txt", OpenMode.Output)
        Dim array1() = Split(filereader, vbCrLf)
        Call y(array1)

        Me.Close()
    End Sub
    Sub y(ByVal array1() As String) '處理路徑

        For i = 0 To UBound(array1)

            If array1(i) = "" And i <> UBound(array1) Then
                flag = False : Call visit(1, 1) : PrintLine(3, UCase(Str(flag))) : ReDim path(16, 16) : Continue For
            ElseIf array1(i) = "" And i = UBound(array1) Then
                flag = False : Call visit(1, 1) : PrintLine(3, UCase(Str(flag))) : Exit For
            End If

            Dim chrnum As Integer = 1

            Do Until chrnum = 16 '處理地圖 從一到十五(0跟16是圍牆)

                If i < 15 Then
                    path(i + 1, chrnum) = Val(Mid(array1(i), chrnum, 1))
                    chrnum += 1
                Else
                    path(i - 15 + 1, chrnum) = Val(Mid(array1(i), chrnum, 1))
                    chrnum += 1
                End If

            Loop

            For j = 0 To 16 '建立外圍圍牆 避免走出去地圖外(也避免超過陣列限度)
                path(0, j) = 1 : path(j, 0) = 1 : path(16, j) = 1 : path(j, 16) = 1
            Next

            If array1(i) <> "" And i < 15 Then
                Continue For
            ElseIf array1(i) <> "" And i < 31 Then
                Continue For
            End If

        Next

    End Sub
    Function visit(ByRef i As Integer, ByRef j As Integer) As Boolean '走迷宮路徑

        If i = 15 And j = 15 Then
            flag = True
        Else

            If flag = False And path(i, j + 1) = 0 Then '向右走
                path(i, j + 1) = 1
                visit(i, j + 1)
            End If

            If flag = False And path(i + 1, j) = 0 Then '向下走
                path(i + 1, j) = 1
                visit(i + 1, j)
            End If

            If flag = False And path(i, j - 1) = 0 Then '向左走
                path(i, j - 1) = 1
                visit(i, j - 1)
            End If

            If flag = False And path(i - 1, j) = 0 Then '向上走
                path(i - 1, j) = 1
                visit(i - 1, j)
            End If

        End If

    End Function
End Class
