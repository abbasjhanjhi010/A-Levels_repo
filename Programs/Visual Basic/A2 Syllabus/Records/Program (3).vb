Imports System
Imports System.IO

Module Program
    Structure CarRecord
        Dim VehicleID As String
        Dim Registration As String
        Dim DateOfRegistration As Date
        Dim EngineSize As Integer
        Dim PurchasePrice As Decimal
    End Structure

    Sub main()
        Dim Car(100) As CarRecord ' declare an array of CarRecord type
        Dim i As Integer
        Dim CarFileWriter As BinaryWriter
        Dim CarFileReader As BinaryReader
        Dim CarFile As FileStream

        'Dim Car(lOO) As CarRecord 
        ' link file to the file name
        CarFile = New FileStream("CarFile.DAT", FileMode.Create)
        ' create a new file and open it for writing
        CarFileWriter = New BinaryWriter(CarFile)

        For i = 1 To 2 ' 100 ' loop for each array element
            Console.WriteLine("Enter car ID no.")
            Car(i).VehicleID = Console.ReadLine()
            CarFileWriter.Write(Car(i).VehicleID)
            Console.WriteLine("Enter car registration no.")
            Car(i).Registration = Console.ReadLine()
            CarFileWriter.Write(Car(i).Registration)
            Console.WriteLine("Enter car Date of registration.")
            Car(i).DateOfRegistration = Console.ReadLine()
            CarFileWriter.Write(Car(i).DateOfRegistration)
            Console.WriteLine("Enter car EngineSize.")
            Car(i).EngineSize = Console.ReadLine()
            CarFileWriter.Write(Car(i).EngineSize)
            Console.WriteLine("Enter car PurchasePrice.")
            Car(i).PurchasePrice = Console.ReadLine()
            CarFileWriter.Write(Car(i).PurchasePrice)
        Next
        CarFileWriter.Close()
        CarFile.Close()

        CarFile = New FileStream("CarFile.DAT", FileMode.Open)
        CarFileReader = New BinaryReader(CarFile)
        Do While CarFile.Position < CarFile.Length
            Car(i).VehicleID = CarFileReader.ReadString()
            Console.WriteLine(Car(i).VehicleID)
            Car(i).Registration = CarFileReader.ReadString()
            Console.WriteLine(Car(i).Registration)
            Car(i).DateOfRegistration = CarFileReader.ReadString()
            Console.WriteLine(Car(i).DateOfRegistration)
            Car(i).EngineSize = CarFileReader.ReadString()
            Console.WriteLine(Car(i).EngineSize)
            Car(i).PurchasePrice = CarFileReader.ReadString()
            Console.WriteLine(Car(i).PurchasePrice)
            i = +1
        Loop

        CarFileReader.Close()
        CarFile.Close()
        Console.ReadLine()

    End Sub
End Module
