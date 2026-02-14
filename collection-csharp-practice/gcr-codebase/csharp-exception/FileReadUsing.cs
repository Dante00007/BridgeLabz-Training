class FileReadUsing
{
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}