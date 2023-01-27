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
            Dim s As String = LineInput(fn) : Dim data() = Split(s, " ")
            Dim a, b As Integer : a = data(0) : b = data(1) 'a是被除數 b是除數

            If a = 0 And b = 0 Then
                Exit For
            End If

            Dim c, d As Integer 'c取商值 d取餘數
            Dim q(200000), r(200000) As Integer : Dim index As Integer = 0
            Dim flag As Boolean = False '判斷是否整除
            Dim j As Integer '記找到重複數字的座標
            Do
                c = a \ b
                d = a Mod b
                q(index) = c : r(index) = d

                If d <> 0 Then
                    a = d * 10
                Else
                    flag = True
                    Exit Do
                End If

                For j = index - 1 To 0 Step -1
                    If r(index) = r(j) Then
                        Exit Do
                    End If
                Next

                If index = 200000 Then
                    flag = True
                    Exit Do
                Else
                    index += 1
                End If
            Loop

            Dim num As String = ""

            If flag = True Then
                PrintLine(3, "not repeater")
            Else
                For k = j + 1 To index
                    num &= q(k)
                Next
                PrintLine(3, num)
            End If
        Next
    End Sub
End Class

