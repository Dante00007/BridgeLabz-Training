/*
Description: Model a course system where Course is the base class, OnlineCourse is a subclass, and PaidOnlineCourse extends OnlineCourse.
Tasks:
Define a superclass Course with attributes like CourseName and Duration.
Define OnlineCourse to add attributes such as Platform and IsRecorded.
Define PaidOnlineCourse to add Fee and Discount.
Goal: Demonstrate how each level of inheritance builds on the previous, adding complexity to the system.
*/

class Course
{
    private string courseName;
    private int duration;
    public Course(string courseName, int duration)
    {
        this.courseName = courseName;
        this.duration = duration;
    }

}
class OnlineCourse : Course
{
    private string platform;
    private bool isRecorded;
    public OnlineCourse(string courseName, int duration,string platform,bool isRecorded) : base(courseName,duration)
    {
        this.platform=platform;
        this.isRecorded=isRecorded;
    }
}
class PaidOnlineCourse : OnlineCourse
{
    private double fee;
    private double discount;
    public PaidOnlineCourse(string courseName,int duration,string platform,bool isRecorded,double fee,double discount):base(courseName,duration,platform,isRecorded)
    {
        this.fee=fee;
        this.discount=discount;
    }
}
class EducationalHierarchy
{
    static void Main()
    {
        
    }
}