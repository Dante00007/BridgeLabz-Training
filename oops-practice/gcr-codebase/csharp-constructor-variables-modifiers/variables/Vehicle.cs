
public class Vehicle
{
    public string ownerName;
    public string vehicleType;
    public static double registrationFee=1000;
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: "+ownerName);
        Console.WriteLine("Vehicle Type: "+vehicleType);
        Console.WriteLine("Registration Fee: "+registrationFee);
    }
    public static void UpdateRegistrationFee(double fee)
    {
        registrationFee=fee;
    }
    static void Main()
    {
        Vehicle v1=new Vehicle();
        v1.ownerName="John Doe";
        v1.vehicleType="Car";
        v1.DisplayVehicleDetails();
        Vehicle.UpdateRegistrationFee(2000);
        v1.DisplayVehicleDetails();
    }
}