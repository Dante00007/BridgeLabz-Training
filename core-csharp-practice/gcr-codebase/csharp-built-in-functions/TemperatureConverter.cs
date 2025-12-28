


class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("If you want to convert from Celsius to Fahrenheit press 'C' ");
        Console.WriteLine("if you want to convert from Fahrenheit to Celsius press 'F'.");

        char choice = Console.ReadLine().ToUpper()[0];
        if (choice == 'C')
        {
            Console.Write("Enter temperature in celsius : ");
            double tempInCelcius = Convert.ToDouble(Console.ReadLine());
            double tempInFahrenheit = CelciusToFahrenheit(tempInCelcius);
            Console.WriteLine("Temperature in fahrenheit is : {0}", tempInFahrenheit);
        }
        else
        {
            Console.Write("Enter temperature in fahrenheit : ");
            double tempInFahrehheit = Convert.ToDouble(Console.ReadLine());
            double tempInCelcius1 = FahrenheitToCelcius(tempInFahrehheit);
            Console.WriteLine("Temperature in celcius is : {0}", tempInCelcius1);
        }
    }
    public static double CelciusToFahrenheit(double tempInCelcius)
    {
        return ((tempInCelcius * 9 / 5) + 32);
    }
    public static double FahrenheitToCelcius(double tempInFahrenheit)
    {
        return ((tempInFahrenheit - 32) * 5 / 9);
    }
}