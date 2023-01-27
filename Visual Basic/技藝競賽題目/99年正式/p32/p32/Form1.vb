Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        filereader = Replace(filereader, " ", "")

        Dim data() As String = Split(filereader, vbCrLf)

        Dim year, mouth, day As Integer

        Dim check As String = "" '檢查日期用

        For i = 0 To UBound(data)

            If data(i) = "" Then Exit For

            Dim ss As String = ""

            For j = 1 To Len(data(i))

                If AscW(Mid(data(i), j, 1)) >= 48 And AscW(Mid(data(i), j, 1)) <= 57 Then '檢查是不是數字
                    ss &= Mid(data(i), j, 1)
                Else

                    Select Case Mid(data(i), j, 1) '判斷取出來的數字要放哪個地方

                        Case "年"
                            If ss <> "" Then year = Val(ss) : check &= ss & "年" : ss = ""
                        Case "月"
                            If ss <> "" Then mouth = Val(ss) : check &= ss & "月" : ss = ""
                        Case "日"
                            If ss <> "" Then day = Val(ss) : check &= ss & "日" : ss = ""

                    End Select

                End If

            Next

            If year > 0 And year < 1000 And mouth > 0 And mouth < 13 And day > 0 And day < 32 And InStr(check, "年") < InStr(check, "月") And InStr(check, "月") < InStr(check, "日") Then '格式檢查

                Select Case mouth '檢查月份最大天數

                    Case 2

                        If (year + 1911) Mod 400 = 0 And day > 0 And day < 30 Then '如果是閏年的話
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
                        ElseIf day > 0 And day < 29 Then
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
                        Else
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
                        End If

                    Case 1, 3, 5, 7, 8, 10, 12

                        If day > 0 And day < 32 Then
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
                        Else
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
                        End If

                    Case 4, 6, 9, 11

                        If day > 0 And day < 31 Then
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
                        Else
                            My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
                        End If

                End Select

            Else
                My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
            End If

            check = "" '檢查日期淨空

        Next

    End Sub
End Class
