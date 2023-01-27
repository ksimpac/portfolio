Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, g, h, i, sum, max, lcm As Long
        a = Show1.Text
        b = Show2.Text
        c = Show3.Text
        d = Show4.Text
        f = Show5.Text
        g = Show6.Text
        h = Show7.Text
        i = Show8.Text
        sum = a * b * c * d * f * g * h * i
        max = IIf(a > b, a, b)
        max = IIf(max > c, max, c)
        max = IIf(max > d, max, d)
        max = IIf(max > f, max, f)
        max = IIf(max > g, max, g)
        max = IIf(max > h, max, h)
        max = IIf(max > i, max, i)
        For j = 1 To sum
            lcm = max * j
            If lcm Mod a = 0 And lcm Mod b = 0 And lcm Mod c = 0 And lcm Mod d = 0 And lcm Mod f = 0 And lcm Mod g = 0 And lcm Mod h = 0 And lcm Mod i = 0 Then
                Exit For
            Else
                Continue For
            End If
        Next
        ShowLCM.Text = lcm
    End Sub
End Class

