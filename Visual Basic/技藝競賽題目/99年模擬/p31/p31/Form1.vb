Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in-3-1.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)


        Do Until InStr(filereader, "  ") = 0
            filereader = Replace(filereader, "  ", " ")
        Loop

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(data)

            Dim s() As String = Split(data(i), " ") : Dim check As String = "" : Dim flag As Boolean = False

            For j = 0 To UBound(s)

                For k = 1 To Len(s(j))

                    If AscW(Mid(s(j), k, 1)) >= 48 And AscW(Mid(s(j), k, 1)) <= 57 Then

                        For m = k To Len(s(j))

                            Select Case AscW(Mid(s(j), m, 1))
                                Case 48 To 57
                                    check &= "#"
                                Case 65 To 90
                                    check &= "@"
                                Case Else
                                    check &= "?"
                            End Select

                            If check = "#@#" Or check = "#@@#" Or check = "#@@@#" Then flag = True : Exit For
                            If Len(check) = 5 Then check = "" : Continue For
                        Next



                    Else
                        Continue For
                    End If

                Next

                If flag = True Then Exit For

            Next

            If flag = True Then
                My.Computer.FileSystem.WriteAllText(".\out-3-1.txt", "有" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out-3-1.txt", "沒有" & vbCrLf, True)
            End If

        Next

    End Sub
End Class
