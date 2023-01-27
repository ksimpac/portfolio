Public Class Form1
    Dim pic(5) As PictureBox : Dim times As Integer : Dim accumulation As Single
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call inz()
    End Sub
    Sub inz()

        Dim i As Integer

        For i = 1 To 5
            pic(i) = Me.Controls("PictureBox" & i) : pic(i).BackColor = Color.Empty
            pic(i).Image = Nothing : pic(i).ImageLocation = ""
        Next

        times = 0 : accumulation = 0.0 : Me.MaximizeBox = False

    End Sub

    Private Sub card_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles card.Click

        Randomize() : Dim num As Integer = Int(Rnd() * 52) + 1 : times += 1
        pic(times).Image = Image.FromFile("撲克牌\" & num & ".jpg")

        Select Case num Mod 13
            Case 11, 12, 0
                accumulation += 0.5
            Case Else
                accumulation += num Mod 13
        End Select

        If accumulation > 10.5 Then
            MsgBox("爆掉了!!") : Call inz()
        ElseIf accumulation = 10.5 Then
            MsgBox("恭喜剛剛好十點半!!") : Call inz()
        ElseIf accumulation < 10.5 And times = 5 Then
            MsgBox("恭喜您! 五張牌都沒超過十點半") : Call inz()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call inz()
    End Sub
End Class
