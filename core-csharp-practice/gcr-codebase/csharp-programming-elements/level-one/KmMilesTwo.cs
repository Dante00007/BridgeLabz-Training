
class KmMilesTwo{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Kilometer");
        double km = Convert.ToDouble(Console.ReadLine());
        double mile = (km * 0.621371);
        Console.WriteLine(mile + " Miles");
    }
}