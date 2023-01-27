Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        '處理不需要的計算字元(減少程式執行次數)
        filereader = Replace(filereader, Mid(filereader, 1, 1), "") : filereader = Replace(filereader, vbCrLf, "")
        filereader = Replace(filereader, "，", "") : filereader = Replace(filereader, "。", "") : filereader = Replace(filereader, "；", "")
        filereader = Replace(filereader, "、", "") : filereader = Replace(filereader, "！", "") : filereader = Replace(filereader, "？", "")

        Dim current_max As Integer = 0 '出現最多的次數 等等會用到
        Dim strnum As Integer = 1

        Dim character As New List(Of String) : Dim times As Integer = 0 : Dim frequency As New List(Of Integer)

        Do Until strnum > Len(filereader)
            character.Add(Mid(filereader, strnum, 2))
            strnum += 1
        Loop

        For i = 0 To character.Count - 1

            For j = 1 To Len(filereader)
                If character(i) = Mid(filereader, j, 2) Then times += 1
            Next

            frequency.Add(times) : times = 0

        Next

        For k = 0 To frequency.Count - 1
            If current_max < frequency(k) Then current_max = frequency(k) '找最大值
        Next

        Dim str As String = ""

        For m = 0 To frequency.Count - 1
            If frequency(m) = current_max And InStr(str, character(m)) = 0 Then My.Computer.FileSystem.WriteAllText(".\out.txt", character(m) & " " & frequency(m) & vbCrLf, True) : str &= character(m)
        Next

    End Sub
End Class
