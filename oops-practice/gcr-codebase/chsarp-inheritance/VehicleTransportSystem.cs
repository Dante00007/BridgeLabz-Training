

class Vehicle
{
    private int maxspeed;
    private string fueltype;
    public Vehicle(int speed, string fuel)
    {
        this.maxspeed = speed;
        this.fueltype = fuel;
    }
    public void SetMaxSpeed(int speed)
    {
        this.maxspeed = speed;
    }
    public void SetFuelType(string fuel)
    {
        this.fueltype = fuel;
    }
    public int GetMaxSpeed()
    {
        return maxspeed;
    }
    public string GetFuelType()
    {
        return fueltype;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + maxspeed);
        Console.WriteLine("Fuel Type:" + fueltype);
    }
}

class Car : Vehicle
{
    private int seatcapacity;
    public Car(int speed, string fuel, int capacity) : base(speed, fuel)
    {
        this.seatcapacity = capacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity:" + seatcapacity);
    }
}
class Truck : Vehicle
{
    private int payloadcapacity;
    public Truck(int speed, string fuel, int capacity) : base(speed, fuel)
    {
        this.payloadcapacity = capacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity:" + payloadcapacity);
    }
}

class Motorcycle : Vehicle
{
    private bool hassidecar;
    public Motorcycle(int speed, string fuel, bool sidecar) : base(speed, fuel)
    {
        this.hassidecar = sidecar;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar:" + hassidecar);
    }
}

class VehicleTransportSystem
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(120, "Petrol", 5);
        vehicles[1] = new Truck(80, "Diesel", 1000);
        vehicles[2] = new Motorcycle(60, "Electric", false);
        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine("--------------------");
            v.DisplayInfo();
        }
    }
}