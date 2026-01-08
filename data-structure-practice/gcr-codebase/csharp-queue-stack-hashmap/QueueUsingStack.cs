using System;
using System.Collections.Generic;

public class MyQueue 
{
    private Stack<int> st;
    private Stack<int> st2;

    public MyQueue() 
    {
        st = new Stack<int>();
        st2 = new Stack<int>();
    }

    public void Push(int x) 
    {
        if (st.Count == 0) 
        {
            st.Push(x);
            return;
        }

    
        while (st.Count > 0)
        {
            st2.Push(st.Pop());
        }

        st.Push(x);

        while (st2.Count > 0)
        {
            st.Push(st2.Pop());
        }
    }

    public int Pop() 
    {
        
        return st.Pop();
    }

    public int Peek() 
    {
        return st.Peek();
    }

    public bool Empty() 
    {
        return st.Count == 0;
    }
}

class QueueUsingStack
{
    static void Main(string[] args)
    {
        MyQueue queue = new MyQueue();
        queue.Push(1);
        queue.Push(2);
        Console.WriteLine(queue.Peek()); 
        Console.WriteLine(queue.Pop()); 
        Console.WriteLine(queue.Empty()); 
    }
}