Public Class Form1
    Dim num(720) As String : Dim index As Integer = 1
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

        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s() = Split(LineInput(fn), ", ")
            Call z(s(0), "")
            Dim num1 As Integer = num(s(1)) : Dim num2 As Integer = num(s(2))
            Dim a As String = GCD(num1, num2)
            PrintLine(3, a)
            a = ""
            Array.Clear(num, 0, 721) : index = 1
        Next

    End Sub
    Sub z(ByRef stepp As String, ByRef st As String) '排列組合
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

    Function GCD(ByVal a As Integer, ByVal b As Integer) '最大公因數(使用遞迴)
        Dim c As Integer = a Mod b

        If c <> 0 Then
            Return GCD(b, c)
        Else
            Return b
        End If

    End Function
End Class
