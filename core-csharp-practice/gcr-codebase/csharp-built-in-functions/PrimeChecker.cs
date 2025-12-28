
class PrimeChecker
{
    public static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine("{0} is a prime number", num);
        else
            Console.WriteLine("{0} is not a prime number", num);
    }
}