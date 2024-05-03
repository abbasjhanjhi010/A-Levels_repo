Module Module2
    Sub Main()

        Dim CDTitle As String
        Dim CDArtist As String
        Dim CDLocation(2, 7)
        Dim loc_Req As String

        FileOpen(1, "D:\Data_Storage.txt", OpenMode.Append)
        For x = 0 To 7
            Console.WriteLine("Enter the CD title: ")
            CDLocation(0, x) = Console.ReadLine()
            Console.WriteLine("Enter the CD Artist: ")
            CDLocation(1, x) = Console.ReadLine()
            Console.WriteLine("Enter the CD Location: ")
            CDLocation(2, x) = Console.ReadLine()


            WriteLine(1, CDLocation(0, x) & ": " & CDLocation(1, x) & ": " & CDLocation(2, x))
        Next

        Console.Write("Input 'leave' if you wish for the location-finder to temrinate once it has started")
        Dim loc As String = Console.ReadLine()

        For count = 0 To (loc_Req - 1)
            Console.Write("Enter the location you wish to know information of: ")
            loc_Req = Console.ReadLine()

            If (loc = CDLocation(2, count)) Then
                Console.WriteLine($"The location has the following information about it: {CDLocation(0, count)}: {CDLocation(1, count)}")
            End If

            If (loc_Req = "leave") Then
                Environment.Exit(1)
            End If

        Next





        FileClose(1)
    End Sub
End Module
