class LexicographicCompare
{
    static void Main()
    {
        Console.WriteLine("Enter first string: ");
        string str1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter second string: ");
        string str2 = Console.ReadLine().ToLower();
        bool flag = false;
        for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
        {
            if ((int)str1[i] < (int)str2[i])
            {
                flag = true;
                break;
            }
            else if ((int)str1[i] > (int)str2[i])
            {
                flag = false;
                break;
            }
        }
        if (flag == true)
        {
            Console.WriteLine("{0} comes before {1} in lexicographical order", str1, str2);
        }
        else
        {
            Console.WriteLine("{0} comes before {1} in lexicographical order", str2, str1);
        }
    }
}