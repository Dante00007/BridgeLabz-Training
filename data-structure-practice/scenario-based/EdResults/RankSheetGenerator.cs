
using System.Security.Cryptography.X509Certificates;

class RankSheetGenerator
{

    public static int[] Merge(int[] arr1, int[] arr2)
    {
        int[] res = new int[arr1.Length + arr2.Length];

        int i = 0, j = 0, k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                res[k++] = arr1[i++];
            }
            else
            {
                res[k++] = arr2[j++];
            }
        }


        while (i < arr1.Length)
        {
            res[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            res[k++] = arr2[j++];
        }

        return res;
    }


    static int[] MergeSort(int[][] studentsMarks)
    {
        int[] temp = studentsMarks[0];

        for (int i = 1; i < studentsMarks.GetLength(0); i++)
        {
            temp = Merge(temp, studentsMarks[i]);
        }

        return temp;
    }
    static void GetRankSheet(int[] arr)
    {
        int n =arr.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine($" {n - i}  :  {arr[i]}");
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter number of Districts: ");
        int districts = int.Parse(Console.ReadLine());
        Random random = new Random();
        int[][] studentsMarks = new int[districts][];
        for (int i = 0; i < districts; i++)
        {
            Console.Write("\nEnter number of students in district " + (i + 1) + ": ");
            int students = int.Parse(Console.ReadLine());

            studentsMarks[i] = new int[students];
            for (int j = 0; j < students; j++)
            {
                Console.Write("Enter marks of student " + (j + 1) + " in district " + (i + 1) + ": ");
                studentsMarks[i][j] = int.Parse(Console.ReadLine());

            }
        }

        int[] ans = MergeSort(studentsMarks);

        GetRankSheet(ans);

    }
}