
class CSVFileRead
{
    static void Main(string[] args)
    {
        string filePath = "industry_sic.csv";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine("Reading CSV file...");
                Console.WriteLine("SSIC    Description");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    string ssic = values[0];
                    string description = values[1];
                    Console.WriteLine($"{ssic}    {description}");
                    
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}