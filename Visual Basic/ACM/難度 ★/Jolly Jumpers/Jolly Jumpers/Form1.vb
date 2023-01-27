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

            Dim Num As New List(Of Integer)
            Dim S() As String = Split(data(I), " ")

            For J = 1 To UBound(S) - 1
                Num.Add(Math.Abs(S(J + 1) - S(J)))
            Next

            Dim flag As Boolean = True

            For K = 1 To Num.Count - 1
                If Num(K) + 1 <> Num(K - 1) And Num(K) - 1 <> Num(K - 1) Then flag = False : Exit For
            Next

            Dim Ans As String = ""

            If flag = True Then
                Ans = "Jolly"
            Else
                Ans = "Not Jolly"
            End If

            My.Computer.FileSystem.WriteAllText(".\out.txt", Ans & vbCrLf, True)

        Next

    End Sub
End Class
