

class BufferedStream
{
    static void Main(string[] args)
    {
        string sourceFile = "source";
        string destinationFile = "destination";

        if (!File.Exists(sourceFile))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }    

        try
        {
            using (FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream destination = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
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