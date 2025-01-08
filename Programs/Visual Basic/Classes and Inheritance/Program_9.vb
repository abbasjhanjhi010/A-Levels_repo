Imports System

Module Program
    MustInherit Class PassengerVehicle
        Protected RegNo As String
        Protected NoofSeats As Integer
        Public Function ShowRegNo()
            ShowRegNo = RegNo
        End Function

        Public Function ShowNoSeats()
            ShowNoSeats = NoofSeats
        End Function
    End Class

    Class Bus
        Inherits PassengerVehicle
        Private MaxStanding As Integer
        Private SB As Boolean

        Public Sub New(ByVal RN As String, ByVal NOS As Integer, ByVal MS As Integer)
            Me.RegNo = RN
            Me.NoofSeats = NOS
            Me.MaxStanding = MS

        End Sub

        Public Function ShowMaxStanding() As Integer
            ShowMaxStanding = MaxStanding
        End Function
        Public Function ShowSB() As Boolean
            ShowSB = SB
        End Function
    End Class

    Sub Main(args As String())
        Dim pv1 As Bus = New Bus("NBR 123", 51, 10)

        Console.WriteLine("Registration Number: " & pv1.ShowRegNo)
        Console.WriteLine("Number of seats: " & pv1.ShowNoSeats)
        Console.WriteLine("Show Max standing: " & pv1.ShowMaxStanding)

        Console.ReadKey()
    End Sub
End Module
