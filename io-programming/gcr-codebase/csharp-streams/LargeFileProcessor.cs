using System;
using System.IO;

class LargeFileProcessor
{
    static void Main(string[] args)
    {
        string bigFile = "server_logs.txt";

        try
        {
            using (StreamReader reader = new StreamReader(bigFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("error", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}