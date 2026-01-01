


class Employee
{
    public static string companyName="Zara";
    private static int count;
    private readonly int id;
    protected string name;
    private string designation;
    public Employee(int id,string designation,string name)
    {
        this.id=id;
        this.designation=designation;
        this.name = name;
        count++;
    }
    public static void DisplayTotalEmployees() 
    {
        Console.WriteLine("Total Employees : "+count);
    }
    public virtual void Display()
    {
        Console.WriteLine("Id : "+id);
        Console.WriteLine("Name : "+name);
        Console.WriteLine("Designation : "+designation);
    }

    static void Main()
    {
        Employee emp = new Employee(1,"Manager","Rahul");
        if(emp is Employee)
            emp.Display();
    }
}