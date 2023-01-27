Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in.txt")
        Call y(Trim(filereader))

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, " ") = 0
            filereader = Replace(filereader, " ", "")
        Loop

        Dim s() As String = Split(filereader, vbCrLf)

        For i = 0 To UBound(s)

            If s(i) = "" Then Exit For
            If s(i) = "0" Then My.Computer.FileSystem.WriteAllText(".\out.txt", "0" & vbCrLf, True) : Continue For

            Dim ss() As String = Split(s(i), ",") : Dim num As String = ""

            If UBound(ss) = 0 Then My.Computer.FileSystem.WriteAllText(".\out.txt", ss(0), True) : Continue For

            For j = 0 To UBound(ss)

                If num = "" Then
                    num = z(ss(j), ss(j + 1)) : j = j + 1
                Else
                    num = z(num, ss(j))
                End If

            Next

            My.Computer.FileSystem.WriteAllText(".\out.txt", num & vbCrLf, True)

        Next

    End Sub
    Function z(ByVal num1 As String, ByVal num2 As String) '大數相乘

        Dim flag As Boolean = False '相乘為負數

        If Mid(num1, 1, 1) = "-" And Mid(num2, 1, 1) <> "-" Or Mid(num1, 1, 1) <> "-" And Mid(num2, 1, 1) = "-" Then
            flag = True
        Else
            flag = False
        End If

        num1 = Replace(num1, "-", "") : num2 = Replace(num2, "-", "")

        Dim s(Len(num1) + Len(num2)) As String : Dim temp As Integer = 0 '進位
        Dim index As Integer = 0 : Dim ss As Integer = 0

        For i = Len(num1) To 1 Step -1 '模擬算乘法

            Dim a As Integer = Val(Mid(num1, i, 1))

            For j = Len(num2) To 1 Step -1

                Dim b As Integer = Val(Mid(num2, j, 1))

                s(ss) = a * b + s(ss)

                If s(ss) >= 10 Then '要進位
                    temp = s(ss) \ 10
                    s(ss) = s(ss) Mod 10
                    s(ss + 1) += temp
                Else
                    s(ss) = s(ss) Mod 10
                End If

                ss += 1

            Next

            index += 1
            ss = index

        Next

        Array.Reverse(s)

        Dim num As String = ""

        For j = 0 To UBound(s)

            If num = "" And s(j) = "" Then
                Continue For
            Else
                num &= s(j)
            End If

        Next

        If flag = True Then
            Return "-" & num
        Else
            Return num
        End If



    End Function
End Class
