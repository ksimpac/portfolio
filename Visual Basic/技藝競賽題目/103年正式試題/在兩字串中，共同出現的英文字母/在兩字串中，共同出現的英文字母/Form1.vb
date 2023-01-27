Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call z(1)
        PrintLine(3, "")
        Call z(2)
        Me.Close()
    End Sub
    Sub z(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)


        Dim com1, com2 As String '拿來字串比較
        For i = 1 To n
            Dim str1 As String = LineInput(fn)
            Dim str2 As String = LineInput(fn)
            Dim array1(20) As String : Dim index As Integer = 0
            Dim flag = False '檢查重複
            For j = 1 To Len(str1)
                com1 = Mid(str1, j, 1)
                For k = 1 To Len(str2)
                    com2 = Mid(str2, k, 1)
                    If com1 = com2 Then
                        array1(index) = com1
                        index += 1
                    End If
                Next
            Next

            For l = 0 To UBound(array1) - 1 '檢查重複
                For m = l + 1 To UBound(array1)
                    If array1(l) = array1(m) And array1(l) <> "" And array1(m) <> "" Then
                        array1(m) = ""
                    End If
                Next
            Next

            Array.Sort(array1) '列印資料
            Dim a As String = ""
            For k = 0 To UBound(array1)
                If array1(k) <> "" Then
                    a &= array1(k)
                End If
            Next
            If a = "" Then
                PrintLine(3, "N")
            Else
                PrintLine(3, a)
            End If
        Next
    End Sub
End Class
