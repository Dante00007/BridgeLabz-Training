

class FibonacciComparison
{
    static long FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static long FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
    static void Main()
    {
        int n = 40; 

        DateTime start1 = DateTime.Now;
        long res1 = FibonacciRecursive(n);
        DateTime end1 = DateTime.Now;
        Console.WriteLine("Recursive Result: " + res1);
        Console.WriteLine("Recursive Time: " + (end1 - start1).TotalMilliseconds + " ms");

        DateTime start2 = DateTime.Now;
        long res2 = FibonacciIterative(n);
        DateTime end2 = DateTime.Now;
        Console.WriteLine("Iterative Result: " + res2);
        Console.WriteLine("Iterative Time: " + (end2 - start2).TotalMilliseconds + " ms");
    }

    
}