
using System.Text;

// Codeforces round div 2 - B
class PashaAndString
{

    static string Solve(string s, int[] arr)
    {
        int n = s.Length;
        int[] diff = new int[(n / 2 + 1)];

        for (int i = 0; i < arr.Length; i++)
        {
            diff[arr[i]] ^= 1;
        }
        StringBuilder sb = new StringBuilder(s);
        for (int i = 1; i <= n / 2; i++)
        {
            diff[i] ^= diff[i - 1];
            if (diff[i] == 1)
            {
                char ch = sb[i - 1];
                sb[i - 1] = sb[n - i];
                sb[n - i] = ch;
            }
        }
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        //String is 1-based index
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        Console.Write("Enter number of days: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the indexs you want to revese string: ");
        int[] arr = new int[m];
        for (int i = 0; i < m; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Solve(s, arr));
    }

}