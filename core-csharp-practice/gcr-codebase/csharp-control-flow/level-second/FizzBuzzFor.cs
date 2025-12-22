
class FizzBuzzFor
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Number should be positive");
            return;
        }
        for (int i = 0; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0 && i % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}