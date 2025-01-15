Imports System


Class Person
        Private_Name As String

        Public Sub New(ByVal name As String)
        MyClass._name = name

        Console.WriteLine(MyClass._Name)
            Console.WriteLine(name)
            Console.WriteLine(_name)
        End Sub
    End Class

    Module Program
        Sub Main(args As String())
        Dim p As Person = New Person("Sam")
        Console.ReadKey()
    End Sub
    End Module
