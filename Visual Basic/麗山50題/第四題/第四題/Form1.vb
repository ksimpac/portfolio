Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(s)

            s(i) = Trim(s(i))

            If s(i) = "" Then Exit For

            Dim num As Integer = 0

            For j = 1 To Len(s(i))
                num += Val(Mid(s(i), j, 1))
            Next

            If num Mod 9 = 0 Then
                My.Computer.FileSystem.WriteAllText(".\out.txt", "是" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out.txt", "不是" & vbCrLf, True)
            End If

        Next

    End Sub
End Class
