Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)

        Dim A() As String = {"`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=",
                                "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "[", "]", "\",
                                "a", "s", "d", "f", "g", "h", "j", "k", "l", ";", "'",
                               "z", "x", "c", "v", "b", "n", "m", ",", ".", "/"}

        For I = 0 To UBound(data)

            If data(I) = "" Then Exit For

            Dim Ans As String = ""

            For J = 1 To Len(data(I))

                If Mid(data(I), J, 1) = " " Then
                    Ans &= Mid(data(I), J, 1)
                Else
                    Ans &= A(Array.IndexOf(A, Mid(data(I), J, 1)) - 2)
                End If

            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", Ans & vbCrLf, True)

        Next

    End Sub
End Class
