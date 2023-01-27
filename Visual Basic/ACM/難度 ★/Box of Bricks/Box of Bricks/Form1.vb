Public Class Form1
    Dim Bricks() As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf) : Dim N As Integer = 0 : Dim times As Integer = 0

        For I = 0 To UBound(data)

            If data(I) = "0" Then Exit For
            If N = 0 Then N = data(I) : Continue For

            Dim A() As String = Split(data(I), " "), Num As Integer = 0
            ReDim Bricks(UBound(A))

            For J = 0 To UBound(A)
                Bricks(J) = A(J)
                Num += Bricks(J)
            Next

            Dim Height As Integer = Num / N

            Dim move_box As Integer = 0

            Do Until z() = True
                Array.Sort(Bricks) : Array.Reverse(Bricks) : Dim B As Integer = 0
                B = Bricks(0) - Height : Bricks(0) = Height : Bricks(UBound(Bricks)) += B : move_box += B
            Loop

            My.Computer.FileSystem.WriteAllText(".\out.txt", "Set #" & times.ToString & vbCrLf, True)
            My.Computer.FileSystem.WriteAllText(".\out.txt", "The minimum number of moves is " & move_box.ToString & "." & vbCrLf & vbCrLf, True)

            times += 1 : N = 0 : Array.Clear(Bricks, 0, A.Length)

        Next

    End Sub
    Function z() As Boolean

        Dim flag As Boolean = True

        For I = 0 To UBound(Bricks) - 1
            If Bricks(I) <> Bricks(I + 1) Then flag = False : Exit For
        Next

        Return flag

    End Function
End Class
