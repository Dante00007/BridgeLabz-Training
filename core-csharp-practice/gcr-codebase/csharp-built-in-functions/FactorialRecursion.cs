
class FactorialRecursion
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        long fact = Factorial(num);
        Console.WriteLine("Factorial of {0} is {1}", num, fact);
    }
    public static long Factorial(int num)
    {
        if (num == 0)
            return 1;
        else
            return num * Factorial(num - 1);
    }
}