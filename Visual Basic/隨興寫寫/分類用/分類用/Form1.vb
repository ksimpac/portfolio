Public Class Form1
    Dim ClassName As New ArrayList : Dim StudentName(49) As String : Dim Student_Miss_Count(49) As Integer
    Dim Group_Miss_Count(12) As Integer : Dim Group As New ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide() : Call x()

        For i = 1 To 12
            Call z()
            Dim reader As System.IO.StreamReader
            reader = My.Computer.FileSystem.OpenTextFileReader(".\data\" + i.ToString() + ".txt", System.Text.Encoding.Default)
            Call y(reader, i)
            reader.Close()
        Next

        Dim writer As System.IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter(".\data\out.txt", False)

        For i = 0 To 48
            writer.Write(StudentName(i))
            writer.Write(vbTab)
            writer.Write(Student_Miss_Count(i))
            writer.WriteLine()

            Dim Index As Integer = Return_Index(StudentName(i))
            Group_Miss_Count(Index) += Student_Miss_Count(i)
        Next

        writer.WriteLine()

        For i = 1 To 12
            writer.Write("第" + i.ToString() + "組" + "總共" + Group_Miss_Count(i).ToString() + "次")
            writer.WriteLine()
        Next

        writer.Close()

        Me.Close()

    End Sub

    Function Return_Index(ByVal search_name As String)

        For i = 1 To 12

            For Each Name As String In Group(i)
                If Name = search_name Then
                    Return i
                End If
            Next

        Next
    End Function

    Sub x()

        Dim reader As System.IO.StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader(".\data\組員名單.txt", System.Text.Encoding.Default)
        Group.Add("")

        For i = 1 To 12

            Dim str As String = reader.ReadLine()
            Dim data() As String = Split(str, vbTab)
            Dim Name_Temp As New ArrayList

            For j = 1 To UBound(data)
                Name_Temp.Add(Trim(data(j)))
            Next

            Group.Add(Name_Temp)
        Next

    End Sub

    Sub y(ByVal stream As System.IO.StreamReader, ByVal i As Integer)

        Dim str As String = "123"

        Do Until str = ""
            str = stream.ReadLine()
            ClassName.Remove(str)
        Loop

        For Each name As String In ClassName

            If name <> "" Then
                Student_Miss_Count(Array.IndexOf(StudentName, name)) += 1
            End If

        Next

    End Sub

    Sub z()

        ClassName.Clear()

        Dim reader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(".\data\班上名單.txt", System.Text.Encoding.Default)
        Dim str As String = "123"

        Do Until str = ""
            str = reader.ReadLine()
            ClassName.Add(str)
        Loop

        ClassName.CopyTo(StudentName)

        reader.Close()

    End Sub
End Class
