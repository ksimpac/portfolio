Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
        Next

        Me.Close()

    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf)
        Dim str1 As String = data(0)
        Dim a(9) As String : Dim index As Integer = 1
        a(0) = str1
        For i = 7 To 1 Step -1
            str1 = Replace(str1, i, "")
            str1 = i & str1
            a(index) = str1
            index += 1
        Next

        For j = 7 To 0 Step -1
            My.Computer.FileSystem.WriteAllText(".\out.txt", a(j) & vbCrLf, True)
        Next
    End Sub
End Class
