
public interface Worker
{
    void PerformDuties();
}


public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

public class Chef : Person, Worker
{
    public string Specialty { get; set; }

    public Chef(string name, int id, string specialty) : base(name, id)
    {
        Specialty = specialty;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} (Chef ID: {Id}) is preparing {Specialty} dishes.");
    }
}
public class Waiter : Person, Worker
{
    public int AssignedTable { get; set; }

    public Waiter(string name, int id, int table) : base(name, id)
    {
        AssignedTable = table;
    }

    public void PerformDuties()
    {
        Console.WriteLine($"{Name} (Waiter ID: {Id}) is serving table number {AssignedTable}.");
    }
}

class RestaurantManagement
{
    static void Main()
    {
        Waiter waiter1 = new Waiter("Suresh", 101, 1);
        waiter1.PerformDuties();
        Chef chef1 = new Chef("Mukesh", 101, "Italian");
        chef1.PerformDuties();

    }
}