Module Module1

    Sub Main()
        '' Open.Mode Append TUtorial 
        Dim Student_Name, Student_Detail As String
        Dim Studnet_Mark As Integer

        FileOpen(1, "D: \File_Append.txt", OpenMode.Append)
        For count = 1 To 5
            Console.WriteLine("Enter student name: ")
            Student_Name = Console.ReadLine()
            Console.WriteLine("Enter student mark: ")
            Studnet_Mark = Console.ReadLine()
            Student_Detail = Student_Name & Studnet_Mark
            WriteLine(1, Student_Detail)
        Next count
        FileClose(1)
    End Sub

End Module
