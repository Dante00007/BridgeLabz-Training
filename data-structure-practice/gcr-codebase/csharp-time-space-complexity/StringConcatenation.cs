using System;
using System.Text;

class StringConcatenation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of concatenations (e.g., 100000):");
        int n = int.Parse(Console.ReadLine());

        if (n <= 100000)
        {
            DateTime startTime = DateTime.Now;
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "a";
            }
            DateTime endTime = DateTime.Now;
            Console.Write("String (+): ");
            Console.WriteLine((endTime - startTime).TotalMilliseconds + " ms");
        }
        else
        {
            Console.WriteLine("String (+) skipped: N is too large for O(N^2)");
        }

       
        DateTime sbStart = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        string finalResult = sb.ToString();
        DateTime sbEnd = DateTime.Now;
        Console.Write("StringBuilder: ");
        Console.WriteLine((sbEnd - sbStart).TotalMilliseconds + " ms");
    }
}