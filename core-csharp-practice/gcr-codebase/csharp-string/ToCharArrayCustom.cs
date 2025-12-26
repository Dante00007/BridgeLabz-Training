
class ToCharArrayCustom
{
    static void Main()
    {
        string str = "Hello World";
        char[] arr = GetCharacters(str);

        Console.WriteLine("Custom Method Result: ");
        foreach (char c in arr)
            Console.Write(c);
        Console.WriteLine();

        Console.WriteLine("String.ToCharArray() Result: ");
        char[] arr2 = str.ToCharArray();
        foreach (char c in arr2)
            Console.Write(c);

    }
    public static char[] GetCharacters(string str)
    {
        int len = str.Length;
        char[] arr = new char[len];
        for (int i = 0; i < len; i++)
        {
            arr[i] = str[i];
        }
        return arr;
    }
}