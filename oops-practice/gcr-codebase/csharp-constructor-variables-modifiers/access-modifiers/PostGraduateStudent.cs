


class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;

    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    public void ModifyCGPA(double newCGPA)
    {
        CGPA = newCGPA;
    }
    public double GetCGPA()
    {
        return CGPA;
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double CGPA) : base(rollNumber, name, CGPA)
    {
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + GetCGPA());
    }

    static void Main(string[] args)
    {
        PostgraduateStudent student = new PostgraduateStudent(1, "John Doe", 3.8);
        student.DisplayDetails();
        student.ModifyCGPA(3.9);
        Console.WriteLine("Modified CGPA: " + student.GetCGPA());
    }
}

