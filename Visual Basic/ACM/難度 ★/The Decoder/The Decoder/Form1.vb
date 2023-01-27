Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim S() As String = Split(filereader, vbCrLf) : Dim Ans As String = ""

        For I = 0 To UBound(S)

            For J = 1 To Len(S(I))
                Ans &= ChrW(AscW(Mid(S(I), J, 1)) - 7)
            Next


            My.Computer.FileSystem.WriteAllText(".\out.txt", Ans & vbCrLf, True) : Ans = ""

        Next I

    End Sub
End Class
