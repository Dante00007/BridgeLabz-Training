
class CustomFurnitureManufacturing
{
    private int[] ModifyArray(int[] cuts, int rodLength)
    {
        int n = cuts.Length;

        int[] modifiedCuts = new int[n + 2];
        modifiedCuts[0] = 0;
        modifiedCuts[n + 1] = rodLength;

        for (int i = 0; i < n; i++)
        {
            modifiedCuts[i + 1] = cuts[i];
        } 
        Array.Sort(modifiedCuts);
        return modifiedCuts;
    }
    private int helper(int start, int end, int[] modifiedCuts)
    {
        if (start > end)
        {
            return 0;
        }

        int maxi = Int32.MinValue;
        for (int i = start; i <= end; i++)
        {
            int cost = modifiedCuts[end + 1] - modifiedCuts[start - 1] + helper(start, i - 1, modifiedCuts) + helper(i + 1, end, modifiedCuts);
            maxi = Math.Max(mini, cost);
        }
        return maxi;
    }
    public void ScenarioA()
    {
        int rodLength = 8;
        int[] cuts = { 1, 3, 4, 5 };

        int[] modifiedCuts = ModifyArray(cuts, rodLength);

        Console.WriteLine(helper(1, cuts.Length, modifiedCuts));

    }
    public void ScenarioB(int length)
    {
        int rodLength = length;
        int[] cuts = { 1, 3, 4, 5 };

        int[] modifiedCuts = ModifyArray(cuts, rodLength);

        Console.WriteLine(helper(1, cuts.Length, modifiedCuts));
    }
    static void Main()
    {
        CustomFurnitureManufacturing obj = new CustomFurnitureManufacturing();
        obj.ScenarioA();

        Console.WriteLine("Enter the length of the pipe");
        int customLength = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number of cuts you want to do and it should be one less than {customLength}:");
        int[] cuts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Write("The minimum cost is ");
        obj.ScenarioB(customLength);

        obj.ScenarioC();

    }
}