Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()

        Dim a() As Integer = {1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55}
        Dim result As String = ""

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\data.txt")

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(data)

            Dim num() As String = Split(data(i), ",")

            For j = 0 To UBound(num)
                Dim find_index As Integer = 0
                Dim temp As Integer = Val(num(j))
                find_index = Array.IndexOf(a, temp)
                a(find_index) = 0
            Next

        Next

        For i = 0 To UBound(a)
            If a(i) <> 0 Then
                result &= a(i).ToString & ","
            End If
        Next

        MsgBox(result)
        Me.Close()

    End Sub
End Class
