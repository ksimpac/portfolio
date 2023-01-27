Public Class Form1
    Dim final_temp As String : Dim temp As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim time As Integer = Val(burn_second.Text)
        temp = Val(original_tem.Text) : Dim ans As Decimal = count(time, temp)
        ans = Math.Round(ans, 5)
        Dim final_temp = ans.ToString
        Dim a As String = Microsoft.VisualBasic.Right(final_temp, InStr(final_temp, ".") - 1)

        If Len(a) <> 6 Then

            Do Until Len(a) = 6
                a &= "0"
            Loop

        End If

        ansbox.Text = (Int(ans)).ToString & a
    End Sub
    Function count(ByVal time As Integer, ByVal temp As Decimal)

        If time = 0 Then
            Return temp
        Else
            Return count(time - 1, temp + time * 3.14159)
        End If

    End Function
End Class
