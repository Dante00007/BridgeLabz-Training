
class SnakeAndLadder
{
    private static int[] snake = new int[101];
    private static int[] ladder = new int[101];

    static SnakeAndLadder()
    {
        
        ladder[1] = 38;
        ladder[4] = 14;
        ladder[9] = 31;
        ladder[21] = 42;
        ladder[28] = 84;
        ladder[36] = 44;
        ladder[51] = 67;
        ladder[71] = 91;
        ladder[80] = 100;


        snake[16] = 6;
        snake[47] = 26;
        snake[49] = 11;
        snake[56] = 53;
        snake[62] = 19;
        snake[64] = 60;
        snake[87] = 24;
        snake[93] = 73;
        snake[95] = 75;
        snake[98] = 78;
    }
    
    public static int RollDice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    public static int CheckSnakeOrLadder(int currentPosition)
    {
        if (snake[currentPosition] != 0)
        {
            Console.WriteLine("You got bitten by a snake and fallen down to {0} from {1}", snake[currentPosition], currentPosition);
            return snake[currentPosition];
        }
        else if (ladder[currentPosition] != 0)
        {
            Console.WriteLine("You climbed up a ladder from {0} to {1}", currentPosition,ladder[currentPosition]);
            return ladder[currentPosition];
        }else{
            return currentPosition;
        }
    }

    public static int CheckPosition(int currentPosition, int moveFurther)
    {
        if (currentPosition + moveFurther > 100)
            return currentPosition;

        return currentPosition + moveFurther;
    }
   
    public void Game(){
        Console.WriteLine("Welcome to the Snake and Ladder game");
        
        int playerCount = 0;
        do
        {
            Console.Write("Enter number of players: between 2 and 4: ");
            playerCount = Convert.ToInt32(Console.ReadLine());
        }while(playerCount<2 || playerCount>4);


        string[] playerNames = new string[playerCount]; 
        for (int i = 0; i < playerCount; i++)
        {
            Console.WriteLine($"Player{i + 1}: Enter your name: ");
            playerNames[i] = Console.ReadLine();
        }

        int[] position = new int[playerCount];
        string[] pathOfPlayers = new string[playerCount];
        for (int i = 0; i < playerCount; i++)
        {
            pathOfPlayers[i] = "0";
        }
        while (true)
        {
            for (int currentPlayerIndex = 0; currentPlayerIndex < playerCount; currentPlayerIndex++)
            {
                Console.Write($"\n{playerNames[currentPlayerIndex]} press enter to roll a dice.");
                Console.ReadLine();
                int moveBy = RollDice();
                Console.WriteLine($"{playerNames[currentPlayerIndex]} rolled a {moveBy}");
                position[currentPlayerIndex] = CheckPosition(position[currentPlayerIndex],moveBy);
                if(position[currentPlayerIndex]==100){
                    Console.WriteLine($"{playerNames[currentPlayerIndex]} won the game!");
                    return;
                }
                position[currentPlayerIndex] = CheckSnakeOrLadder(position[currentPlayerIndex]);

                pathOfPlayers[currentPlayerIndex] += "->"+position[currentPlayerIndex].ToString();
                Console.WriteLine($"{playerNames[currentPlayerIndex]} way {pathOfPlayers[currentPlayerIndex]}");
                
            }
        }
    }
    
    static void Main(){
        SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
        snakeAndLadder.Game();
    }
}
