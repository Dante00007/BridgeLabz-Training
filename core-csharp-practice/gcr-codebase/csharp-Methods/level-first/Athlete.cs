
class Athlette
{
    static double CalculateRound(int side1,int side2,int side3)
    {
        double perimeter = side1 + side2 + side3;
        double round = 5 / perimeter;
        return round;
    }
     static void Main()
    {
        int side1 = Convert.ToInt32(Console.ReadLine());
        int side2 = Convert.ToInt32(Console.ReadLine());
        int side3 = Convert.ToInt32(Console.ReadLine());

        double round = CalculateRound(side1,side2,side3);
        
        Console.WriteLine("The number of rounds are {0}",round);
    }
}