using System;

class SortExamScores
{
    private void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
           
            int minIndex = i;

            
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    private void Print(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        SortExamScores obj = new SortExamScores();

        Console.WriteLine("Enter number of Students:");
        int n = int.Parse(Console.ReadLine());
        
        int[] scores = new int[n];
        Console.WriteLine("Enter Exam Scores:");
        for (int i = 0; i < n; i++)
            scores[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting:");
        obj.Print(scores);

        obj.SelectionSort(scores);

        Console.WriteLine("\nAfter Sorting:");
        obj.Print(scores);
    }
}