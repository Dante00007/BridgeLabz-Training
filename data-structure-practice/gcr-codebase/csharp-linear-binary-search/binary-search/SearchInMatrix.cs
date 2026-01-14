using System;

class SearchInMatrix
{
    static void Main()
    {
        int[,] matrix = { { 1, 3, 5 }, { 7, 10, 11 }, { 13, 15, 20 } };
        int target = 10;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int low = 0;
        int high = rows * cols - 1;
        bool found = false;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int midVal = matrix[mid / cols, mid % cols];

            if (midVal == target)
            {
                Console.WriteLine("Target found at virtual index: " + mid);
                found = true;
                break;
            }
            if (midVal < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        if (!found) Console.WriteLine("Target not found.");
    }
}