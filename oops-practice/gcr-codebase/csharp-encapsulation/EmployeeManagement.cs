/*
Description: Build an employee management system with the following requirements:
Use an abstract class Employee with fields like employeeId, name, and baseSalary.
Provide an abstract method CalculateSalary() and a concrete method DisplayDetails().
Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing CalculateSalary() based on work hours or fixed salary.
Use encapsulation to restrict direct access to fields and provide properties for access.
Create an interface IDepartment with methods like AssignDepartment() and GetDepartmentDetails().
Ensure polymorphism by processing a list of employees and displaying their details using the Employee reference.
*/

interface IDepartment
{
    void AssignDepartment();
    string GetDepartmentDetails();
}
class Department
{
    private string departmentId { get; set; }
    private string departmentName { get; set; }

    private Employee[] employeeList { get; set; }
    public Department(string departmentId, string departmentName)
    {
        this.departmentId = departmentId;
        this.departmentName = departmentName;
        this.employeeList = new Employee[5];
    }
    public void AssignDepartment(Employee employee)
    {
        for (int i = 0; i < employeeList.Length; i++)
        {
            if (employeeList[i] == null)
            {
                employeeList[i] = employee;
                break;
            }
        }
    }
    public void GetDepartmentDetails()
    {
        Console.WriteLine($"Getting department details");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Department Id:{departmentId} ");
        Console.WriteLine($"Department Name:{departmentName}");
        Console.WriteLine(employeeList.Length);
    }
}

abstract class Employee
{
    private int employeeId;
    private string name;
    protected double baseSalary;

    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: " + baseSalary);
    }
}

class FullTimeEmployee : Employee
{

    private double workHours;
    private double hourlyRate;
    public FullTimeEmployee(int employeeId, string name, double baseSalary, double workHours) : base(employeeId, name, baseSalary)
    {
        this.workHours = workHours;
        hourlyRate = baseSalary / 50;
    }

    public override double CalculateSalary()
    {
        return baseSalary + (workHours * hourlyRate);
    }
}

class PartTimeEmployee : Employee
{
    private double hourlyRate;
    private double workHours;

    public PartTimeEmployee(int employeeId, string name, double baseSalary, double workHours) : base(employeeId, name, baseSalary)
    {
        hourlyRate = baseSalary / 40;
        this.workHours = workHours;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }
}

class EmployeeManagement
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[2];
        employees[0] = new FullTimeEmployee(1, "Rahul", 10000.0, 40.0);
        employees[1] = new PartTimeEmployee(2, "Ravi", 5000.0, 20.0);
        Department department = new Department("D1", "HR");

        department.AssignDepartment(employees[0]);
        department.AssignDepartment(employees[1]);
        department.GetDepartmentDetails();

        Console.WriteLine("Employee Details:");
        Console.WriteLine("------------------");
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine("Total Salary: " + emp.CalculateSalary());
            Console.WriteLine();
        }
    }
}