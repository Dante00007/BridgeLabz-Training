;

class SortProductPrice
{
    private void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int tempPivot = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = tempPivot;

        return i + 1;
    }

    private void Print(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        SortProductPrice obj = new SortProductPrice();

        Console.WriteLine("Enter number of Products:");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter Product Prices:");
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting");
        obj.Print(prices);

        obj.QuickSort(prices, 0, n - 1);

        Console.WriteLine("\nAfter Sorting");
        obj.Print(prices);
    }
}