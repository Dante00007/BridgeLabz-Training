

class Zara
{
    static void Main()
    {
        double[] oldSal = new double[10];
        double[] yrs = new double[10];
        double[] bon = new double[10];
        double[] newSal = new double[10];

        double totBon = 0;
        double totOldSal = 0;
        double totNewSal = 0;

        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("Enter Salary");
            oldSal[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Years of Service");
            yrs[i] = Convert.ToDouble(Console.ReadLine());
            if (oldSal[i] < 0 || yrs[i] < 0)
                continue;
            i++;
        }
        for (int j = 0; j < 10; j++)
        {
            totOldSal += oldSal[j];
            if (yrs[j] > 5)
                bon[j] = oldSal[j] * 0.05;
            else
                bon[j] = oldSal[j] * 0.02;
            newSal[j] += oldSal[j] + bon[j];

            totBon += bon[j];
            totNewSal += newSal[j];
        }
        Console.WriteLine("Total Bonus Payout :{0}", totBon);
        Console.WriteLine("Total Old Salary : {0} ", totOldSal);
        Console.WriteLine("Total New Salary : {0} ", totNewSal);
    }
}