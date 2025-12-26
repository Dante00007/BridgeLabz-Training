
class LowerCase {
    static void Main() {
    
        string str = "HELLO WORLD";
    
        Console.WriteLine("Custom Method Result: {0}" ,GetLowercase(str));
        Console.WriteLine("Built-in Method Result: {0}",str.ToLower());
       
    }
    public static string GetLowercase(string str) {
        string ans = "";
         for(int i=0;i<str.Length;i++) {
            if(str[i]>=65 && str[i]<=90)
                ans += (char)(str[i]+32);
            else
                ans += str[i];
        }
        return ans;
    }
}