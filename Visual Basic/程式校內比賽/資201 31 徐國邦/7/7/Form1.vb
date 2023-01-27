Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim a As String = InputBox("請輸入一個數", "05") : Dim b As String = StrReverse(a)

        If a = b Then
            MsgBox(a & " is a palindrome.")
        Else
            MsgBox(a & " is not a palindrome.")
        End If

        Me.Close()
    End Sub
End Class
