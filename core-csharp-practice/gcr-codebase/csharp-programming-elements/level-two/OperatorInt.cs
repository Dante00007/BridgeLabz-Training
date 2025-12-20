class OperatorInt
{
    static void Main()
    {
        Console.WriteLine("Enter value of a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of b and b should not be zero");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of c");
        int c = Convert.ToInt32(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Please enter valid value of b");
            return;
        }
        Console.WriteLine("The results of Int Operation (a+b*c) is {0}", (a + b * c));
        Console.WriteLine("The results of Int Operation (a*b+c) is {0}", (a * b + c));
        Console.WriteLine("The results of Int Operation (c+a/b) is {0}", (c + a / b));
        Console.WriteLine("The results of Int Operation (a%b+c) is {0}", (a % b + c));
    }
}