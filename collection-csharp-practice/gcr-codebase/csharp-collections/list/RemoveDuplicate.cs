class RemoveDuplicate
{
    static void PrintList(List<int> l)
    {
        foreach (int i in l)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
    static List<int> RemoveDuplicateList(List<int> l)
    {
        List<int> unique = new List<int>();
        foreach (int i in l)
        {
            if (!unique.Contains(i))
            {
                unique.Add(i);
            }
        }
        return unique;
    }
    static void Main(string[] args)
    {
        List<int> l = new List<int>();
        l.Add(1);
        l.Add(2);
        l.Add(3);
        l.Add(1);
        l.Add(2);
        l.Add(3);
        

        PrintList(l);

        l = RemoveDuplicateList(l);

        PrintList(l);
    }
}