
class Harshad
{
    static void Main()
    {
        int num, sum = 0;
        Console.WriteLine("Enter any number");
        num = int.Parse(Console.ReadLine());
        int temp = num;
        while (temp > 0)
        {
            sum += (temp % 10);
            temp /= 10;
        }
    }
}