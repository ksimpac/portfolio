Public Class Form1
    Dim prime As New List(Of Integer) : Dim GCD_num As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)
        PrintLine(3, "")
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim flag As Boolean = True

        For j = 2 To 65535

            For k = 2 To j \ 2
                If j Mod k = 0 Then flag = False : Exit For
            Next

            If flag = True Then prime.Add(j)

            flag = True

        Next

        Dim n As Integer = LineInput(fn)

        For i = 1 To n

            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, " ") = 0
                s = Replace(s, " ", "")
            Loop

            Dim data() As String = Split(s, ",")

            GCD_num = GCD(Val(data(0)), Val(data(1)))

            Dim num As New List(Of Integer) : Dim freq As New List(Of Integer)

            Dim q As Integer = Val(data(0))

            For k = 0 To prime.Count - 1

                Do Until q Mod prime(k) <> 0

                    If q Mod prime(k) = 0 And num.IndexOf(prime(k)) = -1 Then
                        num.Add(prime(k)) : freq.Add(1) : q = q / prime(k)
                    ElseIf q Mod prime(k) = 0 And num.IndexOf(prime(k)) <> -1 Then
                        freq(num.IndexOf(prime(k))) += 1 : q = q / prime(k)
                    ElseIf prime.IndexOf(q) <> -1 Then
                        num.Add(q) : Exit For
                    ElseIf q = 1 Then
                        Exit For
                    End If

                Loop

            Next

            Dim ans As String = ""

            For m = 0 To num.Count - 1

                If m <> num.Count - 1 And freq(m) <> 1 Then
                    ans &= num(m) & "^" & freq(m) & "*"
                ElseIf m <> num.Count - 1 And freq(m) = 1 Then
                    ans &= num(m) & "*"
                ElseIf m = num.Count - 1 And freq(m) = 1 Then
                    ans &= num(m)
                Else
                    ans &= num(m) & "^" & freq(m)
                End If

            Next

            ans &= ", " & GCD_num.ToString

            PrintLine(3, ans)

        Next

    End Sub
    Function GCD(ByVal num1 As Integer, ByVal num2 As Integer)

        Do Until num1 = 0 Or num2 = 0

            If num1 > num2 Then
                num1 = num1 Mod num2 * (num1 \ num2)
            Else
                num2 = num2 Mod (num1 * (num2 \ num1))
            End If

        Loop

        If num1 = 0 Then
            Return num2
        Else
            Return num1
        End If

    End Function
End Class
