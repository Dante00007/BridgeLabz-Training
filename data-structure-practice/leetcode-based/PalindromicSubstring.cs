
// Number of Palindromic Substrings in string
class PalindromicSubstring
{
    
    public  int LongestPalindrome(string s)
    {
        int n = s.Length;
        int count = n;

        for(int i = 0; i < n; i++)
        {
            int left = i - 1;
            int right = i + 1;

            while(left>=0 && right < n)
            {
                if(s[left] != s[right])
                    break;
                
                count++;
                left--;
                right++;
            }
        }

        for(int i = 0; i < n ; i++)
        {
            int left = i;
            int right = i+1;
            while(left>=0 && right < n)
            {
                if(s[left] != s[right])
                    break;
                
                count++;
                left--;
                right++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        string s = "aaa"; //6
        PalindromicSubstring obj = new PalindromicSubstring();
        Console.WriteLine(obj.LongestPalindrome(s));

        s = "abc"; //3
        Console.WriteLine(obj.LongestPalindrome(s));
    }
}