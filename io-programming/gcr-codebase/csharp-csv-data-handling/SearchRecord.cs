
class SearchRecord{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";
        string searchName = "John Doe";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    string name = values[0];
                    string department = values[1];
                    string salary = values[2];

                    if (name == searchName)
                    {
                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Department: {department}");
                        Console.WriteLine($"Salary: {salary}");
                        break;
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

    }
}