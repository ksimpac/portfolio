Public Class Form1
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
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

        For i = 1 To n
            Dim s As String = LineInput(fn)
            Call x(s)
        Next
    End Sub
    Sub x(ByVal n As Long)
        Dim a As Long = 0
        Dim fibarray(18) As Long : Dim index As Long = 0
        Do While a < 19
            fibarray(index) = fib(a)
            a = a + 1
            index = index + 1
        Loop

        Dim array1(18) As Long
        Dim c As Long = 0 : Dim d As Long = 0
        If n = 1 Then
            PrintLine(3, 1 & "=" & 1)
        Else
            For i = 2 To UBound(fibarray)
                If fibarray(i) > n Then
                    array1(i - 1) = 1
                    d = fibarray(i - 1)
                    For k = i - 2 To 2 Step -1
                        c = fibarray(k)
                        If c + d <= n Then
                            array1(k) = 1
                            d += fibarray(k)
                            k += 1
                        End If
                    Next
                    Exit For
                ElseIf fibarray(i) = n Then
                    array1(i) = 1
                    Exit For
                ElseIf i = 18 Then
                    array1(i) = 1
                    d = fibarray(18)
                    For k = i - 2 To 2 Step -1
                        c = fibarray(k)
                        If c + d <= n Then
                            array1(k) = 1
                            d += fibarray(k)
                            k += 1
                        End If
                    Next
                End If
                c = 0
                d = 0
            Next
            Dim b As Long = 0
            For i = UBound(array1) To 2 Step -1
                b &= array1(i)
            Next
            PrintLine(3, n & "=" & b)
        End If
    End Sub
    Function fib(ByVal n As Long)
        If n = 0 Then
            Return 0
        ElseIf n = 1 Then
            Return 1
        Else
            Return fib(n - 2) + fib(n - 1)
        End If
    End Function
End Class
