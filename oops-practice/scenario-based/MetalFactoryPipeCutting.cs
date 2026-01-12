class MetalFactoryPipeCutting
{
    private static int[] price = { 1, 5, 8, 9, 10, 17, 17, 20 };
    private int ScenarioA()
    {
        int n = 8;
        int[] dp = new int[n];
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                dp[i] = Math.Max(dp[i], price[j - 1] + dp[i - j]);
            }
        }

        return dp[n];
    }

    private int ScenarioB(int length)
    {
        
        int n = length;
        int[] dp = new int[length];
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                dp[i] = Math.Max(dp[i], price[j - 1] + dp[i - j]);
            }
        }

        return dp[n];
    }
    static void Main(string[] args)
    {
        MetalFactoryPipeCutting obj = new MetalFactoryPipeCutting();
        Console.WriteLine(obj.ScenarioA());

        Console.WriteLine($"The rodlength you want to cut. Length should be less than 8:");
        int customLength = int.Parse(Console.ReadLine());
        Console.WriteLine($"The minimum cost is {obj.ScenarioB(customLength)}");
    }
}