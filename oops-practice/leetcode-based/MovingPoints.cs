using System;
using System.Collections.Generic;
using System.Linq;

public class Fenwick {
    private int n;
    private long[] tree;

    public Fenwick(int n) {
        this.n = n;
        this.tree = new long[n + 1];
    }

    public void Update(int i, long val) {
        for (; i <= n; i += i & -i)
            tree[i] += val;
    }

    public long Query(int i) {
        long sum = 0;
        for (; i > 0; i -= i & -i)
            sum += tree[i];
        return sum;
    }
}

public class Point {
    public int X { get; set; }
    public int V { get; set; }
}

class Program {
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');
        if (input[0] == "") return;
        int n = int.Parse(input[0]);

        Point[] a = new Point[n];
        for (int i = 0; i < n; i++) a[i] = new Point();

        string[] xCoords = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++) a[i].X = int.Parse(xCoords[i]);

        string[] velocities = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < n; i++) a[i].V = int.Parse(velocities[i]);

        Array.Sort(a, (p1, p2) => p1.X.CompareTo(p2.X));

        int[] sortedVelocities = a.Select(p => p.V).Distinct().ToArray();
        Array.Sort(sortedVelocities);

        int GetRank(int v) {
            return Array.BinarySearch(sortedVelocities, v) + 1;
        }

        Fenwick treeCount = new Fenwick(n);
        Fenwick treeSum = new Fenwick(n);

        long totalSum = 0;
        for (int i = 0; i < n; i++) {
            int r = GetRank(a[i].V);

            long count = treeCount.Query(r);
            long sumX = treeSum.Query(r);

            totalSum += (count * a[i].X) - sumX;

            treeCount.Update(r, 1);
            treeSum.Update(r, a[i].X);
        }

        Console.WriteLine(totalSum);
    }
}