Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        filereader = Trim(filereader) : Call z(filereader)

        Me.Close()
    End Sub
    Sub z(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(data)

            If Trim(data(i)) = "" Then Exit For

            Dim num As Integer = Val(Trim(data(i)))
            Dim ans As Integer = num * 12 / 7
            My.Computer.FileSystem.WriteAllText(".\out.txt", ans.ToString & vbCrLf, True)

        Next

    End Sub
End Class
