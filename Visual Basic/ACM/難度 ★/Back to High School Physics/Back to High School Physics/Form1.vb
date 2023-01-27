Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)

        For I = 0 To UBound(data)

            If data(I) = "" Then Exit For

            Dim S() As String = Split(data(I), " ")
            Dim V, T, Distance As Integer

            T = Val(S(0)) : V = Val(S(1))

            Distance = 2 * T * V

            My.Computer.FileSystem.WriteAllText(".\out.txt", Distance.ToString & vbCrLf, True)

        Next

    End Sub
End Class
