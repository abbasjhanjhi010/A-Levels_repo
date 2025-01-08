Imports System

Module Program
    Class Person
        Public name As String
        Private Age As Byte
        Public Function GetAge() As Byte
            Return Me.age
        End Function

        Public Sub SetAge(ByVal Age As Byte)
            Me.Age = Age
        End Sub
    End Class
    Sub Main(args As String())
        Dim p As New Person
        p.name = "Jane"
        p.SetAge(17)

        Console.WriteLine("{0}, is {1} years old", p.name, p.GetAge)
        Console.ReadKey()
    End Sub
End Module
