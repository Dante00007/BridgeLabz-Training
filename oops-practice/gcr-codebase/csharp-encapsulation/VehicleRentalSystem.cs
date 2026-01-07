using System;
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}


public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    public Vehicle(string vNumber, double rate)
    {
        this.vehicleNumber = vNumber;
        this.rentalRate = rate;
    }
    public abstract double CalculateRentalCost(int days);
}

public class Car : Vehicle, IInsurable
{
    private string policyNumber = "policy-123"; 
    public Car(string vNumber, double rate) : base(vNumber, rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 50.0;
    }

    public string GetInsuranceDetails()
    {
        return "Standard Auto Insurance (Policy: " + policyNumber + ")";
    }
}

public class Bike : Vehicle
{
    public Bike(string vNumber, double rate) : base(vNumber, rate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}

public class Truck : Vehicle, IInsurable
{
    private string policyNumber = "POL-TRK-44";

    public Truck(string vNumber, double rate) : base(vNumber, rate) { }

    public override double CalculateRentalCost(int days)
    {
        
        return (RentalRate * days) + 100.0; 
    }

    public double CalculateInsurance()
    {
        return 150.0; 
    }

    public string GetInsuranceDetails()
    {
        return "Commercial Heavy Vehicle Insurance (Policy: " + policyNumber + ")";
    }
}

 class VehicleRentalSystem
{
    static void Main()
    {
        Vehicle[] fleet = new Vehicle[3];
        
        fleet[0] = new Car("C123", 50.0);
        fleet[1] = new Bike("B456", 15.0);
        fleet[2] = new Truck("T789", 200.0);

        int rentalDays = 5;

        Console.WriteLine("--- Vehicle Rental Report (" + rentalDays + " Days) ---");
        Console.WriteLine();

        for (int i = 0; i < fleet.Length; i++)
        {
            Vehicle v = fleet[i];
            double rent = v.CalculateRentalCost(rentalDays);
            double insurance = 0;
            string insuranceInfo = "No Insurance Required";

          
            if (v is IInsurable insurableVehicle)
            {
                insurance = insurableVehicle.CalculateInsurance();
                insuranceInfo = insurableVehicle.GetInsuranceDetails();
            }

            double totalCost = rent + insurance;

            Console.WriteLine("Vehicle Number: " + v.VehicleNumber);
            Console.WriteLine("Rental Cost:    $" + rent);
            Console.WriteLine("Insurance:      $" + insurance + " (" + insuranceInfo + ")");
            Console.WriteLine("Total:          $" + totalCost);
            Console.WriteLine("------------------------------------------");
        }
    }
}