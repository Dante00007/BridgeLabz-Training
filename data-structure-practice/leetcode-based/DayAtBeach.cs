using System;

class DayAtBeach{
    static void Main(){

        int n = int.Parse(Console.ReadLine());
        int[] height = new int[n];
        for(int i=0;i<n;i++){
            height[i] =  int.Parse(Console.ReadLine());
        }

        int[] min_right = new int[n+1];
        min_right[n] = int.MaxValue;
        for(int i=n-1;i>=0;i--)
            min_right[i] = Math.Min(min_right[i+1],height[i]);
            
        int count = 0;
        int maxLeft = int.MinValue;
        
        for(int i = 0;i<n;i++){
            maxLeft = Math.Max(maxLeft,height[i]);
            if(maxLeft<=min_right[i+1])
                count++;
        }
        Console.WriteLine("Number of partition : "+count);
    }
}