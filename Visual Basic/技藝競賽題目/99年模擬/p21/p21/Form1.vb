Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in-2-1.txt")
        Call y(filereader)

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Do Until InStr(filereader, " ") = 0
            filereader = Replace(filereader, " ", "")
        Loop

        Dim data() As String = Split(filereader, vbCrLf)
        Dim array1 As New List(Of Integer)


        For j = 0 To UBound(data)

            Dim s() As String = Split(data(j), ",")

            For k = 0 To UBound(s)
                array1.Add(Val(s(k)))
            Next

            Dim flag As Boolean = False ' 檢查全部為0時為True

            Do Until array1.IndexOf(-1) <> -1 Or flag = True 'Do迴圈模擬步驟一~步驟五

                array1.Sort() : array1.Reverse() '步驟一

                For m = 1 To Val(array1(0)) '步驟二
                    array1(m) -= 1
                Next

                array1.Remove(array1(0)) '步驟三

                For pp = 0 To array1.Count - 1 '步驟四跟五

                    If array1(pp) <> 0 Then
                        flag = False : Exit For
                    Else
                        flag = True
                    End If

                Next

            Loop

            If flag = True Then
                My.Computer.FileSystem.WriteAllText(".\out-2-1.txt", "正確" & vbCrLf, True)
            Else
                My.Computer.FileSystem.WriteAllText(".\out-2-1.txt", "不正確" & vbCrLf, True)
            End If

            array1.Clear()

        Next






    End Sub
End Class
