
class PoundsToKg
{
    static void Main()
    {
        Console.WriteLine("Enter the weight in pounds");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kg = pounds * 2.2;
        Console.WriteLine("The weight of the person in pounds is {0} and in kg is {1}", pounds, kg);
    }
}