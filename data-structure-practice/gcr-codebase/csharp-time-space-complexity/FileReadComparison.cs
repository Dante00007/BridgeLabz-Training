using System;
using System.IO;
using System.Text;

class FileReadComparison
{
    static void Main()
    {
        string filePath = "largefile.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        DateTime start1 = DateTime.Now;
        ReadWithStreamReader(filePath);
        DateTime end1 = DateTime.Now;
        Console.WriteLine("StreamReader (Char-by-Char): " + (end1 - start1).TotalMilliseconds + " ms");

        DateTime start2 = DateTime.Now;
        ReadWithFileStream(filePath);
        DateTime end2 = DateTime.Now;
        Console.WriteLine("FileStream (Buffered Bytes): " + (end2 - start2).TotalMilliseconds + " ms");
    }

    static void ReadWithStreamReader(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.Read() != -1);
           
        }
    }

    static void ReadWithFileStream(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
               
                string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
        }
    }
}