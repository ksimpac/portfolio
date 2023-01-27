Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory & "\out.txt"
        Dim filenum = FreeFile()
        FileOpen(filenum, "out.txt", OpenMode.Append)
        Dim a As Integer = 0
        Dim array2(4) As String : Dim array3(4) As String
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Dim array1 = Split(filereader, vbCrLf)
            For j = 1 To UBound(array1) Step 2
                array2 = Split(array1(j), ", ")
                array3 = Split(array1(j + 1), ", ")
                a = check(array2, array3)
                PrintLine(filenum, a.ToString)
            Next
            If i = 1 Then
                PrintLine(filenum)
            End If
        Next
        FileClose(filenum)
        Me.Close()
    End Sub
    Private Function check(ByVal num1() As String, ByVal num2() As String) As Integer 'num1簽的數字 num2為開獎號碼
        Dim times As Integer
        Dim a, b As String
        For i = 0 To UBound(num1)
            a = Trim(num1(i))
            For j = 0 To UBound(num2)
                b = Trim(num2(j))
                If a = b Then
                    times += 1
                End If
            Next
        Next
        Return times
    End Function
End Class
