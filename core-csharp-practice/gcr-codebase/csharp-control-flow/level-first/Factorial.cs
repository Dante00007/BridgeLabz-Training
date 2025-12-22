
class ForFactorial
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 0)
            Console.WriteLine("Invalid Input");
        else if (num == 0 || num == 1)
            Console.WriteLine("Factorial of {0} is 1", num);
        else
        {
            long fact = 1;
            int i = 2;
            while (i <= num)
            {
                fact *= i++;
            }
        }
        Console.WriteLine("Factorial of {0} is {1}", num, fact);
    }
}