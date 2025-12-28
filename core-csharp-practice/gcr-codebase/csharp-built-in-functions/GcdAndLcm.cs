class GcdAndLcm
{
    static void Main()
    {
        Console.Write("Enter first number : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int gcd = Gcd(num1,num2);
        int lcm = Lcm(num1,num2);
        Console.WriteLine("GCD of {0} and {1} is {2}", num1, num2,gcd);
        Console.WriteLine("LCM of {0} and {1} is {2}", num1, num2,lcm);
    }
    public static int Gcd(int a,int b)
    {
        if(b==0)
            return a;
        else
            return Gcd(b,a%b);
    }
    public static int Lcm(int a,int b)
    {
        return (a*b)/Gcd(a,b);
    }
}