Public Class Form1
    Dim b() As String : Dim index As Integer = 1
    Dim ans As New List(Of String)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)

        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n

            Dim s As String = LineInput(fn)
            Dim num As Integer = 1

            index = 0

            For j = 1 To Len(s) '算排列組合後有幾種結果
                num *= j
            Next

            ReDim b(num)
            Dim a As String = ""

            For k = 1 To Len(s)
                a &= k
            Next

            Call z(a, "")



            If i <> n Then PrintLine(2, "") : ans.Clear()

        Next

    End Sub
    Sub z(ByRef stepp As String, ByRef st As String)
        Dim stm As String = ""

        If Len(st) < Len(stepp) Then

            For i = 1 To Len(stepp)
                stm = Mid(stepp, i, 1)
                If InStr(st, stm) = 0 Then Call z(stepp, st & stm)
            Next

        Else

            b(index) = st
            index += 1

        End If

    End Sub
End Class
