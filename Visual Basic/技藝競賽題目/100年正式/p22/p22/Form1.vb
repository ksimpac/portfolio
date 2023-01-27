Public Class Form1
    Dim maze(16, 16) As String : Dim changedmaze(16, 16) As String : Dim flag As Boolean : Dim not_visit_road As New List(Of String) : Dim goal As Integer : Dim start_i, start_j As Integer
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

            If i < 16 Then

                Call z(i, array1)

            ElseIf i = 17 Or i = 18 Then

                For j = 0 To 16
                    maze(0, j) = 1 : maze(j, 0) = 1 : maze(16, j) = 1 : maze(j, 16) = 1
                Next

                goal = array1(0) : Array.Copy(maze, changedmaze, maze.Length)

                If i = 17 Then Dim n() As String = Split(array1(i), " ") : start_i = n(0) : start_j = n(1)
                If i = 18 Then

                    Dim n() As String = Split(array1(i), " ") : Call walkmaze(start_i, start_j, 0, n(0), n(1))

                    If flag = True Then
                        My.Computer.FileSystem.WriteAllText(".\out.txt", "TRUE" & vbCrLf, True)
                    Else
                        My.Computer.FileSystem.WriteAllText(".\out.txt", "FALSE" & vbCrLf, True)
                    End If

                    not_visit_road.Clear() : flag = False

                End If

            ElseIf i = 20 Or i = 21 Then


                For j = 0 To 16
                    maze(0, j) = 1 : maze(j, 0) = 1 : maze(16, j) = 1 : maze(j, 16) = 1
                Next

                goal = array1(0) : Array.Copy(maze, changedmaze, maze.Length)

                If i = 20 Then Dim n() As String = Split(array1(i), " ") : start_i = n(0) : start_j = n(1)

                If i = 21 Then
                    Dim n() As String = Split(array1(i), " ") : Call walkmaze(start_i, start_j, 0, n(0), n(1))

                    If flag = True Then
                        My.Computer.FileSystem.WriteAllText(".\out.txt", "TRUE" & vbCrLf, True)
                    Else
                        My.Computer.FileSystem.WriteAllText(".\out.txt", "FALSE" & vbCrLf, True)
                    End If

                    Array.Clear(maze, 0, maze.Length) : not_visit_road.Clear() : flag = False

                End If

            End If

        Next

    End Sub

    Sub z(ByVal i As Integer, ByRef data() As String)

        Dim num As Integer = 1 '字數

        Do Until num > 15
            maze(i, num) = Mid(data(i), num, 1)
            num += 1
        Loop

    End Sub
    Sub walkmaze(ByRef i As Integer, ByRef j As Integer, ByRef times As Integer, ByVal end_i As Integer, ByVal end_j As Integer)


        If i = end_i And j = end_j And times - 1 <= goal Then
            flag = True
        Else

            If changedmaze(i, j + 1) = 0 And check(i, j + 1) = False Then
                not_visit_road.Add(i & " " & j + 1 & " " & times + 1)
            End If

            If changedmaze(i + 1, j) = 0 And check(i + 1, j) = False Then
                not_visit_road.Add(i + 1 & " " & j & " " & times + 1)
            End If

            If changedmaze(i, j - 1) = 0 And check(i, j - 1) = False Then
                not_visit_road.Add(i & " " & j - 1 & " " & times + 1)
            End If

            If changedmaze(i - 1, j) = 0 And check(i - 1, j) = False Then
                not_visit_road.Add(i - 1 & " " & j & " " & times + 1)
            End If

            If not_visit_road.Count = 0 Then Exit Sub

            changedmaze(i, j) = 1 : Dim n() As String = Split(not_visit_road(0), " ") : not_visit_road.Remove(not_visit_road(0))
            Call walkmaze(n(0), n(1), n(2), end_i, end_j)


        End If

    End Sub
    Function check(ByVal i As Integer, ByVal j As Integer)

        For k = 0 To not_visit_road.Count - 1

            Dim b As String = not_visit_road(k)
            If InStr(b, i & " " & j) = 1 Then Return True

        Next

        Return False

    End Function
End Class
