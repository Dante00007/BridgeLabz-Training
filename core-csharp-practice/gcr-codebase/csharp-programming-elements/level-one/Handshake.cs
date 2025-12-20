class Handshake
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number Of Students");
        int num = Convert.ToInt32(Console.ReadLine());
        int handshake = (num * (num - 1)) / 2;
        Console.WriteLine(handshake);
    }
}