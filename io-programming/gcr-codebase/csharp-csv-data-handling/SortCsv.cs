using System;
using System.IO;

class SortCsv
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("Reading CSV file...");
                Console.WriteLine("Name    Department    Salary");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    string name = values[0];
                    string department = values[1];
                    string salary = values[2];

                    Console.WriteLine($"{name}    {department}    {salary}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}