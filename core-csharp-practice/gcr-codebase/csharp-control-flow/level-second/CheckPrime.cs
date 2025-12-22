
class CheckPrime
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("The number {0} is a prime number", num);
        }
        else
        {
            Console.WriteLine("The number {0} is not a prime number", num);
        }
    }
}