using System;
using System.IO;

class UserInputToFile
{
    static void Main(string[] args)
    {
        string filePath = "user_info.txt";

        try
        {
       
            using (StreamReader consoleReader = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.Write("Enter Name: ");
                string name = consoleReader.ReadLine();
                
                Console.Write("Enter Age: ");
                string age = consoleReader.ReadLine();
                
                Console.Write("Enter Favorite Language: ");
                string language = consoleReader.ReadLine();

                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Language: {language}");
            }
            Console.WriteLine("Information saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}