Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf)
        Dim A As New List(Of Integer)


        For I = 0 To UBound(data)

            If data(I) = "" Then Exit For
            A.Add(Val(data(I))) : A.Sort() : Dim Median As Integer = 0

            If A.Count Mod 2 = 1 Then
                Median = A(Int(A.Count / 2))
            ElseIf A.Count = 2 Then
                Median = Int((A(A.Count / 2) + A((A.Count / 2) - 1)) / 2)
            Else
                Median = Int((A(A.Count / 2 - 1) + A(A.Count / 2)) / 2)
            End If

            My.Computer.FileSystem.WriteAllText(".\out.txt", Median.ToString & vbCrLf, True)

        Next

    End Sub
End Class
