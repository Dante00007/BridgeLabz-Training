class FeetYard
{
    public static void Main(string[] args)
    {
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        double yards = distanceInFeet / 3;
        double miles = yards / 1760;
        Console.WriteLine("The distance in yards is " + yards + " and in miles is " + miles);
    }
}