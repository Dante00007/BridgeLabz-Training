
class MaxOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number : ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = FindMax(num1, num2, num3);
        Console.WriteLine("The maximum number is : {0}", max);
    }

    static int FindMax(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
            return num1;
        else if (num2 > num1 && num2 > num3)
            return num2;
        else
            return num3;
    }
}
