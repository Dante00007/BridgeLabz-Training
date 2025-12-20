class Periimeter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the side of square");
        int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The perimeter is " + s * 4);
    }
}