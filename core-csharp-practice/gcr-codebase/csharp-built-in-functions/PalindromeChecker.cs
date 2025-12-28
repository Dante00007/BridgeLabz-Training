
class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string str = Console.ReadLine().ToLower();
        bool isPalindrome = CheckPalindrome(str);
        if (isPalindrome)
            Console.WriteLine("{0} is a palindrome.", str);
        else
            Console.WriteLine("{0} is not a palindrome.", str);
    }
    public static bool CheckPalindrome(string str)
    {
        int i = 0, j = str.Length - 1;
        while (i < j)
        {
            if (str[i] != str[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
}