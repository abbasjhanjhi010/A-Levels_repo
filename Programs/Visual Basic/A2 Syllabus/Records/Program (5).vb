Imports System

Module Program
    Dim studentID As Integer
    Dim studentName As String
    Dim studentDoB As Date

    Sub Main(args As String())
        Console.Write("Insert the id: ")
        studentID = Console.ReadLine()
        Console.Write("Insert the name: ")
        studentName = Console.ReadLine()
        Console.Write("Insert the Date of Birth: ")
        studentDoB = Console.ReadLine()

        Console.WriteLine("new record created: " & studentID & " " & studentName & " " & studentDoB)
    End Sub
End Module
