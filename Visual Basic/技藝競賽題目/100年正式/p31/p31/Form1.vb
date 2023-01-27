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

        Dim n As Integer = LineInput(fn) : Dim area = New List(Of String)

        For i = 1 To n

            For j = AscW("A") To AscW("Z") '處理英文字母轉數字List

                If j >= AscW("A") And j <= AscW("H") Then
                    area.Add((j - 55).ToString())
                ElseIf j >= AscW("J") And j <= AscW("N") Then
                    area.Add((j - 56).ToString())
                ElseIf j >= AscW("P") And j <= AscW("V") Then
                    area.Add((j - 57).ToString())
                Else

                    Select Case ChrW(j)
                        Case "I" : area.Add("34")
                        Case "O" : area.Add("35")
                        Case "W" : area.Add("32")
                        Case "X" : area.Add("30")
                        Case "Y" : area.Add("31")
                        Case "Z" : area.Add("33")
                    End Select

                End If


            Next

            Dim sum As Integer = 0 : Dim s As String = LineInput(fn) : Dim ans As String = ""

            For k = 0 To area.Count - 1
                sum = Val(Mid(area.Item(k), 1, 1)) * 1 + Val(Mid(area.Item(k), 2, 1)) * 9

                Dim weighted As Integer = 8

                For m = 1 To Len(s)

                    If weighted <> 1 Then
                        sum += Val(Mid(s, m, 1)) * weighted
                        weighted -= 1
                    Else
                        sum += Val(Mid(s, m, 1)) * weighted
                    End If

                Next

                If sum Mod 10 = 0 Then
                    ans &= ChrW((area.IndexOf(area.Item(k))) + 65)
                End If

            Next

            PrintLine(3, ans) : area.Clear()

        Next

    End Sub
End Class
