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

            Dim s As String = LineInput(fn)
            Dim s1 As String = ""
            Dim strlengh As Integer = Len(s)
            Dim num1 As Integer = 1

            Do Until num1 >= strlengh '暴力法 一個一個去try 

                Dim num2 As Integer
                Dim checkstr As String = Mid(s, num1, num2)
                Dim flag As Boolean = check(checkstr)

                If flag = True Then
                    num1 += num2
                    num2 = 1
                    s1 = s1 & checkstr & " "
                Else
                    num2 += 1
                End If
            Loop

            Dim a() As String = Split(Trim(s1), " ")
            Dim str As String = ""

            For j = 0 To UBound(a)
                str &= check1(a(j))
            Next

            Dim numstr As String = Microsoft.VisualBasic.Left(str, 4)
            str = Replace(str, numstr, "")

            PrintLine(3, numstr & "," & str)
        Next

    End Sub
    Function check(ByVal data As String)

        Select Case data

            Case "00", "01", "100", "101", "1100", "1101", "11100", "11101", "111100", "111101", "111110", "111111"
                Return True
            Case Else
                Return False

        End Select

    End Function
    Function check1(ByVal data As String)

        Select Case data
            Case "00"
                Return "A"
            Case "01"
                Return "B"
            Case "100"
                Return "0"
            Case "101"
                Return "1"
            Case "1100"
                Return "2"
            Case "1101"
                Return "3"
            Case "11100"
                Return "4"
            Case "11101"
                Return "5"
            Case "111100"
                Return "6"
            Case "111101"
                Return "7"
            Case "111110"
                Return "8"
            Case Else
                Return "9"
        End Select


    End Function
End Class
