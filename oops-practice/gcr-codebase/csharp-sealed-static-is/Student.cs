
class Student
{
    public static string universityName;
    public static int totalStudents;
    public string name;
    private int rollNumber;
    public char grade;

    public Student(string name, int rollNumber, char grade)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.grade = grade;
        totalStudents++;
    }
    public static void DisplayTotalStudents() { 
        Console.WriteLine("Total Students: " + totalStudents); 
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name} \nRoll Number: {rollNumber}\nGrade: {grade}");
    }
    static void Main()
    {
        Student.universityName = "XYZ University";
        var student1 = new Student("John", 101, 'A');
        var student2 = new Student("Jane", 102, 'B');
        if (student1 is Student)
        {
            student1.DisplayDetails();
        }
    }
}