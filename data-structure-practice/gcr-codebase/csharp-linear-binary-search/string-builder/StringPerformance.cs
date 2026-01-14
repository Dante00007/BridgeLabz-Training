using System;
using System.Text;
using System.Diagnostics;

class StringPerformance
{
    static void Main()
    {
        int iterations = 50000;
        
    
        Stopwatch sw = new Stopwatch();
        string str = "";
        
        sw.Start();
        for (int i = 0; i < iterations; i++)
        {
            str += "a"; 
        }
        sw.Stop();
        double stringTime = sw.ElapsedMilliseconds;
        
       
        StringBuilder sb = new StringBuilder();
        sw.Restart();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        sw.Stop();
        double sbTime = sw.ElapsedMilliseconds;

      
        Console.WriteLine($"Iterations: {iterations}");
        Console.WriteLine($"String Concatenation (+): {stringTime} ms");
        Console.WriteLine($"StringBuilder Append: {sbTime} ms");
      
    }
}