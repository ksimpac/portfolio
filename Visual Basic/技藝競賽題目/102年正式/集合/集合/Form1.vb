Public Class Form1

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
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim a_class() As String = Split(LineInput(fn), "}, {") '集合

            For j = 0 To UBound(a_class)
                a_class(j) = Replace(a_class(j), "{", "")
                a_class(j) = Replace(a_class(j), "}", "")
            Next

            Dim ans As String = ""
            Const sign As String = ", "
            Dim a As String = union(a_class) '聯集
            Dim b As String = Intersection(a_class) '交集
            Dim c As String = Set_difference(a_class) '差集 
            Dim d As String = Symmetric_difference(a, b) '對稱差

            ans = ans & a & sign & b & sign & c & sign & d

            PrintLine(3, ans)

            a = ""
            b = ""
            c = ""
            d = ""
        Next

    End Sub
    Function union(ByVal a_class() As String) '聯集

        Dim a() As String
        Dim num(999999) As String : Dim index As Integer = 0
        Dim ans As String = ""

        For i = 0 To UBound(a_class)

            a = Split(a_class(i), ", ") '

            For j = 0 To UBound(a)

                Dim flag = False '檢查重複

                For k = 0 To index - 1

                    If a(j) = num(k) Then
                        flag = True
                        Exit For
                    End If

                Next

                If flag = False Then
                    num(index) = a(j)
                    index += 1
                End If

            Next
        Next

        Array.Sort(num) : Array.Reverse(num)

        For l = index - 1 To 0 Step -1

            If l <> 0 Then
                ans &= num(l) & ", "
            Else
                ans &= num(l)
            End If

        Next

        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function

    Function Intersection(ByVal a_class() As String) '交集

        Dim ans As String = ""

        Dim num1() As String : Dim num2() As String
        Dim num(99999) As String : Dim index As Integer = 0


        For i = 0 To UBound(a_class) '把兩個集合的元素分別放到各自指定的陣列裡

            If i <> UBound(a_class) Then
                num1 = Split(a_class(i), ", ")
            Else
                num2 = Split(a_class(i), ", ")
            End If

        Next

        For j = 0 To UBound(num1) '兩個迴圈找重複數字

            For k = 0 To UBound(num2)

                If num1(j) = num2(k) Then
                    num(index) = num1(j)
                    index += 1
                End If

            Next

        Next

        Array.Sort(num) : Array.Reverse(num)

        For l = index - 1 To 0 Step -1

            If num(0) = 0 Then '如果一開始都沒交集直接跳出
                Exit For
            End If

            If l <> 0 Then
                ans &= num(l) & ", "
            Else
                ans &= num(l)
            End If

        Next


        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function

    Function Set_difference(ByVal a_class() As String) '差集 

        Dim num1() As String : Dim num2() As String
        Dim ans As String = ""

        For i = 0 To UBound(a_class)

            If i <> UBound(a_class) Then
                num1 = Split(a_class(i), ", ")
            Else
                num2 = Split(a_class(i), ", ")
            End If

        Next

        For j = 0 To UBound(num1)

            For k = 0 To UBound(num2)

                If num1(j) = num2(k) Then
                    num1(j) = ""
                End If

            Next

        Next

        Array.Sort(num1) : Array.Reverse(num1)

        Dim l As Integer
        Dim num(99999) As String : Dim index As Integer = 0

        For l = UBound(num1) To 0 Step -1

            If num1(l) <> "" Then
                num(index) = num1(l)
                index += 1
            End If

        Next

        For m = 0 To index - 1

            If m <> index - 1 Then
                ans &= num(m) & ", "
            Else
                ans &= num(m)
            End If

        Next


        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function

    Function Symmetric_difference(ByVal a As String, ByVal b As String) '對稱差 聯集減交集

        If b = "N" Then
            Return a
        End If

        Dim num1(99999) As String : Dim index As Integer = 0

        For i = 1 To Len(a)

            If IsNumeric(Mid(a, i, 1)) = True Then
                num1(index) = Mid(a, i, 1)
                index += 1
            End If

        Next

        Dim num2(99999) As String : Dim index1 As Integer = 0

        For j = 1 To Len(b)

            If IsNumeric(Mid(b, j, 1)) = True Then
                num2(index1) = Mid(b, j, 1)
                index1 += 1
            End If

        Next


        '檢查重複
        For k = 0 To index - 1

            For l = 0 To index1 - 1

                If num1(k) = num2(l) Then
                    num1(k) = ""
                End If

            Next

        Next

        Dim num(99999) As String : Dim index2 As Integer = 0

        For m = 0 To index - 1

            If num1(m) <> "" Then
                num(index2) = num1(m)
                index2 += 1
            End If

        Next

        Dim ans As String = ""

        For n = 0 To index2 - 1

            If n <> index2 - 1 Then
                ans &= num(n) & ", "
            Else
                ans &= num(n)
            End If

        Next

        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function
End Class
