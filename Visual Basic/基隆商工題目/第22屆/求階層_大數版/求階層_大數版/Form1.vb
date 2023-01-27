Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        '讀檔案(兼分割)
        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Dim array = Split(filereader, vbCrLf)
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        '需要的變數宣告
        Dim a As String = "1" '放1乘到i的結果
        Dim b As String = "" '放i的字串
        Dim sum As Long = 0 '放入"乘出來的結果"
        Dim NowIndex As Long = 0 '索引
        Dim d As Long = 0 '
        Dim g As String = "" '放入答案
        Dim num(90) As String '放數字字串
        '開檔
        'Dim filenum = FreeFile()
        'FileOpen(filenum, "out.txt", OpenMode.Append)
        For i = 1 To 20
            b = i
            For j = Len(a) To 1 Step -1
                NowIndex = d
                For k = Len(b) To 1 Step -1
                    sum = num(NowIndex) + Mid(a, j, 1) * Mid(b, k, 1)
                    num(NowIndex + 1) = sum \ 10 + num(NowIndex + 1)
                    num(NowIndex) = sum Mod 10
                    NowIndex += 1
                Next
                d += 1
                For k = UBound(num) To 0 Step -1
                    g &= num(k)
                Next
                Do Until Val(Mid(g, 1, 1)) <> 0
                    g = Mid(g, 2)
                Loop
            Next
        Next
        Me.Close()
    End Sub
End Class
