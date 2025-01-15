Imports System

Module Program
    Class Shape
        Public Overridable Function CalculateArea() As Double
            Return 0
        End Function
    End Class

    Class Circle
        Inherits Shape

        Public Property Radius As Double

        Public Sub New(ByVal rad As Double)
            Radius = rad
        End Sub

        Public Overrides Function CalculateArea() As Double
            Return (3.14) * Math.Pow(Radius, 2)
        End Function
    End Class

    Class Rectangle
        Inherits Shape
        Public Property Height As Double
        Public Property width As Double

        Public Sub New(ByVal h As Double, ByVal w As Double)
            Height = Height
            width = w
        End Sub

        Public Overrides Function CalculateArea() As Double
            Return Height * width
        End Function
    End Class

    Sub Main(args As String())
        Dim shape As Shape = New Shape()
        Dim circle As Shape = New Circle(3.0)
        Dim rectangle As Shape = New Rectangle(3.0, 4.0)

        Console.WriteLine("The area of shape is " & shape.CalculateArea())
        Console.WriteLine("The area of circle is " & circle.CalculateArea())
        Console.WriteLine("The area of rectangle is " & rectangle.CalculateArea())

        Console.ReadKey()

    End Sub
End Module
