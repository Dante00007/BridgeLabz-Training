

class RadixSort
{

    long GetMax(long[] aadhaar)
    {
        long max = 0;
        for (int i = 0; i < aadhaar.Length; i++)
        {
            if (aadhaar[i] > max)
            {
                max = aadhaar[i];
            }
        }
        return max;
    }

    public void CountingSort(long[] aadhaar, long exp)
    {
        int n = aadhaar.Length;
        long[] ans = new long[n];
        int[] count = new int[10];

        for (int i = 0; i < aadhaar.Length; i++)
        {
            int digit = (int)(aadhaar[i] / exp) % 10;
            count[digit]++;
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)(aadhaar[i] / exp) % 10;
            ans[count[digit] - 1] = aadhaar[i];
            count[digit]--;
        }

        for (int i = 0; i < n; i++)
        {
            aadhaar[i] = ans[i];
        } 
    }
    public void Sort(long[] aadhaar)
    {
        long max = GetMax(aadhaar);
        long exp = 1;
        while (max / exp > 0)
        {
            CountingSort(aadhaar, exp);
            exp *= 10;
        }
    }

    static void Main(string[] args)
    {
        long[] aadhaar = new long[10];

        for (int i = 0; i < aadhaar.Length; i++)
        {
            aadhaar[i] = Convert.ToInt64(Console.ReadLine());
        }
        RadixSort obj = new RadixSort();
        obj.Sort(aadhaar);

        for (int i = 0; i < aadhaar.Length; i++)
        {
            Console.Write(aadhaar[i]+" ");
        }
    }

}