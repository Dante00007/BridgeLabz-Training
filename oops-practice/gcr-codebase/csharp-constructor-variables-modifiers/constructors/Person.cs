

class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person(Person person)
    {
        SetName(person.GetName());
        SetAge(person.GetAge()); 
    }
    public string GetName()
    {
        return this.name;
    }
    public int GetAge()
    {
        return this.age;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public void Display()
    {
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Age: " + GetAge());
    }

    static void Main(string[] args)
    {
        Person p1 = new Person("John", 25);
        Person p2 = new Person(p1); // Copy constructor is called here
        p2.Display();
        p2.SetName("Jane");
        p2.SetAge(30);
        p2.Display();
    }
}

