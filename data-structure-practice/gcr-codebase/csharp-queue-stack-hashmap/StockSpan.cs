using System;
using System.Collections.Generic;

public class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (st.Count > 0 && prices[st.Peek()] <= prices[i])
            {
                st.Pop();
            }
            if (st.Count == 0)
            {
                span[i] = i + 1;
            }
            else
            {
                span[i] = i - st.Peek();
            }

            st.Push(i);
        }

        return span;
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] result = CalculateSpan(prices);

        Console.WriteLine("Prices: " + string.Join(", ", prices));
        Console.WriteLine("Spans:  " + string.Join(", ", result));
    }
}