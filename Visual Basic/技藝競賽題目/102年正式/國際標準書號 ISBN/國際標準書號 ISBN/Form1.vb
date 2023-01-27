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
            Dim isbn As String = LineInput(fn)
            Dim ans As String = ""

            isbn = Replace(isbn, "-", "")

            If Len(isbn) = 10 Then
                ans = isbn10(isbn)
            ElseIf Len(isbn) = 13 Then
                ans = isbn13(isbn)
            Else
                ans = "F"
            End If

            PrintLine(3, ans)
        Next

    End Sub
    Function isbn10(ByVal isbn As String)
        Dim sum, remainder, difference As Integer '總和,餘數,差
        Dim num As Integer = 10

        For i = 1 To 9
            sum += Val(Mid(isbn, i, 1)) * num
            num -= 1
        Next


        remainder = sum Mod 11
        difference = 11 - remainder

        Dim checknum As String = Mid(isbn, 10, 1)

        If checknum = "X" And difference = 10 Then
            Return "T"
        ElseIf checknum = "0" And difference = 11 Then
            Return "T"
        ElseIf Val(checknum) = Val(difference) Then
            Return "T"
        Else
            Return "F"
        End If

    End Function

    Function isbn13(ByVal isbn As String)
        Dim sum, remainder, difference As Integer '總和,餘數,差

        For i = 1 To 12 Step 2
            sum += Val(Mid(isbn, i, 1)) * 1
        Next

        For j = 2 To 12 Step 2
            sum += Val(Mid(isbn, j, 1)) * 3
        Next

        remainder = sum Mod 10
        difference = 10 - remainder

        Dim checknum As String = Mid(isbn, 13, 1)

        If checknum = "0" And difference = 10 Then
            Return "T"
        ElseIf Val(checknum) = difference Then
            Return "T"
        Else
            Return "F"
        End If
    End Function
End Class
