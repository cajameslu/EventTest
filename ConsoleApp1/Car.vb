Public Class Car

    Public Event CarStarted(carSTatus As CarStatus)
    Public Event CarStopped(carSTatus As CarStatus)

    Public Sub startCar()
        Console.WriteLine("Starting the car ...")

        RaiseEvent CarStarted(New CarStatus(20.2, 1000))

    End Sub

    Public Sub StopCar()
        Console.WriteLine("stopping the car ...")

        RaiseEvent CarStopped(New CarStatus(40.2, 0))
    End Sub
End Class
