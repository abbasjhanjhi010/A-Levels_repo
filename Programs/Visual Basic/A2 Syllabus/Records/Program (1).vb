Imports System

Module Program
    Structure StockItem
        Dim ProductCode As String
        Dim price As Decimal
        Dim NumberInStock As Integer
    End Structure

    Sub Main(args As String())
        Dim Cstock As StockItem
        Dim count As Integer

        FileOpen(1, "", OpenMode.Random)
        For count = 1 To 5
            Console.WriteLine("Enter details of stock {0}", count)
            Console.WriteLine("Enter product code")
            Cstock.ProductCode = Console.ReadLine()
            Console.WriteLine("Enter price of stock item")
            Cstock.price = Console.ReadLine()
            Console.WriteLine("Enter quantity in stock")
            Cstock.NumberInStock = Console.ReadLine()
            FilePut(1, Cstock)

        Next count
        FileClose(1)

        Console.WriteLine("File Written Successfully")
        Console.ReadKey()
    End Sub
End Module
