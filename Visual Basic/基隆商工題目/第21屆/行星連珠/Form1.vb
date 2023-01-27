Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Dim data() As String = Split(filereader, vbCrLf)

        Dim max As Integer = 0 '最小公倍數
        Dim GCD As Integer = 0 '最大公因數

        For i = 0 To UBound(data)

            If Trim(data(i)) = "" Then Exit For

            Dim num() As String = Split(Trim(data(i)), ",")
            Dim x As Integer = 0

            For j = 0 To UBound(num)

                If j = 0 Then
                    GCD = GCD_Recursion(Val(num(0)), Val(num(1)))
                    max = Val(num(0)) * Val(num(1)) / GCD
                Else
                    x = max
                    GCD = GCD_Recursion(max, Val(num(j)))
                    max = x * Val(num(j)) / GCD
                End If

            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", max.ToString & vbCrLf, True)

        Next



        Me.Close()
    End Sub
    Function GCD_Recursion(ByRef a As Integer, ByRef b As Integer) '輾轉相除法(使用遞迴)

        If b = 0 Then
            Return a
        Else
            Return GCD_Recursion(b, a Mod b)
        End If

    End Function
    Function GCD_Loop(ByRef a As Integer, ByRef b As Integer) '輾轉相除法(使用迴圈)

        Do Until a = 0 Or b = 0

            If b >= a Then
                b = b - (b \ a) * a
            ElseIf a >= b Then
                a = a - (a \ b) * b
            End If

        Loop

        If a = 0 Then
            Return b
        Else
            Return a
        End If

    End Function
End Class
