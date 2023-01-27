Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()

        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "in2.txt", OpenMode.Input)
        FileOpen(3, "out.txt", OpenMode.Output)

        Call y(1)
        PrintLine(3, "")
        Call y(2)

        Me.Close()
    End Sub
    Sub y(ByVal fn As Integer)
        Dim n As Integer = LineInput(fn)

        For i = 1 To n
            Dim s As String = Trim(LineInput(fn))

            Do Until InStr(s, " ") = 0
                s = Replace(s, " ", "")
            Loop

            Dim data() As String = Split(s, "},{")

            data(0) = Replace(data(0), "{", "") : data(1) = Replace(data(1), "}", "")
            PrintLine(3, Union(data(0), data(1)) & ", " & Intersection(data(0), data(1)) & ", " & Set_difference(data(0), data(1)))
        Next

    End Sub
    Function Union(ByVal str1 As String, ByVal str2 As String)
        Dim a As New List(Of String)

        Dim data1() As String = Split(str1, ",") : Dim data2() As String = Split(str2, ",")

        For i = 0 To UBound(data1)
            a.Add(data1(i))
        Next

        For j = 0 To UBound(data2)
            If a.IndexOf(data2(j)) = -1 Then a.Add(data2(j))
        Next

        a.Sort() : Dim ans As String = ""

        For k = 0 To a.Count - 1

            If k <> a.Count - 1 Then
                ans &= a(k) & ", "
            Else
                ans &= a(k)
            End If

        Next

        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If


    End Function
    Function Intersection(ByVal str1 As String, ByVal str2 As String)

        Dim a As New List(Of String)

        Dim data1() As String = Split(str1, ",") : Dim data2() As String = Split(str2, ",")

        For i = 0 To UBound(data1)

            For j = 0 To UBound(data2)
                If data1(i) = data2(j) Then a.Add(data1(i))
            Next

        Next

        a.Sort() : Dim ans As String = ""

        For k = 0 To a.Count - 1

            If k <> a.Count - 1 Then
                ans &= a(k) & ", "
            Else
                ans &= a(k)
            End If

        Next

        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function
    Function Set_difference(ByVal str1 As String, ByVal str2 As String)

        Dim a As New List(Of String)

        Dim data1() As String = Split(str1, ",") : Dim data2() As String = Split(str2, ",")

        For i = 0 To UBound(data1)

            For j = 0 To UBound(data2)
                If data1(i) = data2(j) Then data1(i) = ""
            Next

        Next

        Array.Sort(data1) : Dim ans As String = ""

        For k = 0 To UBound(data1)

            If k <> UBound(data1) And data1(k) <> "" Then
                ans &= data1(k) & ", "
            Else
                ans &= data1(k)
            End If

        Next

        If ans <> "" Then
            Return "{" & ans & "}"
        Else
            Return "N"
        End If

    End Function
End Class
