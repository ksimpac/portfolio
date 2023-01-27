Public Class Form1
    Dim maze(16, 16) As String : Dim flag As Boolean : Dim not_visit_road As New List(Of String) : Dim goal As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        For i = 1 To 2
            Dim filereader As String = My.Computer.FileSystem.ReadAllText(".\in" & i & ".txt")
            Call y(filereader)
            If i = 1 Then My.Computer.FileSystem.WriteAllText(".\out.txt", vbCrLf, True)
        Next

        Me.Close()
    End Sub
    Sub y(ByVal filereader As String)

        Dim array1() As String = Split(filereader, vbCrLf)

        For i = 1 To UBound(array1)

            If i = 16 Then

                Call u(array1)

            ElseIf i <= 31 Then

                Call z(i, i, array1)

                If i = 31 Then Call u(array1)

            End If

        Next

    End Sub

    Sub z(ByVal i As Integer, ByVal colnum As Integer, ByRef data() As String)

        If colnum > 16 Then colnum = colnum - 16

        Dim num As Integer = 1 '字數

        Do Until num > 15
            maze(colnum, num) = Mid(data(i), num, 1)
            num += 1
        Loop

    End Sub
    Sub walkmaze(ByRef i As Integer, ByRef j As Integer, ByRef times As Integer)


        If i = 15 And j = 15 And times <= goal Then
            flag = True
        Else


            If maze(i, j + 1) = 0 And check(i, j + 1) = False Then
                not_visit_road.Add(i & " " & j + 1 & " " & times + 1)
            End If

            If maze(i + 1, j) = 0 And check(i + 1, j) = False Then
                not_visit_road.Add(i + 1 & " " & j & " " & times + 1)
            End If

            If maze(i, j - 1) = 0 And check(i, j - 1) = False Then
                not_visit_road.Add(i & " " & j - 1 & " " & times + 1)
            End If

            If maze(i - 1, j) = 0 And check(i - 1, j) = False Then
                not_visit_road.Add(i - 1 & " " & j & " " & times + 1)
            End If

            If not_visit_road.Count = 0 Then Exit Sub

            maze(i, j) = 1 : Dim n() As String = Split(not_visit_road(0), " ") : not_visit_road.Remove(not_visit_road(0))
            Call walkmaze(n(0), n(1), n(2))


        End If

    End Sub
    Function check(ByVal i As Integer, ByVal j As Integer)

        For k = 0 To not_visit_road.Count - 1

            Dim b As String = not_visit_road(k)
            If InStr(b, i & " " & j) <> 0 Then Return True

        Next

        Return False

    End Function
    Sub u(ByRef array1() As String)

        For j = 0 To 16
            maze(0, j) = 1 : maze(j, 0) = 1 : maze(16, j) = 1 : maze(j, 16) = 1
        Next

        goal = array1(0) : Call walkmaze(1, 1, 0)

        If flag = True Then
            My.Computer.FileSystem.WriteAllText(".\out.txt", "TRUE" & vbCrLf, True)
        Else
            My.Computer.FileSystem.WriteAllText(".\out.txt", "FALSE" & vbCrLf, True)
        End If

        Array.Clear(maze, 0, maze.Length) : not_visit_road.Clear() : flag = False

    End Sub
End Class
