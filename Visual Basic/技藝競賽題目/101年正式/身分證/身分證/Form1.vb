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
        Dim array1(10) As String : Dim index As Integer = 1
        Dim n As Integer = LineInput(fn)
        Dim valid, invalid, repeat As Integer '有效.無效跟重複

        For i = 1 To n

            Dim str As String = LineInput(fn)
            Dim num As String = ""
            Dim checkflag = True

            If Mid(str, 2, 1) = "1" Or Mid(str, 2, 1) = "2" Then
                num = z(Microsoft.VisualBasic.Left(str, 1))
            Else
                invalid += 1
                Continue For
            End If

            checkflag = check(str, num)

            If checkflag = True Then

                Dim flag = False

                For j = 1 To index

                    If str = array1(j) Then

                        repeat += 1
                        flag = True
                        Exit For

                    End If

                Next


                If flag = False Then

                    valid += 1
                    array1(index) = str
                    index += 1

                End If
                
            Else
                invalid += 1
            End If

        Next

        PrintLine(3, valid.ToString & "," & repeat.ToString & "," & invalid.ToString)

    End Sub
    Function z(ByVal str As String)

        If AscW(str) >= AscW("A") And AscW(str) <= AscW("H") Then
            Return AscW(str) - 55
        ElseIf AscW(str) > AscW("I") And AscW(str) <= AscW("N") Then
            Return AscW(str) - 56
        ElseIf AscW(str) > AscW("O") And AscW(str) <= AscW("V") Then
            Return AscW(str) - 57
        Else
            Select Case str
                Case "I"
                    Return 34
                Case "O"
                    Return 35
                Case "W"
                    Return 32
                Case "X"
                    Return 30
                Case "Y"
                    Return 31
                Case Else
                    Return 33
            End Select

        End If

    End Function

    Function check(ByVal str As String, ByVal num As String) As Boolean
        Dim sum As Integer = 0
        Dim strnum As Integer = 2

        sum += Mid(num, 1, 1) * 1 + Mid(num, 2, 1) * 9

        For i = 8 To 1 Step -1
            sum += Mid(str, strnum, 1) * i
            strnum += 1
        Next

        sum += Mid(str, Len(str), 1) * 1

        If sum Mod 10 = 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
