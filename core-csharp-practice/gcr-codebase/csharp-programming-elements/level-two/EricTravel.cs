class EricTravel
{
    static void Main()
    {
        Console.WriteLine("Enter your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter From City");
        string fromCity = Console.ReadLine();
        Console.WriteLine("Enter Via City");
        string viaCity = Console.ReadLine();
        Console.WriteLine("Enter To City");
        string toCity = Console.ReadLine();
        Console.WriteLine("Enter Distance from " + fromCity + " to " + viaCity);
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Distance from " + viaCity + " to " + toCity);
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Time Taken for Journey");
        TimeSpan timeTaken = TimeSpan.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        TimeSpan totalTime = timeTaken.Add(TimeSpan.FromHours(fromToVia / 60));
        Console.WriteLine("The Results of the Trip are : {0} , {1} , {2}", name , totalDistance , timeTotal);
    }
}