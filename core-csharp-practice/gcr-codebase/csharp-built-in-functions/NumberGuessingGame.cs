class NumberGuessingGame
{
    static void Main(string[] args)
    {
        Game();  
    }
    static void Game()
    {
        int min = 1;
        int max = 100;


        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Think  a number between 1 and 100. I am going to guess it.");
        Console.WriteLine("If the number is higher than the one you are thinking of, type 'high'.");
        Console.WriteLine("If the number is lower than the one you are thinking of, type 'low'.");
        Console.WriteLine("If my guess is correct, type 'correct'.");
        Console.WriteLine("Let's begin!");

        while (true)
        {
            int guess = GenerateRandomNumber(min, max);
            Console.WriteLine("My guess is: {0}", guess);

            string feedback = ReceiveFeedback();

            if (feedback == "correct")
            {
                Console.WriteLine("I guessed the number and it is {0}", guess);
                return ;
            }
            else if (feedback == "high")
            {
                max = guess - 1;
            }
            else if (feedback == "low")
            {
                min = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
            }
        }   
    }
    static int GenerateRandomNumber(int min, int max)
    {
        return new Random().Next(min, max + 1);
    }
    static string ReceiveFeedback()
    {
        Console.Write("Enter your feedback: ");
        return Console.ReadLine();
    }
}
