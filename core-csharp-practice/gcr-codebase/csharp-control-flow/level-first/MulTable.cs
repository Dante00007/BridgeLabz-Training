
class MulTable
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
        }
    }
}