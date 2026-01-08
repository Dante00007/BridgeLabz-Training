using System;
using System.Collections.Generic;

public class CircularTour
{
    public static int FindStartingPoint(int[] gas, int[] cost)
    {
        int n = gas.Length;
        Queue<int> tour = new Queue<int>();
        int currentPetrol = 0;
        int start = 0;
        int visitedCount = 0;

        while (visitedCount < 2 * n && start < n && tour.Count < n)
        {
            int index = visitedCount % n;

            tour.Enqueue(index);
            currentPetrol += gas[index] - cost[index];
            visitedCount++;

            while (currentPetrol < 0 && tour.Count > 0)
            {
                int removedIndex = tour.Dequeue();
                currentPetrol -= (gas[removedIndex] - cost[removedIndex]);
                start++;
                if (start >= n) return -1;
            }
        }

        return (tour.Count == n) ? start : -1;
    }

    public static void Main()
    {
        int[] gas = { 1, 2, 3, 4, 5 };
        int[] cost = { 3, 4, 5, 1, 2 };

        int result = FindStartingPoint(gas, cost);

        if (result != -1)
        {
            Console.WriteLine("Start at Index: " + result);
        }
        else
        {
            Console.WriteLine("No circular tour possible.");
        }
    }
}