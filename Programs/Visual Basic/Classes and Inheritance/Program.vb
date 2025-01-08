Imports System

Module Program
    Class Person
        Public Name As String
    End Class

    Sub Main(args As String())
        Dim p1 As New Person
        p1.Name = "Jane"
        Dim p2 As New Person
        p2.Name = "Becky"

        Console.WriteLine(p1.Name)
        Console.WriteLine(p2.Name)
        Console.ReadLine()
    End Sub
End Module
