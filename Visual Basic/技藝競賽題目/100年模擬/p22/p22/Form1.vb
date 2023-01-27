Public Class Form1
    Dim path(16, 16) As Integer : Dim flag As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        Dim filereader As String = My.Computer.FileSystem.ReadAllText("in2-2.txt")
        FileOpen(3, "out2-2.txt", OpenMode.Output)
        Dim array1() = Split(filereader, vbCrLf)
        Call y(array1)

        Me.Close()
    End Sub
    Sub y(ByVal array1() As String)

        For i = 0 To 15

            Dim chrnum As Integer = 1

            Do Until chrnum = 15
                path(i + 1, chrnum) = Val(Mid(array1(i), chrnum, 1))
                chrnum += 1
            Loop

        Next


        For k = 0 To 16
            path(0, k) = 1 : path(k, 0) = 1 : path(16, k) = 1 : path(k, 16) = 1
        Next

        For j = 16 To 20
            Dim coordinates() As String
            Dim start_i, start_j, end_j, end_i As Integer

            If j = 16 Then
                coordinates = Split(array1(j), " ") : start_i = coordinates(0) : start_j = coordinates(1)
            ElseIf j = 17 Then
                coordinates = Split(array1(j), " ") : end_i = coordinates(0) : end_j = coordinates(1) : flag = False
                Call visit(start_i, start_j, end_i, end_j) : PrintLine(3, UCase(Str(flag)))
            ElseIf j = 19 Then
                coordinates = Split(array1(j), " ") : start_i = coordinates(0) : start_j = coordinates(1)
            ElseIf j = 20 Then
                coordinates = Split(array1(j), " ") : end_i = coordinates(0) : end_j = coordinates(1) : flag = False
                Call visit(start_i, start_j, end_i, end_j) : PrintLine(3, UCase(Str(flag)))
            Else
                Continue For
            End If

        Next

    End Sub
    Sub visit(ByRef start_i As Integer, ByRef start_j As Integer, ByVal end_i As Integer, ByVal end_j As Integer)

        If start_i = end_i And start_j = end_j Then
            flag = True
        Else

            If flag = False And path(start_i + 1, start_j) = 0 Then '向下走
                path(start_i + 1, start_j) = 1 : Call visit(start_i + 1, start_j, end_i, end_j)
            End If

            If flag = False And path(start_i, start_j + 1) = 0 Then '向右走
                path(start_i, start_j + 1) = 1 : Call visit(start_i, start_j + 1, end_i, end_j)
            End If

            If flag = False And path(start_i - 1, start_j) = 0 Then '向上走
                path(start_i - 1, start_j) = 1 : Call visit(start_i - 1, start_j, end_i, end_j)
            End If

            If flag = False And path(start_i, start_j - 1) = 0 Then
                path(start_i, start_j - 1) = 1 : Call visit(start_i, start_j - 1, end_i, end_j)

            End If

        End If

    End Sub
End Class
