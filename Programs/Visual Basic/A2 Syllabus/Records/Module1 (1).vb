Imports System

Module Program
    Structure StockItem
        Dim ProductCode As String
        Dim Price As Decimal
        Dim NumberInStock As Integer
    End Structure

    Sub Main(args As String())
        Dim Cstock As StockItem
        Dim count As Integer
        FileOpen(1, "", OpenMode.Random)
        count = 1
        Do
            FileGet(1, Cstock)

            Console.WriteLine("Details of product {0}", count)
            Console.WriteLine(Cstock.ProductCode)
            Console.WriteLine(Cstock.Price)
            Console.WriteLine(Cstock.NumberInStock)

            count = +1
        Loop Until EOF(1)
    End Sub
End Module
