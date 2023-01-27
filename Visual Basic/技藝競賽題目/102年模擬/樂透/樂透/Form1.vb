Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)
        PrintLine(3, "")
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n() As String = Split(LineInput(fn), ":") : n(1) = Trim(n(1))
        Dim a() As String = Split(n(1), ", ")
        Dim winning_numbers As New List(Of String)

        For i = 0 To UBound(a)
            winning_numbers.Add(a(i))
        Next

        For j = 1 To Val(n(0))

            Dim b() As String = Split(LineInput(fn), ", ")
            Dim times As Integer = 0

            For k = 0 To UBound(b)
                If winning_numbers.Contains(b(k)) = True Then times += 1
            Next

            If times < 2 Then
                PrintLine(3, "N")
            Else
                PrintLine(3, times.ToString())
            End If

        Next


    End Sub
End Class
