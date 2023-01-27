Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FileOpen(3, "out.txt", OpenMode.Output)
        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText("in" & i & ".txt")
            Dim array1() As String = Split(filereader, vbCrLf)
            Call y(array1)

            If i <> 2 Then PrintLine(3, "")
        Next

        Me.Close()
    End Sub
    Sub y(ByVal array1() As String)

        For i = 0 To UBound(array1)
            Dim s() As String = Split(array1(i), "==")
            Dim num1, num2 As Integer
            num1 = z(s(0)) : num2 = z(s(1))

            If num1 = num2 Then
                PrintLine(3, "TRUE")
            Else
                PrintLine(3, "FALSE")
            End If
        Next

    End Sub
    Function z(ByVal str As String)

        Dim stack1 = New List(Of Integer) '存運算元
        Dim stack2 = New List(Of String)  '存運算子

        Dim num1, num2 As Integer

        For i = 1 To Len(str) '分割運算元和運算子

            If Mid(str, i, 1) <> "*" And Mid(str, i, 1) <> "-" And Mid(str, i, 1) <> "+" And num2 = 0 And num1 = 0 Then

                Do Until Mid(str, i, 1) = "*" Or Mid(str, i, 1) = "-" Or Mid(str, i, 1) = "+" Or Mid(str, i, 1) = ""
                    num1 &= Mid(str, i, 1)
                    i += 1
                Loop

                stack1.Add(num1) : i -= 1
            ElseIf Mid(str, i, 1) = "*" Or Mid(str, i, 1) = "-" Or Mid(str, i, 1) = "+" Then
                stack2.Add(Mid(str, i, 1))
            ElseIf Mid(str, i, 1) <> "*" And Mid(str, i, 1) <> "-" And Mid(str, i, 1) <> "+" And num2 = 0 And num1 <> 0 Then

                Do Until Mid(str, i, 1) = "*" Or Mid(str, i, 1) = "-" Or Mid(str, i, 1) = "+" Or Mid(str, i, 1) = ""
                    num2 &= Mid(str, i, 1)
                    i += 1
                Loop

                stack1.Add(num2) : i -= 1 : num1 = 0 : num2 = 0

            End If

        Next

        Dim sum As Integer = 0

        If stack2.Count = 0 Then
            sum = stack1.Item(0)
            Return sum
        End If

        Do Until stack2.Contains("*") = False '直到沒有乘號為止

            Dim index As Integer = stack2.IndexOf("*") '取得乘號的索引值

            If stack2.Item(index) = "*" Then
                sum = stack1.Item(index) * stack1.Item(index + 1)
                stack1.RemoveAt(index + 1) : stack1.RemoveAt(index) : stack2.RemoveAt(index) : stack1.Insert(index, sum)
            End If

        Loop

        Dim stack2index As Integer = stack2.Count - 1 : sum = stack1.Item(0)

        Do Until stack2.Count = 0 '處理加和減

            If stack2.Item(stack2index) = "-" Then
                sum -= stack1.Item(stack2index + 1)
                stack2.RemoveAt(stack2index)
            Else
                sum += stack1.Item(stack2index + 1)
                stack2.RemoveAt(stack2index)
            End If

            stack2index -= 1

        Loop

        Return sum

    End Function
End Class
