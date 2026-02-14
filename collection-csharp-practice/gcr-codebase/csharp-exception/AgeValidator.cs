class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class AgeValidator
{
    static void ValidateAge(int age)
    {
        if (age < 18) throw new InvalidAgeException("Age must be 18 or above");
    }

    static void Main(string[] args)
    {
        try
        {
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}