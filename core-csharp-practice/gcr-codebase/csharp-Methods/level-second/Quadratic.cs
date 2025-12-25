
class Quadratic
{
    static double FindDelta(int a,int b,int c)
    {
        return (Math.Pow(b,2)-(4*a*c));
    }
    static double[] FindRoots(int a,int b,int c)
    {
        double[] roots=new double[2];
        double delta=FindDelta(a,b,c);
        if(delta<0)
        {
            return roots;
        }
        else if(delta==0)
        {
            return new double[] {-b/(2*a)};
        }
        else
        {
            return new double[]{-b+(Math.Sqrt(delta))/(2*a),-b-(Math.Sqrt(delta))/(2*a)};
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter value for a");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b");
        int b=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for c");
        int c=int.Parse(Console.ReadLine());

        double [] roots=FindRoots(a,b,c);

        if(roots.Length>0)
        {
            Console.WriteLine("Roots are {0} and {1}",roots[0],roots[1]);
        }
        else
        {
            Console.WriteLine("Roots are not real");
        }
    }
}