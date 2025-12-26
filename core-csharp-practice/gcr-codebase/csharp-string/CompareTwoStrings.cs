
class CompareTwoStrings
{
    static void Main()
    {
        
        Console.WriteLine("Enter First String");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter Second String");
        string str2 = Console.ReadLine();
       
        bool res = Compare(str1, str2);

        Console.WriteLine("Custom Method Result: {0}", res);
        Console.WriteLine("String.Equals() Result: {0}", string.Equals(str1, str2));
    }
    public static bool Compare(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        
        if(len1 == len2)
        {
            for(int i=0;i<len1;i++)
                if(str1[i]!=str2[i])
                    return false;
            return true;
        }
        else
            return false;
    }
}