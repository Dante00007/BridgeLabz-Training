
class UnionIntersection
{
    static void Main(string[] args)
    {
        HashSet<int> hs1 = new HashSet<int>(){1,2,3};
        HashSet<int> hs2 = new HashSet<int>(){5,4,3};

        HashSet<int> union = new HashSet<int>();
        HashSet<int> intersection = new HashSet<int>();

       
        foreach(int item in hs1 )
        {
            union.Add(item);
        }

        foreach(int item in hs2 )
        {
            union.Add(item);
        }

        foreach(int item in hs1 )
        {
            if(hs2.Contains(item))
            {
                intersection.Add(item);
            }
        }

        Console.WriteLine("Union: {0}", string.Join(", ", union));
        Console.WriteLine("Intersection: {0}", string.Join(", ", intersection));

    }
}