Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(1, "in-3-1-1.txt", OpenMode.Input)
        FileOpen(2, "in-3-1-2.txt", OpenMode.Input)
        FileOpen(3, "out-3-1.txt", OpenMode.Output)

        Call y(1)
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n

            Dim s As String = LineInput(fn) : Dim a As String = ""
            a = ss(Microsoft.VisualBasic.Left(s, 1))
            Dim num As Integer = 0

            For j = 1 To 2

                If j = 1 Then
                    num += Val(Mid(a, j, 1))
                Else
                    num += Val(Mid(a, j, 1)) * 9
                End If

            Next

            Dim z As Integer = 8

            For j = 2 To 10
                num += Val(Mid(s, j, 1)) * z
                If z <> 1 Then z = z - 1
            Next

            If num Mod 10 = 0 Then
                PrintLine(3, "1")
            Else
                PrintLine(3, "0")
            End If
        Next

    End Sub
    Function ss(ByVal str As String)

        If AscW(str) >= 65 And AscW(str) <= 72 Then
            Return (AscW(str) - 55).ToString()
        ElseIf AscW(str) >= 74 And AscW(str) <= 78 Then
            Return (AscW(str) - 56).ToString()
        ElseIf AscW(str) >= 80 And AscW(str) <= 86 Then
            Return (AscW(str) - 57).ToString()
        Else

            Select Case str
                Case "I"
                    Return "34"
                Case "O"
                    Return "35"
                Case "W"
                    Return "32"
                Case "X"
                    Return "30"
                Case "Y"
                    Return "31"
                Case Else
                    Return "33"
            End Select

        End If

    End Function
End Class
