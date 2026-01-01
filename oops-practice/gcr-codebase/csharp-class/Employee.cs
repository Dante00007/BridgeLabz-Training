class Employee{
    private int id;
    private string name;
    private double salary;

    public Employee(int id,string name,double salary){
        this.id=id;
        this.name=name;
        this.salary=salary;
    }
    public void Display(){
        Console.WriteLine("Id : "+id);
        Console.WriteLine("Name : "+name);
        Console.WriteLine("Salary : "+salary);
    }

    public static void Main(string[] args){
        Employee emp=new Employee(1,"Rahul",5000.23);
        emp.Display();
    }
}