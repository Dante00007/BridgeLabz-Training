using System;

interface IRentable
{
    double CalculateRent();
}

class Vehicle: IRentable
{
    protected DateTime dateOfRent;
    protected DateTime dateOfReturn;
    protected string brand;
    protected string typeOfVehicle;
    protected int price;
    public Vehicle(int price, string typeOfVehicle, string brand)
    {
        this.price = price;
        this.typeOfVehicle = typeOfVehicle;
        this.brand = brand;
        // this.dateOfRent = null;
        // this.dateOfReturn = null;
    }

    public virtual double CalculateRent()
    {

        return (double)(dateOfReturn.Day - dateOfRent.Day) * price;
    }
    
    public virtual void SetDate(DateTime dOR,DateTime dRR)
    {
        this.dateOfRent = dOR;
        this.dateOfReturn = dRR;
    }

    public virtual void Display()
    {
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine("------------------");
        Console.WriteLine($"Vehicle Type:{typeOfVehicle}");
        Console.WriteLine($"Price per day:{price}");
        Console.WriteLine($"Date of Rent:{dateOfRent}");    
        Console.WriteLine($"Date of Return:{dateOfReturn}");
        Console.WriteLine($"Brand:{brand}");
    }
}

class Bike : Vehicle
{
    protected bool selfStart ;

    public Bike(int price,string brand,bool selfStart):base(price,"Bike",brand)
    {
        this.selfStart = selfStart;
    } 
}

class Car : Vehicle
{
    protected string type; //manaual or automatic
    public Car(int price, string type, string brand):base(price,"Car",brand)
    {
        this.type = type;
    }

}

class Truck : Vehicle
{
    protected int capacity;

    public Truck(int price,int capacity,string brand) : base(price,"Truck",brand)
    {
        this.capacity = capacity;
    }
}

class Customer
{
    protected string name;
    protected int age;
    protected string adharNumber;
    protected string phoneNumber;
    protected Vehicle vehicle;

    public Customer(string name, int age, string adharNumber, string phoneNumber)
    {
        this.name = name;
        this.age = age;
        this.adharNumber = adharNumber;
        this.phoneNumber = phoneNumber;
        this.vehicle = null;
    }


    public void RentVehicle(Vehicle v)
    {
        vehicle = v;
        Console.Write("Enter the number of days till you want to rent the vehicle:");
        int days = int.Parse(Console.ReadLine());
        DateTime date =  DateTime.Now;
        vehicle.SetDate(date, date.AddDays(days));
    }

    public void ReturnVehicle()
    {
        Console.WriteLine("Thank You For Using Our Service!");
        Console.WriteLine("Total Amount to be paid: " + vehicle.CalculateRent());
        vehicle = null;
    }
    public void DisplayCustomerDetails()
    {
        Console.WriteLine("\nCustomer Details:");
        Console.WriteLine("------------------");
        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"Adhar Number:{adharNumber}");
        Console.WriteLine($"Phone Number:{phoneNumber}");
        if(vehicle != null)
            vehicle.Display();
        else
            Console.WriteLine("No Vehicle rented currently");
    }
}
class VehicleRentalSystem
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Doe", 25, "123456789012", "+91-9876543210");
        Vehicle car = new Car(200, "Automatic", "Toyota");
        Vehicle bike = new Bike(100, "Honda", false);
        customer.RentVehicle(car);
        customer.DisplayCustomerDetails();
        customer.ReturnVehicle();
    }
}