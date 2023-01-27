Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call z(Trim(filereader))

        Me.Close()
    End Sub
    Sub z(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(data)

            If Trim(data(i)) = "" Then Exit For

            Dim q As Integer = Val(Trim(data(i))) \ 3
            Dim ans As Integer = 0

            For j = 0 To q
                ans += j
            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", ans.ToString & vbCrLf, True)

        Next

    End Sub
End Class
