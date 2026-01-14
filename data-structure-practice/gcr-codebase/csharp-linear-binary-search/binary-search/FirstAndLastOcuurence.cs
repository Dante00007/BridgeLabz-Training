using System;

class FirstLastOccurrence
{
    static void Main()
    {
        int[] arr = { 5, 7, 7, 8, 8, 10 };
        int target = 8;

        Console.WriteLine("First Occurrence: " + FindBound(arr, target, true));
        Console.WriteLine("Last Occurrence: " + FindBound(arr, target, false));
    }

    static int FindBound(int[] arr, int target, bool first)
    {
        int low = 0, high = arr.Length - 1, result = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                if (first) high = mid - 1;
                else low = mid + 1;
            }
            else if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return result;
    }
}