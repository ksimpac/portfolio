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
            Dim S As String = data(I) : Dim Ascii(Len(S)), times(Len(S)) As Integer, index As Integer = 0

            For J = 1 To Len(S)
                Dim A As Integer = AscW(Mid(S, J, 1))

                If Array.IndexOf(Ascii, A) = -1 Then
                    Ascii(index) = A : times(index) = 1 : index += 1
                Else
                    times(Array.IndexOf(Ascii, A)) += 1
                End If
            Next

            Array.Sort(Ascii, times) : Array.Reverse(Ascii) : Array.Reverse(times)

            For K = 0 To index - 1
                My.Computer.FileSystem.WriteAllText(".\out.txt", Ascii(K).ToString & " " & times(K).ToString & vbCrLf, True)
            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

    End Sub
End Class
