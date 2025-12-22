

class Bonus
{
    static void Main()
    {
        Console.WriteLine("Enter Salary");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Year Of Service");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year > 5)
            Console.WriteLine("Bonus is {0}", (salary * 5) / 100);
        else
            Console.WriteLine("No bonus");
    }
}