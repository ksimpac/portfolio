Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2

            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)

            filereader = Replace(filereader, ", ", " ") : filereader = Replace(filereader, "; ", " ") : filereader = Replace(filereader, ". ", " ") : filereader = Replace(filereader, ".", " ")

            Do Until InStr(filereader, "  ") = 0 '避免無限的空白
                filereader = Replace(filereader, "  ", " ")
            Loop

            Call y(filereader)

            My.Computer.FileSystem.WriteAllText(".\out.txt", "" & vbCrLf, True)

        Next


        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf) : Dim array2() As String
        Dim searchstr As String = data(0) : Dim times As Integer = 0
        Dim totaltimes As Integer = 0

        For i = 1 To UBound(data)

            If data(i) = "EOF" Then
                Exit For
            End If

            array2 = Split(data(i), " ")

            For j = 0 To UBound(array2)

                If array2(j) <> "" And LCase(array2(j)) = searchstr Then
                    times += 1
                    totaltimes += 1
                ElseIf array2(j) <> "" Then
                    totaltimes += 1
                End If

            Next

        Next

        My.Computer.FileSystem.WriteAllText(".\out.txt", times.ToString & "," & totaltimes.ToString & vbCrLf, True)

    End Sub
End Class
