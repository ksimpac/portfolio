Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call y(filereader)

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf)
        Dim prime(99999) As Integer : Dim index As Integer = 0
        z(prime, index)






        

    End Sub
    Function z(ByRef prime() As Integer, ByRef index As Integer) '質數表
        Dim flag = False

        For i = 2 To 2147483648
            For j = 2 To i \ 2
                If i Mod j = 0 Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = False Then
                prime(index) = i
                index += 1
            End If
        Next

        Return prime
    End Function
End Class
