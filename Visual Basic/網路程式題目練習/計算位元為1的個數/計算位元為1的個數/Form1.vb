Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)
        PrintLine(3, "")

        Me.Close()
    End Sub

    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s As Integer = LineInput(fn)
            Dim binary As String = z(s)

            Dim times As Integer = 0

            For j = 1 To Len(binary)
                If Mid(binary, j, 1) = "1" Then
                    times += 1
                End If
            Next

            PrintLine(3, times.ToString)
        Next
    End Sub
    Function z(ByVal data As Integer) '10進位轉2進位
        Dim num(99999) As Integer : Dim index As Integer = 1
        Dim c As Integer = 1 '商數
        Dim a, b As Integer 'a是被除數 b是除數
        a = data : b = 2

        Do Until c = 0
            c = a \ b
            num(index) = a Mod b
            a = c
            index += 1
        Loop

        Dim ans As String = ""

        For i = 1 To index - 1
            ans &= num(i)
        Next

        Return ans
    End Function
End Class
