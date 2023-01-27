Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in-1-1.txt", OpenMode.Input)
        FileOpen(3, "out-1-1.txt", OpenMode.Output)

        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim n As Integer = Trim(LineInput(fn))

        Dim charater(25) As Integer

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn))

            For j = 1 To Len(s)
                If AscW(Mid(s, j, 1)) >= 65 And AscW(Mid(s, j, 1)) <= 90 Or AscW(Mid(s, j, 1)) >= 97 And AscW(Mid(s, j, 1)) <= 122 Then charater(AscW(UCase(Mid(s, j, 1))) - 65) += 1
            Next

        Next

        Dim ans As String = ""

        For k = 0 To 25 Step 5

            If k <> 25 Then
                PrintLine(3, "(" & ChrW(65 + k) & ", " & (charater(k)).ToString & ")" & " " & "(" & ChrW(65 + k + 1) & ", " & (charater(k + 1)).ToString & ")" & " " & "(" & ChrW(65 + k + 2) & ", " & (charater(k + 2)).ToString & ")" & " " & "(" & ChrW(65 + k + 3) & ", " & (charater(k + 3)).ToString & ")" & " " & "(" & ChrW(65 + k + 4) & ", " & (charater(k + 4)).ToString & ")")
            Else
                PrintLine(3, "(" & ChrW(65 + k) & ", " & (charater(k)).ToString & ")")
            End If

        Next

    End Sub
End Class
