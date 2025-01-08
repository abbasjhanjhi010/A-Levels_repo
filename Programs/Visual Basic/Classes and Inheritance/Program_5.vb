Imports System

Module Program

    Class Greeter
        Public Sub Greet()
            Console.WriteLine("hello object world!")
        End Sub
    End Class
    Sub Main(args As String())
        Dim good As New Greeter()

        Greeter.Greet()
        Console.ReadLine()

    End Sub
End Module
