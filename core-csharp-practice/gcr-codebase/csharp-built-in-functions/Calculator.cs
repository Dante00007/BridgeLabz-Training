
class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter operator : ");
        char op = Convert.ToChar(Console.ReadLine());
        switch (op)
        {
            case '+':
                Console.WriteLine("Sum is : {0}", Add(num1, num2));
                break;
            case '-':
                Console.WriteLine("Difference is : {0}", Subtract(num1, num2));
                break;
            case '*':
                Console.WriteLine("Product is : {0}", Multiply(num1, num2));
                break;
            case '/':
                Console.WriteLine("Quotient is : {0}", Divide(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }
}

