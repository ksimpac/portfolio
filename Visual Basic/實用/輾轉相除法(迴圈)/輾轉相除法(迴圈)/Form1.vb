Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim num1, num2 As Integer
        num1 = 24 : num2 = 108

        Do Until num1 = 0 Or num2 = 0

            If num1 >= num2 Then
                num1 = num1 Mod num2
            Else
                num2 = num2 Mod num1
            End If

        Loop



    End Sub
End Class
