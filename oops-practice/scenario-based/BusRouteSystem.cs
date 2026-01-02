/*
*Bus Route Distance Tracker 🚌
Each stop adds distance.
● Ask if the passenger wants to get off at a stop.
● Use a while-loop with a total distance tracker.
● Exit on user confirmation.

*/

class Passenger
{
    private string name;
    private int startStop;
    private int distanceTravelledByBusBeforeThisPassenger;

    public Passenger(string name, int startStop, int distance)
    {
        SetName(name);
        SetStartStop(startStop);
        SetDistanceTravelledByBusBeforeThisPassenger(distance);

    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetStartStop(int startStop)
    {
        this.startStop = startStop;
    }
    public void SetDistanceTravelledByBusBeforeThisPassenger(int distance)
    {
        this.distanceTravelledByBusBeforeThisPassenger = distance;
    }

    public string GetName()
    {
        return name;
    }
    public int GetStartStop()
    {
        return startStop;
    }
    public int GetDistanceTravelledByBusBeforeThisPassenger()
    {
        return distanceTravelledByBusBeforeThisPassenger;
    }

    public void PrintDistanceTravelByPassenger(int distance, int endStop)
    {
        Console.WriteLine("Distance Travelled By {0} from stop {1} to {2} is {3} km \n", name, startStop, endStop, distance - distanceTravelledByBusBeforeThisPassenger);
    }

}
class BusRouteTracker
{
    // making it instance variable so that There can be multiple bus routes in a city.

    private int[] distanceBetweenStops;
    // Bus can carry maximum of ten passengers. its index represents seat.
    private Passenger[] passenger;

    private int distanceTillCurrentStop;
    private int occupiedSeats;

    public BusRouteTracker()
    {
        // Bus route has five stops by default.
        distanceBetweenStops = new int[5] { 10, 20, 30, 40, 50 };

        passenger = new Passenger[10];
        occupiedSeats = 0;
    }
    public BusRouteTracker(int[] distanceBetweenStops)
    {
        this.distanceBetweenStops = distanceBetweenStops;
        passenger = new Passenger[10];
        occupiedSeats = 0;
    }



    public void AddPassenger(int currentStop)
    {
        if (occupiedSeats >= 10)
        {
            Console.WriteLine("Bus is full");
            return;
        }

        Console.WriteLine("===Boarding====");

        // asking how many passengers are getting on at current stop.(assuming all will sit together)
        Console.Write("How many Passengers are getting on at stop {0}?:", currentStop);
        int numToBoard = int.Parse(Console.ReadLine());
        int index = 0;
        while (numToBoard > 0 && index < passenger.Length)
        {
            if (passenger[index] == null)
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                passenger[index++] = new Passenger(name, currentStop, distanceTillCurrentStop);
                occupiedSeats++;
                numToBoard--;
            }
            index++;
        }
        if (numToBoard > 0)
        {
            Console.WriteLine("Sorry remaining passengers cannot board as, Bus is full");
        }
    }

    public void RemovePassenger(int currStop)
    {
        if (occupiedSeats == 0)
        {
            return;
        }
        Console.WriteLine("====Leaving the Bus====");
        for (int i = 0; i < passenger.Length; i++)
        {
            if (passenger[i] == null)
            {
                continue;
            }

            Console.Write("{0}, Do you want left Bus at stop {1}? press Y/N ", passenger[i].GetName(), currStop);
            char choice = Console.ReadLine()[0];
            if (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("\n{0} got down from Bus", passenger[i].GetName());
                passenger[i].PrintDistanceTravelByPassenger(distanceTillCurrentStop, currStop);
                passenger[i] = null;
                occupiedSeats--;
            }

        }
        Console.WriteLine();
        Console.WriteLine("Passengers at stop {0} are {1}", currStop, occupiedSeats);
        Console.WriteLine();
    }
    public void EmptyBus()
    {
        foreach (Passenger p in passenger)
        {
            if (p != null)
            {
                p.PrintDistanceTravelByPassenger(distanceTillCurrentStop, distanceBetweenStops.Length - 1);
            }
        }
    }

    public void StartJourney()
    {
        int currentStop = 0;
        // Journey continues until the last stop
        while (currentStop < distanceBetweenStops.Length - 1)
        {
            Console.WriteLine("\n--- STOP {0} ---", currentStop);

            // 1. Let people off first
            RemovePassenger(currentStop);

            // 2. Let new people on
            if (currentStop < distanceBetweenStops.Length - 1)
                AddPassenger(currentStop);

            // 3. Move to next stop and add distance
            if (currentStop < distanceBetweenStops.Length)
            {
                distanceTillCurrentStop += distanceBetweenStops[currentStop + 1];
                Console.WriteLine("Bus is moving to next stop...");
            }
            Console.WriteLine("Passengers on Bus are {0}", occupiedSeats);
            currentStop++;
        }
        Console.WriteLine("\n All Stops Completed");
        Console.WriteLine("==Empty Bus==");
        EmptyBus();
    }

}

class BusRouteSystem
{
    static void Main()
    {
        int[] busRoute = { 0, 10, 20, 30 };
        BusRouteTracker b = new BusRouteTracker(busRoute);
        b.StartJourney();
    }
}

