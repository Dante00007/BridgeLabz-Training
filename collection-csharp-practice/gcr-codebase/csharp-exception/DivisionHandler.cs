class DivisionHandler
{
    static void Main(string[] args)
    {
        try
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 / num2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero occurred");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format");
        }
    }
}