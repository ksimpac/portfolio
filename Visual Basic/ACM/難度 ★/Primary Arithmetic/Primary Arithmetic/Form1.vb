Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt", System.Text.Encoding.Default)
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() As String = Split(filereader, vbCrLf)

        For I = 0 To UBound(data)

            If data(I) = "0 0" Then Exit For
            Dim S() As String = Split(data(I), " ")

            If Len(S(0)) > Len(S(1)) Then

                Do Until Len(S(0)) = Len(S(1))
                    S(1) = "0" & S(1)
                Loop

            ElseIf Len(S(0)) < Len(S(1)) Then

                Do Until Len(S(0)) = Len(S(1))
                    S(0) = "0" & Len(S(0))
                Loop

            End If

            Dim times As Integer = z(S(0), S(1)), Ans As String = ""

            Select Case times
                Case 0 : Ans = "No carry operation."
                Case 1 : Ans = times.ToString & " carry operation."
                Case Else : Ans = times.ToString & " carry operations."
            End Select

            My.Computer.FileSystem.WriteAllText(".\out.txt", Ans & vbCrLf, True)

        Next

    End Sub
    Function z(ByVal num1 As String, ByVal num2 As String)

        Dim S(Len(num1) + 1) As Integer : Dim temp As Integer = 0 : Dim times As Integer = 0

        For I = Len(num1) To 1 Step -1

            S(I) = Val(Mid(num1, I, 1)) + Val(Mid(num2, I, 1)) + temp

            If S(I) >= 10 Then
                S(I) -= 10 : temp += 1 : times += 1
            Else
                temp = 0
            End If

        Next

        Return times

    End Function
End Class
