class ToggleCase
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        string newStr = "";
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]>='A' && str[i]<='Z')
            {
                newStr += (char)(str[i]+32);
            }else if(str[i]>='a' && str[i]<='z')
            {
                newStr += (char)(str[i]-32);
            }
        }
        Console.WriteLine(newStr);
    }
}