Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call z(Trim(filereader))

        Me.Close()
    End Sub
    Sub z(ByVal filereader As String)

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 1 To UBound(s) Step 2

            If Trim(s(i)) = "" Then Exit For

            Dim data() As String = Split(s(i), ",")
            Dim max_earn As Integer = 0 '最大獲利
            Dim enter, out As Integer '進場,出場

            For j = 0 To UBound(data) - 1

                For k = j + 1 To UBound(data)

                    If Val(data(k)) - Val(data(j)) > max_earn Then
                        enter = Val(data(j)) : out = Val(data(k)) : max_earn = Val(data(k)) - Val(data(j))
                    End If

                Next

            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", enter.ToString & "," & out.ToString & "," & max_earn.ToString & vbCrLf, True)
            enter = 0 : out = 0

        Next

    End Sub
End Class
