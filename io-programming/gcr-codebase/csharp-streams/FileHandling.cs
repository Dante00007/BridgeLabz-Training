

class FileHandling
{
    static void Main(string[] args)
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(sourceFile))
            {
                using (StreamWriter writer = new StreamWriter(destinationFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
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