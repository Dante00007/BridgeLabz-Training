using System;
using System.IO;

class ImageToByteArray
{
    static void Main(string[] args)
    {
        string sourceImage = "input.jpg"; 
        string targetImage = "output.jpg";

        if (!File.Exists(sourceImage)) return;

        try
        {
            byte[] imageBytes = File.ReadAllBytes(sourceImage);

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                byte[] processedBytes = ms.ToArray();
                File.WriteAllBytes(targetImage, processedBytes);
            }
            Console.WriteLine("Image conversion and verification complete.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}