

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Enter the number of terms : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Fibonacci(n);
    }
    public static void Fibonacci(int n)
    {
        int t1 = 0, t2 = 1, sum = 0;
        Console.Write("Fibonacci Series : ");
        for (int i = 1; i <= n; ++i)
        {
            Console.Write(t1 + " ");
            sum = t1 + t2;
            t1 = t2;
            t2 = sum;
        }
    }
}
