Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf)
        Dim check(3) As Integer : Dim checkstr As String = ""

        For i = 1 To Len(data(0))
            If Mid(data(0), i, 1) = "#" Then
                checkstr &= "1"
            ElseIf Mid(data(0), i, 1) = "*" Then
                checkstr &= "2"
            Else
                checkstr &= "3"
            End If
        Next

        For j = 1 To UBound(data)

            If data(j) = "" Then
                Exit For
            End If

            Dim array1() As String
            array1 = Split(data(j), " ")
            Dim flag As Boolean = False

            For k = 0 To UBound(array1)

                If Len(array1(k)) >= Len(checkstr) Then

                    Dim a As String = ""

                    For l = 1 To Len(array1(k)) - Len(checkstr)
                        a = Mid(array1(k), l, Len(checkstr))

                        Dim datacheckstr As String = "" : Dim b As String = ""

                        For n = 1 To Len(a)
                            b = Mid(a, n, 1)

                            Select Case AscW(b)
                                Case 48 To 57
                                    datacheckstr &= 1
                                Case 64 To 90
                                    datacheckstr &= 2
                                Case Else
                                    datacheckstr &= 3
                            End Select

                        Next



                        If datacheckstr = checkstr Then
                            flag = True
                            Exit For
                        Else
                            flag = False
                        End If
                    Next

                End If

                If flag = True Then
                    Exit For
                End If

            Next

            If flag = True Then
                My.Computer.FileSystem.WriteAllText(".\out.txt", "符合" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out.txt", "不符合" & vbCrLf, True)
            End If

        Next
    End Sub
End Class
