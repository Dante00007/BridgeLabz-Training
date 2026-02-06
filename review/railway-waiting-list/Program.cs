
class Passenger
{
    private int id;
    private int age;
    public Passenger(int id, int age)
    {
        this.age = age;
        this.id = id;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public override string ToString()
    {
        return $"Id: {Id}  Age:{Age}";
    }

}


class Heap
{
    Passenger[] waiters;
    int size;
    int current;
    public Heap(int size)
    {
        this.size = size;
        this.current = 0;
        waiters = new Passenger[size];
    }

    private void Swap(int index1, int index2)
    {
        Passenger temp = waiters[index1];
        waiters[index1] = waiters[index2];
        waiters[index2] = temp;
    }
    public void Add(Passenger p)
    {
        if (current == waiters.Length)
        {
            Console.WriteLine($"Already {current} passengers in waiting");
            return;
        }
        waiters[current] = p;
        current++;
        Console.WriteLine($"Passengers {p} , you are in waiting list");
        Upheapify();
    }

    private void Upheapify()
    {
        int childIndex = current - 1;
        int parentIndex = (childIndex - 1) / 2;

        while (parentIndex >= 0 && waiters[childIndex].Age >= 50 && waiters[childIndex].Age > waiters[parentIndex].Age)
        {
            Swap(childIndex, parentIndex);
            childIndex = parentIndex;
            parentIndex = (childIndex - 1) / 2;
        }
        Array.Sort(waiters, childIndex + 1, current - childIndex - 1, Comparer<Passenger>.Create((p1, p2) => p1.Id.CompareTo(p2.Id)));
    }

    public Passenger Remove()
    {

        if (current == 0)
        {
            Console.WriteLine("No passengers in waiting list");
            return null;
        }

        Passenger p = waiters[0];

        Swap(0, current - 1);
        waiters[current - 1] = null;
        current--;
        Downheapify(0);
        return p;
    }

    private void Downheapify(int parentIndex)
    {
        if (parentIndex >= current) return;

        int leftChild = 2 * parentIndex + 1;
        int rightChild = 2 * parentIndex + 2;

        int swapIndex = -1;


        if (rightChild < current && (waiters[parentIndex].Age < 50 || waiters[parentIndex].Id > waiters[rightChild].Id))
        {
            Swap(rightChild, parentIndex);
            swapIndex = rightChild;
        }
        else if (leftChild < current && (waiters[parentIndex].Age < 50 || waiters[parentIndex].Id > waiters[leftChild].Id))
        {
            Swap(leftChild, parentIndex);
            swapIndex = leftChild;
        }
        else
        {
            return;
        }
        Downheapify(swapIndex);
    }

    public void DisplayP()
    {
        Console.WriteLine("\n-----People in waiting list----------");
        for (int i = 0; i < current; i++) Console.WriteLine(waiters[i]);
        Console.WriteLine();
    }
}

class RailwaySystem
{
    private Passenger[] number_of_seats;

    private Heap waitingList;
    private int size;
    public RailwaySystem(int size)
    {
        this.size = size;
        waitingList = new Heap(5);
        number_of_seats = new Passenger[size];
    }

    public void AddPassenger(Passenger p)
    {
        for (int i = 0; i < size; i++)
        {
            if (number_of_seats[i] == null)
            {
                number_of_seats[i] = p;
                Console.WriteLine($"{p} ,your seat is confirmed");
                return;
            }
        }

        waitingList.Add(p);
    }

    public void Cancel(Passenger p)
    {
        for (int i = 0; i < size; i++)
        {
            if (number_of_seats[i] != null && p.Id == number_of_seats[i].Id)
            {
                Console.WriteLine($"{p} , your seat is canceled");
                number_of_seats[i] = waitingList.Remove();
                if (number_of_seats[i] != null)
                {
                    Console.WriteLine($"{number_of_seats[i]}, now you are removed from waiting list and your seat is confirmed");
                }
                return;
            }
        }
    }

    public void Display()
    {
        Console.WriteLine("Passengers in waiting list");
        waitingList.DisplayP();

    }
}

class Program
{
    static void Main(string[] args)
    {
        Passenger p1 = new Passenger(1, 21);
        Passenger p2 = new Passenger(2, 22);
        Passenger p3 = new Passenger(3, 25);
        Passenger p4 = new Passenger(4, 30);
        Passenger p5 = new Passenger(5, 51);

        RailwaySystem rs = new RailwaySystem(2);

        rs.AddPassenger(p1);
        rs.AddPassenger(p2);
        rs.AddPassenger(p3);
        rs.AddPassenger(p4);
        rs.AddPassenger(p5);

        rs.Display();



        rs.Cancel(p1);

        rs.Display();

        rs.Cancel(p2);

        rs.Display();
    }
}