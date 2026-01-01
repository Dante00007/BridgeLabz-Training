


class Employee
{
    public int employeeID;
    protected string department;
    private double salary;
    public Employee(int id, string dept, double sal)
    {
        employeeID = id;
        department = dept;
        ModifySalary(sal);
    }
    public void ModifySalary(double newSalary)
    {
        salary = newSalary;
    }
}
class Manager : Employee
{
    public Manager(int id, string dept,double sal) : base(id, dept,sal){

    }
    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
    }

    static void Main()
    {
        Manager manager = new Manager(1,"CSE",5000000);
        manager.Display();
    }
}