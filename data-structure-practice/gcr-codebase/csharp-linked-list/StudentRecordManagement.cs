
class StudentNode
{
    public string Name;
    public int Rollno;
    public char Grade;
    public StudentNode? Next;

    public StudentNode(string name, int rollno,char grade)
    {
        this.Name = name;
        this.Rollno = rollno;
        this.Grade=grade;
        this.Next = null;
    }
    
}

class LinkedList
{
    private StudentNode? Head;
    public LinkedList()
    {
        Head = null;
    }
    public void Add(StudentNode node)
    {
        if (Head == null)
            Head = node;
        else
        {
            StudentNode temp = Head;
            while(temp.Next != null)
                temp=temp.Next;
            temp.Next=node;
        }
    }
    public void SearchByRollNumber()
    {
        Console.Write("\nEnter the roll number to search: ");
        int rollnumber=int.Parse(Console.ReadLine());
        bool found=false;
        StudentNode? temp=Head;
        while(temp!=null)
        {
            if(rollnumber==temp.Rollno)
            {
                Console.WriteLine("The record is found");
                Console.WriteLine("Name:{0},Roll No:{1},Grade:{2}",temp.Name,temp.Rollno,temp.Grade);
                found=true;
                break;
            }
            temp=temp.Next;
        }
        if(!found)Console.WriteLine("Record not found");
    }
    public void DeleteByRollNumber()
    {
        Console.Write("\nEnter the roll number to delete: ");
        int rollnumber=int.Parse(Console.ReadLine());
        bool found=false;
        StudentNode? temp=Head;
        StudentNode? prev=null;
        while(temp!=null)
        {
            if(rollnumber==temp.Rollno)
            {
                Console.WriteLine("The record is deleted");
                found=true;
                break;
            }
            prev=temp;
            temp=temp.Next;
        }
        if(found){
            prev.Next=temp.Next;
            temp.Next=null;
        }
        else Console.WriteLine("Record not found");
    }
    public void UpdateByRollNumber()
    {
        Console.Write("\nEnter the roll number to update: ");
        int rollnumber=int.Parse(Console.ReadLine());
        bool found=false;
        StudentNode? temp=Head;
        while(temp!=null)
        {
            if(rollnumber==temp.Rollno)
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Name: ");
                string name=Console.ReadLine();
                Console.Write("Roll Number: ");
                int rno=int.Parse(Console.ReadLine());
                Console.Write("Grade: ");
                char grade=char.Parse(Console.ReadLine());
                temp.Name=name;
                temp.Rollno=rno;
                temp.Grade=grade;
                found=true;
                break;
            }
            temp=temp.Next;
        }
        if(!found)Console.WriteLine("Record not found");
    }
    public void Display()
    {
        Console.WriteLine("\nDisplaying the student records"); 
        StudentNode? temp=Head;
        Console.WriteLine("Name\tRollNo\tGrade");
        while(temp!=null)
        {
            Console.WriteLine("{0}\t {1}\t {2}",temp.Name,temp.Rollno,temp.Grade);
            temp=temp.Next;
        }
    } 
} 

class StudentRecordManagement
{
    static void Main()
    {
        LinkedList list=new LinkedList();
        list.Add(new StudentNode("Rahul", 1, 'B'));
        list.Add(new StudentNode("Sachin", 2, 'B'));
        list.Display();

        list.SearchByRollNumber();
        list.DeleteByRollNumber();
        list.UpdateByRollNumber();
        list.Display();
    }
} 