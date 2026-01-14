using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 1 };
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] < arr[mid + 1])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Peak element index: " + low);
    }
}