class SwapTwo
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The before swapping numbers are num1 = {0} and num2 = {1}", num1, num2);
        num1 += num2;
        num2 = num1 - num2;
        num1 -= num2;
        Console.WriteLine("The swapped numbers are num1 = {0} and num2 = {1}", num1, num2);


    }
}