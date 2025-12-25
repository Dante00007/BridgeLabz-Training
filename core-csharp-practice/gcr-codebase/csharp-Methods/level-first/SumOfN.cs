
class SumOfN
{
    static int SumOfNaturalNumbers(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int ans = SumOfNaturalNumbers(num);
        Console.WriteLine("The sum of {0} natural numbers is {1}", num, ans);
    }
}