
class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string revStr = "";
        for (int i=str.Length - 1; i >=0 ;i--)
            revStr += str[i];
        Console.WriteLine(revStr);
    }
}