

class Course
{
    private static string instituteName="Gla";
    private int duration;
    private string courseName;
    private double fee;

    public Course(int duration,string courseName,double fee)
    {
        this.duration=duration;
        this.courseName=courseName;
        this.fee=fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: "+courseName);
        Console.WriteLine("Duration: "+duration);
        Console.WriteLine("Fee: "+fee);
        Console.WriteLine("Institute Name: "+instituteName);
    }

    public static void UpdateInstituteName(string instituteName)
    {
        Course.instituteName=instituteName;
    }
    
    public static void Main(String[] args)
    {
        Course c1=new Course(3,"Java",5000.0);
        c1.DisplayCourseDetails();
        Course.UpdateInstituteName("GLA University");
        c1.DisplayCourseDetails();

    }

}