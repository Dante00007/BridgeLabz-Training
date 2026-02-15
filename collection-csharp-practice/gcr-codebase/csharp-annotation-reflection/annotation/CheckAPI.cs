class LegacyAPI
{
    [Obsolete("Use NewFeature instead",true)]
    public void OldFeature()
    {
        Console.WriteLine("Legacy API");
    }

    public void NewFeature()
    {
        Console.WriteLine("New API");
    }
}

class CheckAPI
{
    static void Main(string[] args)
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();
        api.NewFeature();
    }
}