class CountRows
{
    static void Main(string[] args)
    {
        string filePath = "industry_sic.csv";
        int rowCount = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    rowCount++;
                }
            }
            Console.WriteLine("Number of rows in the file: " + rowCount);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}