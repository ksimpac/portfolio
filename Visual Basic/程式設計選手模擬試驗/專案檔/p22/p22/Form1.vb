Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Call y(filereader)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf)
        

        For i = 0 To UBound(data)

            If data(i) = "" Then
                Exit Sub
            End If

            Dim str As String = ""
            Dim a(4) As String : Dim index = 1

            For j = 1 To Len(data(i)) '分割年.月.日
                If str = "" And IsNumeric(Mid(data(i), j, 1)) = True Then
                    str &= Mid(data(i), j, 1)
                ElseIf str <> "" And IsNumeric(Mid(data(i), j, 1)) = True Then
                    str &= Mid(data(i), j, 1)
                ElseIf str <> "" And IsNumeric(Mid(data(i), j, 1)) = False Then
                    a(index) = str
                    index += 1
                    str = ""
                End If
            Next

            Dim year, month, day As Integer : year = a(1) : month = a(2) : day = a(3)
            Dim AD As Integer = year + 1911 '換成西元
            Dim checkday As Integer
            Dim flag = True '日期是否正確

            If year >= 0 And year < 1000 Then

                If month = 2 Then

                    If AD Mod 400 = 0 Or AD Mod 4 = 0 And AD Mod 100 <> 0 Then
                        checkday = 29
                    Else
                        checkday = 28
                    End If

                    If day > checkday Then
                        flag = False
                    End If

                Else

                    If month > 0 And month < 13 Then

                        Select Case month
                            Case 1, 3, 5, 7, 8, 10, 12
                                checkday = 31
                            Case Else
                                checkday = 30
                        End Select

                        If day < 1 Or day > checkday Then
                            flag = False
                        End If

                    Else
                        flag = False
                    End If

                End If
            Else
                flag = False
            End If

            If flag = True Then
                My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
            End If

        Next
    End Sub
End Class
