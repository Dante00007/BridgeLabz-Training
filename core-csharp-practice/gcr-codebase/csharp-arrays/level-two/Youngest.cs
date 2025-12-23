
class Youngest
{
    static void Main()
    {
        int[] age = new int[3];
        float[] height = new float[3];

        for (int i = 0; i < 3; i++)
        {
            age[i] = Convert.ToInt32(Console.ReadLine());
            height[i] = Convert.ToSingle(Console.ReadLine());
        }

        int minAge = 0;
        float maxHeight = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < minAge)
                minAge = i;
            if (height[i] > maxHeight)
                maxHeight = i;
        }

        if (minAge == 0)
            Console.WriteLine("Amar is the youngest");
        else if (minAge == 1)
            Console.WriteLine("Akbar is the youngest");
        else
            Console.WriteLine("Anthony is the youngest");

        if (maxHeight == 0)
            Console.WriteLine("Amar is the tallest");
        else if (maxHeight == 1)
            Console.WriteLine("Akbar is the tallest");
        else
            Console.WriteLine("Anthony is the tallest");

    }
}
