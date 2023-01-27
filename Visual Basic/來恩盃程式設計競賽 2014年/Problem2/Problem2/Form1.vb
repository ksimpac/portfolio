Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click

        Dim minute As Integer = Val(min_box.Text) : Dim call_charge() As Integer = {10, 15, 20, 30}
        Dim price As Integer = 0

        Do Until minute <= 0

            If minute <= 10 Then price += 50 : minute -= 10 : Exit Do
            price += 50 : minute -= 10 '基本的通話費

            If minute <= 0 Then Exit Do

            If minute - 90 > 0 Then
                price += 90 * 60 \ 10 : minute -= 90
            Else
                price += minute * 60 \ 10 : minute -= price * 10 / 60 : Exit Do
            End If

            If minute - 100 > 0 Then
                price += 100 * 60 \ 15 : minute -= 100
            Else
                price += minute * 60 \ 15 : minute -= price * 15 / 60 : Exit Do
            End If

            If minute - 300 > 0 Then
                price += 300 * 60 \ 15 : minute -= 300
            Else
                price += minute * 60 \ 20 : minute -= price * 20 / 60 : Exit Do
            End If

            If minute - 500 > 0 Then
                price += 500 * 60 \ 15 : minute -= 500
            Else
                price += minute * 60 \ 30 : minute -= price * 30 / 60 : Exit Do
            End If

        Loop

        ansbox.Text = price.ToString
    End Sub
End Class
