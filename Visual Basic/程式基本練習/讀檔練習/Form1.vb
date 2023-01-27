Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("D:\Projects\讀檔練習\bin\Debug\in.txt")
        MsgBox(fileReader)
        Dim array() As String = Split(fileReader, vbCrLf)
        My.Computer.FileSystem.WriteAllText("D:\Projects\讀檔練習\bin\Debug\out.txt", array(5), True)
        Me.Close()
    End Sub
End Class
