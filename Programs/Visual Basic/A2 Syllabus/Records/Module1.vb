Module Module1

    Structure StockItem
        Dim ProductCode As String
        Dim Price As Decimal
        Dim NumberInStock As Integer
    End Structure

    Sub Main()
        Dim cstock As StockItem
        Dim count As Integer

        FileOpen(1, "", OpenMode.Random)

        Console.WriteLine("Enter record number: ")
        count = Console.ReadLine()
        Seek(1, count)
        FileGet(1, cstock)

        Console.WriteLine("Details of product {0", count)
        Console.WriteLine(cstock.ProductCode)
        Console.WriteLine(cstock.Price)
        Console.WriteLine(cstock.NumberInStock)
        FileClose(1)

        Console.WriteLine("File output successfully")
        Console.ReadKey()
    End Sub

End Module
