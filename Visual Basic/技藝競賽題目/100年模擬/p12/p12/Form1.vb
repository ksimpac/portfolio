Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 1
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in1-2.txt", System.Text.Encoding.Default)
            Call y(filereader)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim array1() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(array1)

            Do Until InStr(array1(i), " ") = 0
                array1(i) = Replace(array1(i), " ", "")
            Loop

            '先假設a為"FALSE"

            array1(i) = Replace(array1(i), "=a=", "=false=")
            array1(i) = Replace(array1(i), "=a!", "=false!")
            array1(i) = Replace(array1(i), "=a", "=false")

            If array1(i) = "" Then Exit For
            '分割true,False,==,!=
            Dim truefalse As New List(Of String) : Dim judge As New List(Of String) : Dim s As String = "" : Dim s1 As String = ""

            For j = 1 To Len(array1(i))

                If Mid(array1(i), j, 1) <> "!" And Mid(array1(i), j, 1) <> "=" Then

                    For k = j To j + 4

                        If Mid(array1(i), k, 1) <> "!" And Mid(array1(i), k, 1) <> "=" Then
                            s &= Mid(array1(i), k, 1)
                            j = k
                        End If


                    Next

                    truefalse.Add(s)
                    s = ""
                Else

                    For n = j To j + 1
                        s1 &= Mid(array1(i), n, 1)
                        j = n
                    Next

                    judge.Add(s1)
                    s1 = ""
                End If

            Next

            '從一開始到最後的結果是TRUE還FALSE

            Dim flag As String = "TRUE"

            For k = 0 To judge.Count - 1

                If judge.Item(k) = "==" And k = 0 Then

                    If truefalse.Item(k) = truefalse.Item(k + 1) Then
                        flag = "TRUE"
                    Else
                        flag = "FALSE"
                    End If

                ElseIf k <> 0 And judge.Item(k) = "==" Then

                    If flag = UCase(truefalse.Item(k + 1)) Then
                        flag = "TRUE"
                    Else
                        flag = "FALSE"
                    End If

                ElseIf k = 0 And judge.Item(k) = "!=" Then

                    If truefalse.Item(k) = truefalse.Item(k + 1) Then
                        flag = "FALSE"
                    Else
                        flag = "TRUE"
                    End If

                ElseIf k <> 0 And judge.Item(k) = "!=" Then

                    If flag = UCase(truefalse.Item(k + 1)) Then
                        flag = "FALSE"
                    Else
                        flag = "TRUE"
                    End If

                End If

            Next

            If flag = "FALSE" Then
                My.Computer.FileSystem.WriteAllText(".\out1-2.txt", "TRUE" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out1-2.txt", "FALSE" & vbCrLf, True)
            End If

        Next
    End Sub
End Class
