
class PosNeg
{
    public static int CheckNumber(int n)
    {
        if (n > 0)
            return 1;
        else if (n < 0)
            return -1;
        else
            return 0;
    }
    static void Main()
    {
        Console.WriteLine("Enter an Integer");
        int num = Convert.ToInt32(Console.ReadLine());
        int ans = CheckNumber(num);

        if (ans == 1)
            Console.WriteLine("{0} is Positive", num);
        else if (ans == -1)
            Console.WriteLine("{0} is Negative", num);
        else
            Console.WriteLine("Number is Zero");
    }
}