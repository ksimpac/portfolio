Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 1
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt", System.Text.Encoding.Default)
            Call y(filereader)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim array1() = Split(filereader, "Clean")

        For i = 0 To UBound(array1)
            Dim data() = Split(array1(i), vbCrLf)
            Dim array2(1000) As Integer : Dim index As Integer = 1

            For j = 0 To UBound(data)


                If data(j) <> "" Then


                    If data(j) = "END" Then
                        Exit Sub
                    End If

                    Dim command() = Split(data(j), " ")


                    If command(0) = "Insert" Then
                        Dim flag = False

                        For k = 1 To UBound(array2)

                            If array2(k) = command(1) Then
                                flag = True
                                Exit For
                            Else
                                flag = False
                            End If

                        Next

                        If flag = False Then
                            array2(index) = command(1)
                            index += 1
                        End If

                    ElseIf command(0) = "Inquire" Then
                        Array.Sort(array2) : Array.Reverse(array2)

                        If array2(command(1) - 1) <> 0 Then
                            My.Computer.FileSystem.WriteAllText(".\out.txt", array2(command(1) - 1) & vbCrLf, True)
                        End If

                    End If

                End If

            Next
        Next

    End Sub
End Class
