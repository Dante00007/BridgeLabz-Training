using System;

class SortStudentAges
{
    private void CountingSort(int[] arr)
    {
        int n = arr.Length;
        if (n == 0) return;

      
        int min = arr[0];
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }

        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[n];

      
        for (int i = 0; i < n; i++)
            count[arr[i] - min]++;

        
        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    private void Print(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        SortStudentAges obj = new SortStudentAges();

        Console.WriteLine("Enter number of Students:");
        int n = int.Parse(Console.ReadLine());
        int[] ages = new int[n];

        Console.WriteLine("Enter Student Ages (e.g., 10-18):");
        for (int i = 0; i < n; i++)
            ages[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting");
        obj.Print(ages);

        obj.CountingSort(ages);

        Console.WriteLine("\nAfter Sorting");
        obj.Print(ages);
    }
}