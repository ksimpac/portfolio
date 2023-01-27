Public Class Form1

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim weight, height As Integer
        Dim bmi As Double
            weight = Val(TxtWeight.Text)
            height = Val(TxtHeight.Text)
            bmi = (weight / ((height / 100) ^ 2))
            LabShowBMI.Text = bmi
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        TxtWeight.Text = ""
        TxtHeight.Text = ""
        LabShowBMI.Text = ""
    End Sub
End Class
