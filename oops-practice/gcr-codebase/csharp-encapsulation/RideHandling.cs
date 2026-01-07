using System;

public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

public abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    public string VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    public Vehicle(string id, string name, double rate)
    {
        this.vehicleId = id;
        this.driverName = name;
        this.ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public string GetVehicleDetails()
    {
        return "ID: " + vehicleId + " | Driver: " + driverName + " | Rate/Km: $" + ratePerKm;
    }
}

public class Car : Vehicle, IGPS
{
    private string location;

    public Car(string id, string name, double rate) : base(id, name, rate) 
    {
        this.location = "Garage";
    }

    public override double CalculateFare(double distance)
    {
        double baseFare = 5.0;
        return baseFare + (RatePerKm * distance);
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        this.location = newLocation;
    }
}

public class Bike : Vehicle, IGPS
{
    private string location;

    public Bike(string id, string name, double rate) : base(id, name, rate) 
    {
        this.location = "Parking Lot";
    }

    public override double CalculateFare(double distance)
    {
        return RatePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        this.location = newLocation;
    }
}

public class Auto : Vehicle
{
    public Auto(string id, string name, double rate) : base(id, name, rate) { }

    public override double CalculateFare(double distance)
    {
        double convenienceFee = 2.0;
        return (RatePerKm * distance) + convenienceFee;
    }
}

class RideHandling
{
    static void Main()
    {
        Vehicle[] fleet = new Vehicle[3];
        fleet[0] = new Car("C-99", "Robert", 1.5);
        fleet[1] = new Bike("B-22", "Marco", 0.8);
        fleet[2] = new Auto("A-44", "Suresh", 1.2);

        double tripDistance = 10.5;

        Console.WriteLine("--- Ride Hailing Fleet Status ---");
        Console.WriteLine();

        for (int i = 0; i < fleet.Length; i++)
        {
            Vehicle v = fleet[i];
            
            Console.WriteLine(v.GetVehicleDetails());
            Console.WriteLine("Estimated Fare for " + tripDistance + "km: $" + v.CalculateFare(tripDistance));

            if (v is IGPS gpsDevice)
            {
                gpsDevice.UpdateLocation("Main Street Sector 4");
                Console.WriteLine("GPS Status: Active at " + gpsDevice.GetCurrentLocation());
            }
            else
            {
                Console.WriteLine("GPS Status: Not Available");
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}