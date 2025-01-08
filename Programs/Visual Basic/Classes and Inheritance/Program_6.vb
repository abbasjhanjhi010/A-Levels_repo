Imports System

Module Program

    Class Circle
        Public Radius As Integer
        Public Sub SetRadius(ByVal Rad As Integer)
            Me.Radius = Rad

        End Sub
        Public Function Area() As Double
            Return Me.Radius * Me.Radius * Math.PI
        End Function
    End Class

    Sub Main(args As String())
        Dim c As New Circle
        Me.SetRadius(5)

        Console.WriteLine(c.Area())
        Console.ReadKey()
    End Sub
End Module
