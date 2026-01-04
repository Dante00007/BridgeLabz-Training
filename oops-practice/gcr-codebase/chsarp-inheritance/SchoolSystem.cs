public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void DisplayRole()
    {
        Console.WriteLine($"This person's role is not specified.");
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} (Age: {Age}) is a Teacher specializing in {Subject}.");
    }
}

public class Student : Person
{
    public string Grade { get; set; }

    public Student(string name, int age, string grade) : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} (Age: {Age}) is a Student in {Grade}.");
    }
}

public class Staff : Person
{
    public string Department { get; set; }

    public Staff(string name, int age, string dept) : base(name, age)
    {
        Department = dept;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} (Age: {Age}) is a Staff member in the {Department} department.");
    }
}

class SchoolSystem
{
    static void Main(string[] args)
    {
       
        Person teacher = new Teacher("Mr. Smith", 35, "Mathematics");
        Person student = new Student("Alice Johnson", 16, "Sophomore");
        Person staffMember = new Staff("Mrs. Brown", 40, "Administration");

       
        teacher.DisplayRole();
        student.DisplayRole();
        staffMember.DisplayRole();
        Console.WriteLine();
    }
}