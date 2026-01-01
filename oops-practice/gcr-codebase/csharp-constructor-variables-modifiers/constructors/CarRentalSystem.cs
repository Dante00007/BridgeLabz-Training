
class CarRentalSystem
{
    private string customerName;
    private string carModel;
    private int rentalDays;
    public CarRentalSystem(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }
    public double CalculateTotalCost(double ratePerDay)
    {
        return ratePerDay * rentalDays;
    }

    static void Main()
    {
        CarRentalSystem carRental = new CarRentalSystem("John Doe", "Toyota Camry", 5);
        double totalCost = carRental.CalculateTotalCost(50.0);
    }
}