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

            Dim s As String = Trim(LineInput(fn)) : Dim str As String = "" : Dim ans As String = ""

            For j = 1 To Len(s) '暴力法一個一個串

                str &= Mid(s, j, 1)

                Select Case str
                    Case "0" : ans &= "A" : str = ""
                    Case "10" : ans &= "B" : str = ""
                    Case "110" : ans &= "C" : str = ""
                    Case "1110" : ans &= "D" : str = ""
                    Case "11110" : ans &= "E" : str = ""
                    Case "11111" : ans &= "F" : str = ""
                End Select

                If Len(str) = 5 And str <> "0" And str <> "10" And str <> "110" And str <> "1110" And str <> "11110" And str <> "11111" Then
                    ans &= "%" : Exit For
                End If

            Next


            If InStr(ans, "%") = 0 And str = "" Then
                PrintLine(3, ans)
            Else
                PrintLine(3, "NULL")
            End If

        Next

    End Sub
End Class

