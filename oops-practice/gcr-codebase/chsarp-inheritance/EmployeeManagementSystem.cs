
class Employee {
    private string name;
    private int id;
    private double salary;

    public Employee(string name, int id, double salary) {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayDetails() {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Salary: {salary}");
    }
 }

class Manager : Employee {
    private int teamSize;

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary) {
        this.teamSize = teamSize;
    }

    public void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: {teamSize}");
    }
}

class Developer : Employee {
    private string programmingLanguage;

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary) {
        this.programmingLanguage = programmingLanguage;
    }

    public void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {programmingLanguage}");
    }
}

class Intern : Employee {
    private string internshipDuration;
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary) {
        this.internshipDuration = internshipDuration;
    }
}

class EmployeeManagementSystem {
    static void Main() {
        Manager manager = new Manager("Krishna", 101, 5000.0, 5);
        Developer developer = new Developer("Bhanu ", 202, 4000.0, "C#");
        Intern intern = new Intern("Devansh", 303, 2500.0, "6 months");
        manager.DisplayDetails();
        Console.WriteLine("--------------------");
        developer.DisplayDetails();
        Console.WriteLine("--------------------");
        intern.DisplayDetails();
    }
}

