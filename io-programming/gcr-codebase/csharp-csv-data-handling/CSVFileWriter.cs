
class CSVFileWriter
{
    static void Main(string[] args)
    {
        string filePath = "output.csv";
        List<string[]> data = new List<string[]> {
            new string[] { "John", "Doe", "123 Main St", "123-456-7890" },
            new string[] { "Jane", "Smith", "456 Elm St", "987-654-3210" }
        };

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string[] row in data)
                {
                    writer.WriteLine(string.Join(",", row));
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}