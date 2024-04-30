Module Module1

    Sub Main()
        ' OpenMode.Input 

        Dim Student_Name As String
        Dim Student_Detail As String
        Dim Student_Mark As String
        Dim Name_Length As Integer
        Dim LCount As Integer
        Dim LCount1 As Integer

        FileOpen(1, "c:\[FILE NAME]", OpenMode.Input)
        Do
            Student_Detail = LineInput(1) ' reads one line of data from the file
            Console.WriteLine(Student_Detail)
            Name_Length = Len(Student_Detail)
            LCount = Name_Length
            Student_Name = Mid(Student_Detail, 2, LCount)
            Student_Mark = Mid(Student_Detail, LCount1, 2)

            Console.WriteLine(Name_Length)
            Console.WriteLine(Student_Name)
            Console.WriteLine(Student_Mark)
        Loop Until EOF(1)
        Console.ReadKey()
        FileClose(1)
    End Sub

End Module
