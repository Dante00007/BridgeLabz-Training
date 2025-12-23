class DIString
{
    public static string SmallestNumber(string pattern)
    {
        int n = pattern.Length;
        string res = "";
        Stack<char> stack = new Stack<char>();
        int num = 1;
        for (int i = 0; i <= n; i++)
        {
            char ch = (char)(num + '0');
            if (i != n && pattern[i] == 'I')
            {
                res += ch;
                while (stack.Count > 0)
                {
                    res += stack.Pop();
                }
            }
            else
            {
                stack.Push(ch);
            }
            num++;
        }
        while (stack.Count > 0)
        {
            res += stack.Pop();
        }
        return res;
    }

    static void Main()
    {
        string pattern = "IIIDIDDD"; //"123549876"

        Console.WriteLine(SmallestNumber(pattern));

        pattern = "DDD"; //"4321"
        Console.WriteLine(SmallestNumber(pattern));
    }
}