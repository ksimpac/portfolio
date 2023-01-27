Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim array = Split(filereader, vbCrLf)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "out.txt"
        Dim filenum = FreeFile()
        Dim data() As String
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim a1, b1, c1, a2, b2, c2 As Integer
        Dim x, y As Integer
        For i = 0 To UBound(array) '分割一行資料
            data = Split(array(i), ",")
            a1 = Val(data(0)) : b1 = Val(data(1)) : c1 = Val(data(2)) : a2 = Val(data(3))
            b2 = Val(data(4)) : c2 = Val(data(5))
            x = ((c1 * b2) - (c2 * b1)) / ((a1 * b2) - (b1 * a2)) '公式計算
            y = ((a1 * c2) - (c1 * a2)) / ((a1 * b2) - (b1 * a2))
            PrintLine(filenum, "x=" & x & "," & "y=" & y) '寫入答案
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
End Class
