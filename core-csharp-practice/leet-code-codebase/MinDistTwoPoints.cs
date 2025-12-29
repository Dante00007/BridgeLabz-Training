
using System;
using System.Linq;
using static System.Math;
using System.Collections.Generic;

class MinDistTwoPoints {
    
    static double Distance(double[] p1, double[] p2){
        double dx = p1[0] - p2[0];
        double dy = p1[1] - p2[1];
        return Sqrt(dx * dx + dy * dy);
    }

    static double StripClosest(double[][] strip, double d){
        double minDist = d;

       
        Array.Sort(strip, (p1, p2) => p1[1].CompareTo(p2[1]));

        for (int i = 0; i < strip.Length; ++i){
            
            for (int j = i + 1; j < strip.Length &&
                    (strip[j][1] - strip[i][1]) < minDist; ++j){
                minDist = Min(minDist, Distance(strip[i], strip[j]));
            }
        }

        return minDist;
    }

    static double MinDistUtil(double[][] points, int left, int right){
        

        if (right - left <= 2){
             if (right - left <= 0) return double.MaxValue;
            return Distance(points[left], points[right - 1]);
        }


        int midIndex = left + (right - left) / 2;
        double midX = points[midIndex][0];

        double dl = MinDistUtil(points, left, midIndex);
        double dr = MinDistUtil(points, midIndex, right);

        double d = Min(dl, dr);

  
        List<double[]> stripList = new List<double[]>();
        for (int i = left; i < right; ++i){
            if (Abs(points[i][0] - midX) < d){
                stripList.Add(points[i]);
            }
        }

        double[][] stripArray = stripList.ToArray();

    
        double stripDist = StripClosest(stripArray, d);

        return Min(d, stripDist);
    }

    static double MinDistance(double[,] points2D){
        int n = points2D.GetLength(0);

        double[][] points = new double[n][];
        for (int i = 0; i < n; i++){
            points[i] = new double[] { points2D[i, 0], points2D[i, 1] };
        }


        Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));

        return MinDistUtil(points, 0, n);
    }

    static void Main(){
        double[,] points = {
            { -1, -2 },
            { 0, 0 },
            { 1, 2 },
            { 2, 3 },
            { 5, 1 },
            { 6, 3 },
            { 8, 0 },
            { 9, 2 }
        };

        double res = MinDistance(points);
        Console.WriteLine(res);
    }
}