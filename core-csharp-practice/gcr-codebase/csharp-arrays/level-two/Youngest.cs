/*
Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
Hint => 
Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
Loop through the array and find the youngest of the 3 friends and the tallest of the 3 friends
Finally display the youngest and tallest of the 3 friends
*/

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
