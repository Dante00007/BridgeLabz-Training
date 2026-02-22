using System;
using System.IO;
using System.Text.RegularExpressions;

class CSVValidator
{
    static void Main(string[] args)
    {
        string filePath = "data.csv";
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        string phonePattern = @"^\d{10}$";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine();
                int lineNumber = 1;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    string[] columns = line.Split(',');

                    if (columns.Length < 3)
                    {
                        Console.WriteLine($"Row {lineNumber}: Invalid number of columns.");
                        continue;
                    }

                    string email = columns[1].Trim();
                    string phone = columns[2].Trim();

                    bool isEmailValid = Regex.IsMatch(email, emailPattern);
                    bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                    if (!isEmailValid || !isPhoneValid)
                    {
                        Console.Write($"Row {lineNumber} Error: ");
                        if (!isEmailValid) Console.Write("[Invalid Email] ");
                        if (!isPhoneValid) Console.Write("[Invalid Phone]");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Row {lineNumber}: Valid");
                    }
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found or could not be read.");
        }
    }
}