
class CountDigit
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine(count);
    }
}