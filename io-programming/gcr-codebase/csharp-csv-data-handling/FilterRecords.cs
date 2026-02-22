
class FilterRecords
{
    static void Main(string[] args)
    {
        string filePath = "marks.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("Reading CSV file...");
                Console.WriteLine("Name    Marks");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    string name = values[0];
                    int marks = int.Parse(values[1]);
                    if (marks > 80)
                    {
                        Console.WriteLine($"{name}    {marks}");
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