
class WindChill
{
    public static double CalculateWindChill(int temp, int windSpeed)
    {
        return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
    }
    static void Main()
    {
        Console.WriteLine("Enter Temperature in Fahrenheit");
        int temp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Wind Speed in miles per hour");
        int windSpeed = Convert.ToInt32(Console.ReadLine());

        double windChill = CalculateWindChill(temp, windSpeed);
        Console.WriteLine("The Wind Chill Temperature is {0}", windChill);
    }
}