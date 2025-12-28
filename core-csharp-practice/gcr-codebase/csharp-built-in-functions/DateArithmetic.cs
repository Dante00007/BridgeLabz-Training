class DateArithmetic
{
    static void Main()
    {
        Console.WriteLine("Enter Current Date: ");
        DateTime currentDate = DateTime.Parse(Console.ReadLine());
        DateTime futureDate = currentDate.AddDays(7).AddMonths(1).AddYears(2);
        DateTime pastDate = futureDate.AddDays(-21);

        Console.WriteLine("Future Date: {0}", futureDate);
        Console.WriteLine("Past Date: {0}", pastDate.Date);
    }
}