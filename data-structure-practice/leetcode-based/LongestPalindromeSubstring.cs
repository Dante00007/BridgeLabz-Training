
class Manacher
{
    private int[] p;
    private string ms;

    public Manacher(string s)
    {
        ms = "@";
        foreach (char c in s)
        {
            ms += "#" + c;
        }
        ms += "#$";
        RunManacher();
    }

    private void RunManacher()
    {
        int n = ms.Length;
        p = new int[n];

        int C = 0;
        int R = 0;

        for(int i = 1; i < n - 1; i++)
        {
            int i_mirror = 2 * C - i;
            p[i] = (R > i) ? Math.Min(R - i, p[i_mirror]) : 0;

            while(ms[i+1+p[i]] == ms[i-1-p[i]])
                p[i]++;

            if(i + p[i] > R)
            {
                C = i;
                R = i + p[i];
            }
        }
        
    }

    public int getLongest(int cen,int even)
    {
        int pos = 2 * cen + 2 + even;
        return p[pos];
    }

}

class LongestPalindromeSubstring
{
    public static string LongestPalindrome(string s)
    {
        Manacher manacher = new Manacher(s);

        int maxLength = 1;
        int startLongestSubstring = 0;
        for(int i = 0; i < s.Length; i++)
        {
            int oddLen = manacher.getLongest(i, 0);
            if(oddLen > maxLength)
            {
                maxLength = oddLen;
                startLongestSubstring = i - (maxLength / 2);
            }

            int evenLen = manacher.getLongest(i,1);
            if(evenLen > maxLength)
            {
                maxLength = evenLen;
                startLongestSubstring = i - (maxLength / 2) + 1;
            }
            
        }

        return s.Substring(startLongestSubstring, maxLength);
    }
    public static void Main(string[] args)
    {
        string s = "babad"; // Output: "bab"
        Console.WriteLine($"Longest palindrome substring: {LongestPalindrome(s)}"); // Output: "bab"
    }
}