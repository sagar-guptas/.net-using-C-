using System;

partial class Vehicle
{
    public void StartVehicle()
    {
        Console.WriteLine("Vehicle started.");
    }

    public void StopVehicle()
    {
        Console.WriteLine("Vehicle stopped.");
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("\n--- Vehicle Details ---");
        Console.WriteLine("Vehicle Number: " + VehicleNumber);
        Console.WriteLine("Vehicle Model: " + VehicleModel);
        Console.WriteLine("Vehicle Type: " + VehicleType);
    }
}