
class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i++ <= num)
        {
            if (i % 3 == 0 && i % 5 != 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0 && i % 3 != 0)
                Console.WriteLine("Buzz");
            else if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else
                Console.WriteLine(i);
        }
    }
}