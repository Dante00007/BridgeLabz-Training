
using System;

class FirstNegative
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] strArr = Console.ReadLine().Split(' ');
        int[] arr = new int[n];
        for (int i = 0; i < n; ++i)
            arr[i] = Convert.ToInt32(strArr[i]);

        int firstNegative = -1;
        for (int i = 0; i < n; ++i)
        {
            if (arr[i] < 0)
            {
                firstNegative = i;
                break;
            }
        }

        Console.WriteLine(firstNegative);
    }
}