/*
    Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the total, average, and the percentage score 
    Hint => 
a.                Take input for the number of students
b.                Write a method to generate random 2-digit scores for Physics, Chemistry, and Math (PCM) for the students and return the scores. This method returns a 2D array with PCM scores for all students
c.                Write a Method to calculate the total, average, and percentages for each student and return a 2D array with the corresponding values. Please ensure to round off the values to 2 Digits using the Math.Round() method. 
d.                Finally, write a Method to display the scorecard of all students with their scores, total, average, and percentage in a tabular format using "\t". 

*/

class Grade
{
    public static int[,] GenerateNumber(int n)
    {
        Random r = new Random();
        int[,] arr = new int[n, 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = r.Next(10, 99);
            }
        }
        return arr;
    }
    public static string[,] CalculateResult(int[,] arr, int n)
    {
        string[,] res = new string[n, 4];
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += arr[i, j];
            }
            double avgValue = Math.Round((double)sum / 3, 2);
            double perValue = Math.Round(((double)sum / 300) * 100, 2);
            res[i, 0] = sum.ToString();
            res[i, 1] = avgValue.ToString();
            res[i, 2] = perValue.ToString();

            if (perValue >= 80) res[i, 3] = "A";
            else if (perValue >= 70) res[i, 3] = "B";
            else if (perValue >= 60) res[i, 3] = "C";
            else if (perValue >= 50) res[i, 3] = "D";
            else if (perValue >= 40) res[i, 3] = "E";
            else res[i, 3] = "R";
        }
        return res;
    }
    public static void DisplayResult(string[,] res)
    {
        Console.WriteLine("\nTotal \tAverage \tPercentage \tGrade");
        for (int i = 0; i < res.GetLength(0); i++)
        {
            Console.WriteLine("{0} \t{1} \t\t{2} \t\t{3}", res[i, 0], res[i, 1], res[i, 2], res[i, 3]);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter Number Of Students");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = GenerateNumber(n);
        string[,] res = CalculateResult(arr, n);

        DisplayResult(res);

    }
}