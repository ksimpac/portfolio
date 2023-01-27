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

            If data(i) = "" Then Exit For

            If AscW(Trim(data(i))) >= AscW("a") And AscW(Trim(data(i))) <= AscW("w") Then
                My.Computer.FileSystem.WriteAllText(".\out.txt", ChrW(AscW(Trim(data(i))) + 3) & vbCrLf, True)
            Else

                Dim a As String = ""

                Select Case Trim(data(i))
                    Case "x"
                        a = "a"
                    Case "y"
                        a = "b"
                    Case "z"
                        a = "c"
                End Select

                My.Computer.FileSystem.WriteAllText(".\out.txt", a & vbCrLf, True)

            End If


        Next

    End Sub
End Class
