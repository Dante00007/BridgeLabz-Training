

class NotFound
{
    static void Main(string[] args)
    {
        string source = "source.txt";

        try
        {
           
            using(StreamReader reader = new StreamReader(source))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }catch(IOException e)
        {
            Console.WriteLine("File not found");
        }
    }
}