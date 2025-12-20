
class OperatorDob
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Division by zero not possible");
            return;
        }
        Console.WriteLine("The results of Double Operation (a+b*c) is {0}", (a + b * c));
        Console.WriteLine("The results of Double Operation (a*b+c) is {0}", (a * b + c));
        Console.WriteLine("The results of Double Operation (c+a/b) is {0}", (c + a / b));
        Console.WriteLine("The results of Double Operation (a%b+c) is {0}", (a % b + c));
    }
}