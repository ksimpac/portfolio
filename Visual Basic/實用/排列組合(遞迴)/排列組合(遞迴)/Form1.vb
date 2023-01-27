Public Class Form1
    Dim num(999999) As String : Dim index As Integer = 1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim a = "1234"
        Dim st = ""

        z(a, st)


        Me.Close()
    End Sub
    Sub z(ByRef stepp As String, ByRef st As String)
        Dim stm As String = ""
        If Len(st) < Len(stepp) Then
            For i = 1 To Len(stepp)
                stm = Mid(stepp, i, 1)
                If InStr(st, stm) = 0 Then Call z(stepp, st & stm)
            Next
        Else
            num(index) = st
            index += 1
        End If
    End Sub
End Class
