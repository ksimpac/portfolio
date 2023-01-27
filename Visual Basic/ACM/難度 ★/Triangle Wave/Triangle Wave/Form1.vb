Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)

        Dim N As Integer = LineInput(fn) : Dim temp As String = LineInput(fn) '讀取空白行用

        For I = 1 To N

            Dim A As Integer = Val(LineInput(fn)), F As Integer = Val(LineInput(fn)), Ans As String = ""
            Dim S As New List(Of String)

            For J = 1 To A

                Dim B As String = ""

                For K = 1 To A
                    B &= J
                Next

                S.Add(B)

            Next

            For K = A - 1 To 1 Step -1

                Dim B As String = ""

                For Q = 1 To A
                    B &= K
                Next

                S.Add(B)

            Next


            For M = 0 To S.Count - 1

                If M <> S.Count - 1 Then
                    Ans &= Mid(S(M), 1, Val(Mid(S(M), 1, 1))) & vbCrLf
                Else
                    Ans &= Mid(S(M), 1, Val(Mid(S(M), 1, 1)))
                End If

            Next

            For L = 1 To F
                PrintLine(3, Ans) : PrintLine(3, "")
            Next

            If I <> N Then temp = LineInput(fn)

        Next

    End Sub
End Class
