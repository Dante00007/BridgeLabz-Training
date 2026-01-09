using System;

interface ITrackable
{
    void Start();
    void Stop();
}

class UserProfile
{
    // Changed to public so Tracker can access them
    public string Name { get; set; }
    public double Weight { get; set; }
}

public abstract class Workout : ITrackable
{
    // Use 'protected' so child classes can set these values
    protected string Date { get; set; }
    protected int Duration { get; set; }

    public void Start() {
        Console.WriteLine("Workout started...");
    }
    public void Stop(){
        Console.WriteLine("Workout stopped.");
    }
    public abstract void DisplayDetails();
}

public class CardioWorkout : Workout
{
    private double Distance;

    public CardioWorkout(string date, int duration, double distance)
    {
        this.Date = date;       // Fixed typo from Dtae
        this.Duration = duration;
        this.Distance = distance;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"[Cardio] Date: {Date}, Duration: {Duration} mins, Distance: {Distance}km");
    }
}

public class StrengthWorkout : Workout
{
    private int Sets;
    private int Reps;
    
    public StrengthWorkout(string date, int duration, int sets, int reps)
    {
        this.Date = date;
        this.Duration = duration;
        this.Sets = sets;
        this.Reps = reps;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"[Strength] Date: {Date}, Duration: {Duration} mins, Sets: {Sets}, Reps: {Reps}");
    }
}

public class Tracker
{
    private UserProfile user;
    private Workout[] workouts;
    private int workoutCount = 0;

    public void CreateUser()
    {
        user = new UserProfile(); // Fixed class name
        Console.Write("Enter your name: ");
        user.Name = Console.ReadLine();
        Console.Write("Enter your weight: ");
        user.Weight = double.Parse(Console.ReadLine());
        
        Console.Write("Number of Workouts you want to add: ");
        int capacity = int.Parse(Console.ReadLine());
        workouts = new Workout[capacity];
        
        Console.WriteLine($"Welcome, {user.Name}!");
    }

    public void AddWorkout()
    {
        if (workouts == null) {
            Console.WriteLine("Error: Please create a user first!");
            return;
        }

        if (workoutCount >= workouts.Length) {
            Console.WriteLine("Tracker storage full!");
            return;
        }

        Console.WriteLine("\n1. Cardio\n2. Strength");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter date (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        Console.Write("Enter duration in minutes: ");
        int duration = int.Parse(Console.ReadLine());

        if(choice == 1){
            Console.Write("Enter distance in kilometers: ");
            double distance = double.Parse(Console.ReadLine());
            workouts[workoutCount] = new CardioWorkout(date, duration, distance);
        }
        else if(choice == 2){
            Console.Write("Enter number of sets: ");
            int sets = int.Parse(Console.ReadLine());
            Console.Write("Enter reps per set: ");
            int reps = int.Parse(Console.ReadLine());
            workouts[workoutCount] = new StrengthWorkout(date, duration, sets, reps);
        }
        
        workoutCount++;
        Console.WriteLine("Workout added successfully!");
    }

    public void ShowSummary()
    {
        if (user == null) {
            Console.WriteLine("No user profile found.");
            return;
        }
        Console.WriteLine($"\n--- Activity Report for {user.Name} ({user.Weight}kg) ---");
        for (int i = 0; i < workoutCount; i++)
        {
            workouts[i].DisplayDetails();
        }
    }
}

class FitnessTracker
{
    static void Main()
    {
        Tracker myTracker = new Tracker(); 
        while(true){
            Console.WriteLine("\n--------- Menu ---------");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Add Workout");
            Console.WriteLine("3. Show Summary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            
            if (!int.TryParse(Console.ReadLine(), out int ch)) continue;

            switch(ch){
                case 1: myTracker.CreateUser(); break;
                case 2: myTracker.AddWorkout(); break;
                case 3: myTracker.ShowSummary(); break;
                case 4: return;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }
}