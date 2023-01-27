Public Class Form1
    Dim max As Long = 2147483647
    Dim times As Long = 1
    Dim prime As New List(Of Long)
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim t1 As DateTime = DateTime.Now

        Dim U As Integer = Int(Math.Sqrt(max)) + 1
        Dim isPrime As Boolean = True : My.Computer.FileSystem.WriteAllText(".\out.txt", "2" & vbCrLf, True)
        For i = 3 To U Step 2
            For j = 2 To i \ 2
                If i Mod j = 0 Then isPrime = False : Exit For
            Next
            If isPrime = True Then
                prime.Add(i)
                My.Computer.FileSystem.WriteAllText(".\out.txt", i.ToString & vbCrLf, True)
                times += 1
            End If
            isPrime = True
        Next
        Dim t2 As DateTime = DateTime.Now : My.Computer.FileSystem.WriteAllText(".\out.txt", "總共花費:" & t2.Subtract(t1).TotalSeconds & "秒" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(".\out.txt", "總共有" & times & "個質數", True)
        Me.Close()
    End Sub
End Class
