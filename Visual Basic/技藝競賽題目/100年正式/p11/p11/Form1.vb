Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(3, "out.txt", OpenMode.Output)

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText("in" & i & ".txt")
            Dim array1() As String = Split(filereader, vbCrLf)
            Call y(array1)

            If i <> 2 Then
                PrintLine(3, "")
            End If

        Next

        Me.Close()
    End Sub
    Sub y(ByVal array1() As String)

        For i = 0 To UBound(array1)

            Dim s() As String = Split(array1(i), "==")
            Dim num1 As Integer = 0 : Dim num2 As Integer = 0
            num1 = z(s(0)) : num2 = z(s(1))

            If num1 = num2 Then
                PrintLine(3, "TRUE")
            Else
                PrintLine(3, "FALSE")
            End If

        Next

    End Sub
    Function z(ByVal str As String)

        Dim stack1 = New List(Of Integer) '存數字
        Dim stack2 = New List(Of String) '存運算子

        Dim num1 As Integer = 0 : Dim num2 As Integer = 0

        For i = 1 To Len(str) '處理數字和運算元

            If Mid(str, i, 1) <> "+" And Mid(str, i, 1) <> "-" And num2 = 0 And num1 = 0 Then

                Do Until Mid(str, i, 1) = "+" Or Mid(str, i, 1) = "-" Or Mid(str, i, 1) = ""
                    num1 &= Mid(str, i, 1)
                    i += 1
                Loop

                stack1.Add(num1) : i = i - 1 : Continue For
            ElseIf Mid(str, i, 1) = "+" Or Mid(str, i, 1) = "-" Then
                stack2.Add(Mid(str, i, 1))
            ElseIf num1 <> 0 And num2 = 0 Then

                Do Until Mid(str, i, 1) = "+" Or Mid(str, i, 1) = "-" Or Mid(str, i, 1) = ""
                    num2 &= Mid(str, i, 1)
                    i += 1
                Loop

                stack1.Add(num2) : i = i - 1 : num1 = 0 : num2 = 0 : Continue For
            End If

        Next

        Dim sum As Integer = 0

        stack2.Reverse() : Dim stack2index As Integer = stack2.Count - 1 '反轉 這樣子比較好做

        If stack2.Count = 0 Then
            sum = stack1.Item(0)
        Else

            sum = stack1.Item(0)

            Do While stack2.Count <> 0

                For j = 1 To stack1.Count - 1

                    If stack2.Item(stack2index) = "-" Then
                        sum -= stack1.Item(j)
                    Else
                        sum += stack1.Item(j)
                    End If

                    stack2.RemoveAt(stack2index) : stack2index -= 1

                Next

            Loop

        End If

        Return sum

    End Function
End Class
