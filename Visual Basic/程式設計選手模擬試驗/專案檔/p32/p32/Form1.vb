Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)
        Dim data() = Split(filereader, vbCrLf)
        Dim last As String = data(0)
        Dim ans As String = "12345"
        Dim num(5) As String
        Dim switchnum(10) As String : Dim index = 2 : switchnum(1) = ans

        For i = 1 To Len(ans)
            num(i) = Mid(ans, i, 1)
        Next

        Dim a As String = ""
        For j = Len(data(0)) To 1 Step -1

            a = Mid(data(0), j, 1)

            If num(j) <> a Then


                For k = 1 To 5

                    If num(k) = a Then  '把牌換到前面
                        Dim temp As String = ""

                        temp = num(1) : num(1) = num(k) : num(k) = temp

                        Dim d As String = ""

                        For l = 1 To 5
                            d &= num(l)
                        Next

                        Dim flag1 = False '檢查重複

                        For n = 1 To UBound(switchnum)
                            If switchnum(n) = d Then
                                flag1 = True
                                Exit For
                            End If
                        Next

                        If flag1 = False Then
                            switchnum(index) = d
                            index += 1
                        End If

                        Exit For
                    End If

                Next

                Dim x As String = ""

                x = num(j) : num(j) = num(1) : num(1) = x

                Dim switch As String = ""

                For m = 1 To 5
                    switch &= num(m)
                Next

                Dim flag2 = False

                For o = 1 To UBound(switchnum)
                    If switchnum(o) = switch Then
                        flag2 = True
                        Exit For
                    End If
                Next

                If flag2 = False Then
                    switchnum(index) = switch
                    index += 1
                End If

            End If

        Next

        For k = 1 To index - 1
            My.Computer.FileSystem.WriteAllText(".\out.txt", switchnum(k) & vbCrLf, True)
        Next

    End Sub
End Class
