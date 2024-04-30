Module Module2
    Sub Main()
        Dim data As String
        Dim id(49) As Integer
        Dim index As Integer = 0
        FileOpen(1, "C:\Users\0372461\Desktop\Queue.txt", OpenMode.Input)
        Do
            data = LineInput(1)
            Console.WriteLine(data)
            id(index) = data
            index += 1

        Loop Until EOF(1)
        FileClose(1)

        Console.WriteLine("Starting Array output: ")
        For x = 1 To index
            Console.WriteLine(id(x))
        Next

        Console.ReadKey()
    End Sub
End Module
