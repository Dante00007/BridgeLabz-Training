using System;

public interface IRefuelable
{
    void Refuel();
}
public class Vehicle
{
    public string Model { get; set; }
    public int MaxSpeed { get; set; }

    public Vehicle(string model, int maxSpeed)
    {
        Model = model;
        MaxSpeed = maxSpeed;
    }
}

public class PetrolVehicle : Vehicle, IRefuelable
{
    public string FuelType { get; set; }

    public PetrolVehicle(string model, int speed, string fuelType) : base(model, speed)
    {
        FuelType = fuelType;
    }

    public void Refuel()
    {
        Console.WriteLine($"Filling the {Model} with {FuelType} fuel.");
    }
}

public class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }

    public ElectricVehicle(string model, int speed, int battery) : base(model, speed)
    {
        BatteryCapacity = battery;
    }

    public void Charge()
    {
        Console.WriteLine($"Charging the {Model}. Battery capacity is {BatteryCapacity} kWh.");
    }
}

class VehicleManagement
{
    static void Main()
    {
        PetrolVehicle petrolCar = new PetrolVehicle("Toyota Camry", 200, "Petrol");
        ElectricVehicle electricBike = new ElectricVehicle("Tesla Model S", 150, 75);

        petrolCar.Refuel();
        electricBike.Charge();
    }
}