//codeforces 1165E


class SubarrayProductSum
{
    static void Solve(long[]a, long[] b, int n)
    {
        long MOD = 998244353;
        
        long[] c = new long[n];

        for (int i = 0; i < n; i++)
        {
            c[i] = a[i] * (i + 1L) * (n - i);
        }
        Array.Sort(c);
        
        Array.Sort(b);
        Array.Reverse(b);

        long ans = 0;
        for (int i = 0; i < n; i++)
        {
           
            long term = (c[i] % MOD) * (b[i] % MOD) % MOD;
            ans = (ans + term) % MOD;
        }

        Console.WriteLine(ans);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        

        long[] a = new long[n];
        long[] b = new long[n];

        
        string[] inputA = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++)
        {
            a[i] = long.Parse(inputA[i]);
        }

     
        string[] inputB = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++)
        {
            b[i] = long.Parse(inputB[i]);
        }

        Solve(a, b, n);
    }
}