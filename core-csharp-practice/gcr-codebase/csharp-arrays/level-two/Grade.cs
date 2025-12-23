

class Grade
{
    static void Main()
    {

        Console.WriteLine("Enter Number Of Students");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] marks = new int[n];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        int i = 0;
        while (i < n)
        {
            Console.WriteLine("Enter Marks For Student {0}", i + 1);
            Console.Write("Physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());
            if (physics < 0)
            {
                Console.WriteLine("Marks Cannot be Negative Enter Again");
                continue;
            }
            Console.Write("Chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            if (chemistry < 0)
            {
                Console.WriteLine("Marks Cannot be Negative Enter Again");
                continue;
            }
            Console.Write("Maths : ");
            int math = Convert.ToInt32(Console.ReadLine());
            if (math < 0)
            {
                Console.WriteLine("Marks Cannot be Negative Enter Again");
                continue;
            }
            marks[i] = physics + chemistry + math;
          
            i++;
        }

        for (int j = 0; j < n; j++)
        {
            percentage[j] = (double)(marks[j] / 3);
        }
        for (int j = 0; j < n; j++)
        {

            if (percentage[j] >= 80)
                grade[j] = 'A';
            else if (percentage[j] >= 70 && percentage[j] <= 79)
                grade[j] = 'B';
            else if (percentage[j] >= 60 && percentage[j] <= 69)
                grade[j] = 'C';
            else if (percentage[j] >= 50 && percentage[j] <= 59)
                grade[j] = 'D';
            else if (percentage[j] >= 40 && percentage[j] <= 49)
                grade[j] = 'E';
            else
                grade[j] = 'R';
        }

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("\nStudent {0}", j + 1);
            Console.WriteLine("Marks : {0}", marks[j]);
            Console.WriteLine("Percentage : {0}", percentage[j]);
            Console.WriteLine("Grade : {0}", grade[j]);
        }
    }
}