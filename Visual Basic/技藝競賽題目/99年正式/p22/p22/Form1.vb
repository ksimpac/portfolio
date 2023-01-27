Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, False)
        Next


        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To 7
            Dim path() As String = Split(data(i), ", ")
        Next

    End Sub
End Class
