Imports System

Module Program

    Private WithEvents car As New Car

    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        car.startCar()

        Console.WriteLine("...... Enjoying driving ....")

        car.StopCar()

        Console.WriteLine("Bye bye")

    End Sub


    Sub CarStartedHandler(carStatus As CarStatus) Handles car.CarStarted
        Console.WriteLine($"car is started, temp: {carStatus.engineTemp}, speed: {carStatus.engineSpeed}")
    End Sub


    Sub CarStoppedHandler(carStatus As CarStatus) Handles car.CarStopped
        Console.WriteLine($"car is stopped, temp: {carStatus.engineTemp}, speed: {carStatus.engineSpeed}")
    End Sub

End Module
