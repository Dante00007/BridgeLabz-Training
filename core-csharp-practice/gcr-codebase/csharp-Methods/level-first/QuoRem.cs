

class QuoRem
{
    public static int[] FindRemainderAndQuotient(int dividend, int divisor)
    {
        if (divisor == 0){
            Console.WriteLine("Divisor cannot be Zero");
    
        }
        int[] result = new int[2];
        result[0] = dividend / divisor;
        result[1] = dividend % divisor;
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Enter Dividend number ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Divisor, cannot be zero ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be Zero");
            return;
        }

        int[] result = FindRemainderAndQuotient(dividend, divisor);
        Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}", result[0], result[1], dividend, divisor);

    }
}