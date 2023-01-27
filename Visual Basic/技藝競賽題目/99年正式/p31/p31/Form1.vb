Public Class Form1
    Dim require As String : Dim compare As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim data() As String = Split(filereader, vbCrLf) : require = data(0) : Dim flag As Boolean = False

        For i = 1 To UBound(data)

            data(i) = Replace(data(i), ",", "") : data(i) = Replace(data(i), ".", "") : data(i) = Replace(data(i), "  ", " ")

            For j = 1 To Len(data(i)) - Len(require) + 1 '暴力法比較字串

                Call s(Mid(data(i), j, Len(require)))

                If compare = require Then
                    My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True) : flag = True : Exit For
                Else
                    compare = ""
                End If

            Next

            If flag = False Then My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)

            flag = False

        Next

    End Sub
    Sub s(ByVal str As String)

        For i = 1 To Len(str)

            Dim ss As String = Mid(str, i, 1)

            If ss = " " Then
                compare &= "%"
            ElseIf AscW(ss) >= 65 And AscW(ss) <= 90 Then
                compare &= "*"
            ElseIf AscW(ss) >= 97 And AscW(ss) <= 122 Then
                compare &= "$"
            Else
                compare &= "#"
            End If

        Next

    End Sub
End Class
