using System;

class A3P5
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();

        vehicle.VehicleNumber = "UP79Z1827";
        vehicle.VehicleModel = "Honda City";
        vehicle.VehicleType = "Car";

        vehicle.DisplayVehicleDetails();

        vehicle.StartVehicle();
        vehicle.StopVehicle();
    }
}