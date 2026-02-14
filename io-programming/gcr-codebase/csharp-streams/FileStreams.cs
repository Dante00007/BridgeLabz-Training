using System;
using System.IO;

class FilterStreams
{
    static void Main(string[] args)
    {
        string source = "upper.txt";
        string dest = "lower.txt";

        try
        {
            using (FileStream fsIn = new FileStream(source, FileMode.Open))
            using (BufferedStream bsIn = new BufferedStream(fsIn))
            using (StreamReader reader = new StreamReader(bsIn))
            using (StreamWriter writer = new StreamWriter(dest))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}