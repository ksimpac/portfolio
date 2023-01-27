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

        Dim n As Integer = LineInput(fn)

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn)) : Dim num As String = ""

            If AscW(Mid(s, 1, 1)) >= 65 And AscW(Mid(s, 1, 1)) <= 72 Then
                num = (AscW(Mid(s, 1, 1)) - 55).ToString
            ElseIf AscW(Mid(s, 1, 1)) >= 74 And AscW(Mid(s, 1, 1)) <= 78 Then
                num = (AscW(Mid(s, 1, 1)) - 56).ToString
            ElseIf AscW(Mid(s, 1, 1)) >= 80 And AscW(Mid(s, 1, 1)) <= 86 Then
                num = (AscW(Mid(s, 1, 1)) - 57).ToString
            Else

                Select Case Mid(s, 1, 1)
                    Case "I" : num = "34"
                    Case "O" : num = "35"
                    Case "W" : num = "32"
                    Case "X" : num = "30"
                    Case "Y" : num = "31"
                    Case "Z" : num = "33"
                End Select

            End If

            s = num & Microsoft.VisualBasic.Right(s, Len(s) - 1)

            Dim total As Integer = 0

            For j = 1 To Len(s)

                If j = 1 Or j = Len(s) Then
                    total += Val(Mid(s, j, 1)) * 1
                Else
                    total += Val(Mid(s, j, 1)) * (10 - j + 1)
                End If

            Next

            If total Mod 10 = 0 Then
                PrintLine(3, "T")
            Else
                PrintLine(3, "F")
            End If

        Next

    End Sub
End Class
