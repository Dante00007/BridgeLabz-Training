class SetEquals
{
  
    static void Main(string[] args)
    {
        HashSet<int> hs1 = new HashSet<int>(){1,2,3};
        HashSet<int> hs2 = new HashSet<int>(){3,2,1};
        
        if(hs1.SetEquals(hs2)) Console.WriteLine("Equal");
        else Console.WriteLine("Not Equal");

    }
}