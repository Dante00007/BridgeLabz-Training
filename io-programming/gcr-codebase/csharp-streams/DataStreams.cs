using System;
using System.IO;

class DataStreams
{
    static void Main(string[] args)
    {
        string file = "students.dat";

        try
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                writer.Write(101); 
                writer.Write("John Doe");
                writer.Write(3.85); 
            }

            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                Console.WriteLine($"Roll: {reader.ReadInt32()}");
                Console.WriteLine($"Name: {reader.ReadString()}");
                Console.WriteLine($"GPA: {reader.ReadDouble()}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Binary I/O Error: " + ex.Message);
        }
    }
}