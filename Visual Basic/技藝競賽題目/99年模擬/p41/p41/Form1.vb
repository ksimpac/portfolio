Public Class Form1
    Dim Permutations As New List(Of String)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in-4-1.txt")
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, " ") = 0
            filereader = Replace(filereader, " ", "")
        Loop

        Dim data() As String = Split(filereader, vbCrLf)

        Dim profit() As String = Split(data(0), ",") : Dim kg() As String = Split(data(1), ",") : Dim a As String = "肉菜蛋果"
        Call z(a, "") : Dim total As New List(Of Integer) : Dim max_total As Integer = 0

        For i = 0 To Permutations.Count - 1

            Dim num As Integer = 0

            For j = 1 To Len(Permutations(i))
                num += Val(profit(InStr(a, Mid(Permutations(i), j, 1)) - 1)) * kg(j - 1)
            Next

            If num > max_total Then max_total = num

            total.Add(num)

        Next

        For j = max_total To 0 Step -1

            For k = 0 To total.Count - 1
                If j = total(k) Then My.Computer.FileSystem.WriteAllText(".\out-4-1.txt", Permutations(k) & " " & total(k).ToString & vbCrLf, True)
            Next

        Next

    End Sub
    Sub z(ByRef stepp As String, ByRef st As String)

        Dim stm As String = ""

        If Len(stepp) > Len(st) Then

            For i = 1 To Len(stepp)
                stm = Mid(stepp, i, 1)
                If InStr(st, stm) = 0 Then Call z(stepp, st & stm)
            Next
        Else
            Permutations.Add(st)
        End If

    End Sub
End Class
