

class AthleteRound
{
    static void Main()
    {
        Console.WriteLine("Enter three sides of triangle");
        int s1 = Convert.ToInt32(Console.ReadLine());
        int s2 = Convert.ToInt32(Console.ReadLine());
        int s3 = Convert.ToInt32(Console.ReadLine());
        double perimeter = s1 + s2 + s3;
        Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km", 5 / perimeter);
    }
}