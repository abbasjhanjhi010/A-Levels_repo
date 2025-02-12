Imports System

Module Program
    Structure student
        Dim id As Integer
        Dim name As String
        Dim DoB As Date
    End Structure

    Sub Main(args As String())
        Dim newStudents(4) As student

        For x = 0 To 4
            Console.WriteLine("insert the id: ")
            newStudents(x).id = Console.ReadLine()
            Console.WriteLine("insert the name: ")
            newStudents(x).name = Console.ReadLine()
            Console.WriteLine("insert the DoB: ")
            newStudents(x).DoB = Console.ReadLine()
        Next

        For x = 0 To 4
            Console.WriteLine("new record created" & " " & newStudents(x).id & " " & newStudents(x).name & " " & newStudents(x).DoB)
        Next
    End Sub
End Module
