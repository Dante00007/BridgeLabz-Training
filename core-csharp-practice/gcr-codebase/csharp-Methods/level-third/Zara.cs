/*
  Create a program to find the bonus of 10 employees based on their years of service as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus, along with the old and new salary.
Hint => 
a.                Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
b.                Create a Method to determine the Salary and years of service and return the same. Use the Math.Random() method to determine the 5-digit salary for each employee and also use the random method to determine the years of service. Define 2D Array to save the salary and years of service.
c.                Write a Method to calculate the new salary and bonus based on the logic defined above and return the new 2D Array of the latest salary and bonus amount 
d.                Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary, and the Total Bonus Amount and display it in a Tabular Format
*/

class Zara{
  public static int[,] SalaryAndYearsOfService(int noOfEmployees){
    int[,] arr = new int[noOfEmployees,2];

    for (int i = 0; i < noOfEmployees; i++){
                
      arr[i, 0] = Math.random.Next(10000, 100000); 
      arr[i, 1] = Math.random.Next(0, 11);        
    }
    
    return arr;
  }
  public static int[,] CalculateNewSalaryAndBonus(int[,] data){
    int employees = data.GetLength(0);
    double[,] newSalaryAndBonus = new double[employees, 2];

    for (int i = 0; i < rows; i++)
    {
        double currentSalary = data[i, 0];
        double yearsOfService = data[i, 1];
        double bonusPercentage = (yearsOfService > 5) ? 0.05 : 0.02;

        double bonusAmount = currentSalary * bonusPercentage;
        newSalaryAndBonus[i, 0] = currentSalary + bonusAmount;
        newSalaryAndBonus[i, 1] = bonusAmount;                 
    }
    return newSalaryAndBonus;
  }
  static void Main(){
    Console.Write("Enter number of employees ");
    int noOfEmployees = Convert.ToInt32(Console.ReadLine());
    int[,] salaryAndYearsOfService = SalaryAndYearsOfService(noOfEmployees);
    int[,] newSalaryAndBonus = CalculateNewSalaryAndBonus(data);

    double totalOldSalary = 0, totalNewSalary = 0, totalBonus = 0;

    for (int i = 0; i < rows; i++)
    {
        totalOldSalary += salaryAndYearsOfService[i, 0];
        totalNewSalary += newSalaryAndBonus[i, 0];
        totalBonus += newSalaryAndBonus[i, 1];
    }

    Console.WriteLine("Total Old Salary: " + totalOldSalary);
    Console.WriteLine("Total New Salary: " + totalNewSalary);
    Console.WriteLine("Total Bonus: " + totalBonus);
  
  }
}