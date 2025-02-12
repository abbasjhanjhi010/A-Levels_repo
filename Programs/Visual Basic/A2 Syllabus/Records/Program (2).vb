Module Program
    Structure book
        Dim code As Integer
        Dim title As String
        Dim author As String
        Dim yearofpublication As Integer
    End Structure

    Sub main()
        Dim book1(5) As book
        Dim count As Integer
        FileOpen(1, "database.txt", OpenMode.Output)

        For count = 1 To 5
            Console.WriteLine("enter code: ")
            book1(count).code = Console.ReadLine()
            Console.WriteLine("enter title: ")
            book1(count).title = Console.ReadLine()
            Console.WriteLine("enter author: ")
            book1(count).author = Console.ReadLine()
            Console.WriteLine("enter publication: ")
            book1(count).yearofpublication = Console.ReadLine()

            WriteLine(1, book1(count).code)
            Writeline(1, book1(count).title)
            Writeline(1, book1(count).author)
            Writeline(1, book1(count).yearofpublication)
        Next
        Console.ReadLine()
        FileClose(1)
    End Sub

End Module
