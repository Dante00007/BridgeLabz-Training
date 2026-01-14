
using System;
using System.IO;
class UserToFile
{
    static void Main(string[] args)
    {
        string filePath = "user.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
                {
                    string line;
                    while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                    {
                        writer.WriteLine(line);
                    }
                }

            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}