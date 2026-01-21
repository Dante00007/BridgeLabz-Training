class SymmetricDifference
{
    static void Main(string[] args)
    {
        HashSet<int> hs1 = new HashSet<int>(){1,2,3};
        HashSet<int> hs2 = new HashSet<int>(){5,4,3};

        HashSet<int> differnece = new HashSet<int>();
    

       
        foreach(int item in hs1 )
        {
            if(!hs2.Contains(item))
            {
                differnece.Add(item);
            }
        }

        foreach(int item in hs2 )
        {
            if(!hs1.Contains(item))
            {
                differnece.Add(item);
            }
        }

        Console.WriteLine("Differnce: {0}", string.Join(", ", differnece));
    }
}