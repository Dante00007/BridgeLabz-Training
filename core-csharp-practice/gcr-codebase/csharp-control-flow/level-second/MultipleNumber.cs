

class MultipleNumber
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = num / 2; i >= 1; i--)
        {
            if (i % num == 0)
                Console.WriteLine(i);
        }
    }
}