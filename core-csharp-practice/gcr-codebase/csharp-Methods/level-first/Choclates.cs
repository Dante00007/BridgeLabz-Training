class Choclates
{
    public static int[] FindChoclates(int numberOfchocolates, int numberOfChildren)
    {
        int[] result = new int[2];
        result[0] = numberOfchocolates / numberOfChildren;
        result[1] = numberOfchocolates % numberOfChildren;
        return result;
    }
    static void Main()
    {
        int numberOfchocolates = Convert.ToInt32(Console.ReadLine());
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int []result = FindChoclates(numberOfchocolates, numberOfChildren);
        Console.WriteLine("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}", result[0], result[1]);
    }
}