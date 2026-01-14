using System;
using System.IO;

class FileReadExample
{
    static void Main()
    {
        string filePath = "File.txt";

        if (File.Exists(filePath))
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }
    }
}