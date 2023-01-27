Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in-3-2.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, "  ") = 0 And InStr(filereader, ", ") = 0
            filereader = Replace(filereader, "  ", " ") : filereader = Replace(filereader, ", ", " ")
        Loop

        filereader = Replace(filereader, ".", "")

        Dim data() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(data)

            Dim ID As String = "" : Dim ID_List As New List(Of String) : Dim flag As New List(Of Boolean)

            For j = 1 To Len(data(i))

                If AscW(Mid(data(i), j, 1)) >= 65 And AscW(Mid(data(i), j, 1)) <= 90 And AscW(Mid(data(i), j + 1, 1)) >= 48 And AscW(Mid(data(i), j + 1, 1)) <= 57 Then

                    Dim k As Integer = 0

                    For k = j To j + 9

                        If j <> k Then

                            If AscW(Mid(data(i), k, 1)) >= 48 And AscW(Mid(data(i), k, 1)) <= 57 Then
                                ID &= Mid(data(i), k, 1)
                            Else
                                Exit For
                            End If
                        Else
                            ID &= Mid(data(i), k, 1)
                        End If

                    Next

                    j = k

                    If Len(ID) <> 10 Then
                        ID = "" : Exit For
                    Else
                        ID_List.Add(ID) : flag.Add(False)
                    End If

                    ID = ""

                Else
                    Continue For
                End If




            Next

            For m = 0 To ID_List.Count - 1

                If (Mid(ID_List(m), 1, 1) = "A" Or Mid(ID_List(m), 1, 1) = "B" Or Mid(ID_List(m), 1, 1) = "E") And (Mid(ID_List(m), 2, 1) = "1" Or Mid(ID_List(m), 2, 1) = "2") Then

                    Dim num As String = "" : Dim total As Integer = 0

                    Select Case Mid(ID_List(m), 1, 1)
                        Case "A"
                            num = "10"
                        Case "B"
                            num = "11"
                        Case "E"
                            num = "14"
                    End Select


                    num &= Microsoft.VisualBasic.Right(ID_List(m), Len(ID_List(m)) - 1)

                    For s = 1 To Len(num)

                        If s = 1 Or s = 10 Or s = 11 Then
                            total += Val(Mid(num, s, 1))
                        Else
                            total += Val(Mid(num, s, 1)) * (11 - s)
                        End If

                    Next

                    If total Mod 10 = 0 Then
                        flag(m) = True
                    End If

                End If

            Next

            If flag.IndexOf(True) <> -1 Then
                My.Computer.FileSystem.WriteAllText(".\out-3-2.txt", "有" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out-3-2.txt", "沒有" & vbCrLf, True)
            End If

        Next

    End Sub
End Class
