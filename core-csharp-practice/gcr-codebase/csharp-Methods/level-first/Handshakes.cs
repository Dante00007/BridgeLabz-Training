
class Handshakes
{
    public static int FindNumberOfHandshake(int n)
    {
        return ((n)*(n-1))/2;
    }
    static void Main()
    {
        Console.WriteLine("Enter Number Of Students");
        int n=Convert.ToInt32(Console.ReadLine());
        int handshake= FindNumberOfHandshake(n);
        Console.WriteLine("Maximum Number Of Handshakes Possible Among {0} Students Are {1}",n,handshake);
    }
}