using System;
using System.IO;
using System.Text;

class ByteToCharStream
{
    static void Main()
    {
        string filePath = "data.bin";

    
        byte[] bytes = Encoding.UTF8.GetBytes("Hello, this was a byte stream!");
        File.WriteAllBytes(filePath, bytes);

        try
        {
           
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
            
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    Console.WriteLine("Reading Character Stream:");
                    
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}