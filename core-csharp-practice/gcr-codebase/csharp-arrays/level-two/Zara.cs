/*
Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.
Hint => 
Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
Define a double array to save salary and years of service for each of the 10 employees
Also define a double array to save the new salary and the bonus amount as well as variables to save the total bonus, total old salary, and new salary
Define a loop to take input from the user. If salary or year of service is an invalid number then ask the user to enter again. Note in this case you will have to decrement the index counter
Define another loop to calculate the bonus of 10 employees based on their years of service. Save the bonus in the array, compute the new salary, and save in the array. Also, the total bonus and total old and new salary can be calculated in the loop
Print the total bonus payout as well as the total old and new salary of all the employees
*/

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