

class SI
{
    public static double CalculateSI(int p, int r, int t)
    {
        return (p * r * t) / 100.0;
    }
    static void Main()
    {

        Console.WriteLine("Enter Principle");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Rate");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Time");
        int t = Convert.ToInt32(Console.ReadLine());

        double si = CalculateSI(p, r, t);
        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}", si, p, r, t);
    }
}