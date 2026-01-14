using System;

class FindRotation
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }

        Console.WriteLine("Smallest element index: " + low);
    }
}