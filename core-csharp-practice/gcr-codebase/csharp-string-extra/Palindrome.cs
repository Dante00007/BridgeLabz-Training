class Palindrome
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        int i = 0;
        int j = str.Length - 1;
        while (i < j)
        {
            if (Char.ToLower(str[i]) != Char.ToLower(str[j]))
            {
                Console.WriteLine("The string is not a palindrome.");
                return;
            }
            i++;
            j--;
        }
        Console.WriteLine("The string is a palindrome.");
    }
}
