
class Power{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Power");
        int pow=Convert.ToInt32(Console.ReadLine());
        int res=1;
        for(int i=0;i<pow;i++)
            res*=num;
        Console.WriteLine(res);
    }
}