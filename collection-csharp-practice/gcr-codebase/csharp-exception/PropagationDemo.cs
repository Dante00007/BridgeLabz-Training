class PropagationDemo
{
    static void Method1()
    {
        int x = 10, y = 0;
        int z = x / y;
    }

    static void Method2() => Method1();

    static void Main(string[] args)
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}