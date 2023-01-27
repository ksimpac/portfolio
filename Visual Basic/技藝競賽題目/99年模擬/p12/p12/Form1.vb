Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in-1-2.txt", OpenMode.Input)
        FileOpen(3, "out-1-2.txt", OpenMode.Output)


        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = Trim(LineInput(fn))

        Dim characher As New List(Of String)

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn)) : Dim data() As String = Split(s, " ")

            For j = 0 To UBound(data)

                If (Mid(data(j), 1, 1) = "a" Or Mid((data(j)), 1, 1) = "A") And characher.IndexOf(data(j)) = -1 Then
                    data(j) = Replace(data(j), ".", "") : data(j) = Replace(data(j), ",", "") : characher.Add(data(j))
                End If

            Next

        Next

        For k = 0 To characher.Count - 1
            PrintLine(3, characher(k))
        Next

    End Sub
End Class
