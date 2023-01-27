Public Class Form1
    Dim num As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        num = InputBox("請輸入階層數", "02")
        Me.Show()

        Dim a As String = "" '算式

        For i = 1 To num

            If i <> num Then
                a = a & i & "!" & "+"
            Else
                a = a & i & "!" & "="
            End If

        Next

        Dim total As Integer = 0 '總和
        Dim times As Integer = 1

        Do Until times > num

            Dim sum As Integer = 1

            For j = 1 To times
                sum *= j
            Next

            total += sum : times += 1
        Loop

        ans.Text = a & total

    End Sub
End Class
