
class UpperCase {
    static void Main()
    {
        string str = "Hello World";
        string upperStr = GetUppercase(str);

        Console.WriteLine("Custom Method Result: {0}" ,upperStr);
        Console.WriteLine("String.ToUpper() Result: {0}" , str.ToUpper()); 
    }
    public static string GetUppercase(string str)
    {
        string ans = "";
        for(int i=0;i<str.Length;i++)
            if((int)str[i] >= 97 && (int)str[i]<=122)
                ans += ((char)((int)str[i]-32));
            else
                ans+= str[i];
        return ans;
    }
 }