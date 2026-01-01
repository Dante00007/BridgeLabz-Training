

class Vehicle
{
    public static int registrationFee=1000;
    public string OwnerName;
    public string VehicleType;
    public readonly string registrationNumber;
    
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.registrationNumber = registrationNumber;
    }
    public static void UpdateRegistrationFee(int fee)
    {
        registrationFee = fee;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Owner Name : " + OwnerName);
        Console.WriteLine("Vehicle Type : " + VehicleType);
        Console.WriteLine("Registration Number : " + registrationNumber);
        Console.WriteLine("Registration Fee : " + registrationFee);
    }
    static void Main()
    {
        Vehicle v1 = new Vehicle("John Doe", "Car", "ABC123");
        if (v1 is Vehicle)
            v1.DisplayDetails();
       
    }
}