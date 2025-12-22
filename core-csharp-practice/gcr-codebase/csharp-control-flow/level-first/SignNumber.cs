
class SignNumber
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            Console.WriteLine("positive");
        else if (num < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("zero");
    }
}