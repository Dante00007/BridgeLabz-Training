
class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public TaskNode Next;
    public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = this;
    }
    public override string ToString()
    {
        return $"Task Id :{TaskId}, Task Name:{TaskName}, Priority:{Priority}";
    }
}
class CircularLinkedList
{
    private TaskNode Head { get; set; }

    public void AddTask()
    {
        Console.WriteLine("Enter Task Id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Task Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Priority");
        int priority = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Due Date");
        DateTime date = DateTime.Parse(Console.ReadLine());
        TaskNode task = new TaskNode(id, name, priority, date);
        if (Head == null)
        {
            Head = task;
        }
    
        TaskNode? temp = Head;
        while (temp != null && temp.Next != Head)
            temp = temp.Next;
        temp.Next = task;
        task.Next = Head;
    }
    public void AddTaskAtBeginning()
    {
        Console.WriteLine("Enter Task Id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Task Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Priority");
        int priority = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Due Date");
        DateTime date = DateTime.Parse(Console.ReadLine());
        TaskNode task = new TaskNode(id, name, priority, date);
        if (Head == null)
        {
            Head = task;
        }
        else
        {
            task.Next = Head;
            TaskNode temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;
            temp.Next = task;
            Head = task;
        }
    }

    public void AddTaskAtAnyPosition()
    {
        Console.WriteLine("Enter Task Id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Task Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Priority");
        int priority = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Due Date");
        DateTime date = DateTime.Parse(Console.ReadLine());
        TaskNode task = new TaskNode(id, name, priority, date);
        if (Head == null)
        {
            Head = task;
        }
        else
        {
            Console.WriteLine("Enter Position");
            int pos = Convert.ToInt32(Console.ReadLine());
            TaskNode temp = Head;
            for (int i = 1; i < pos - 1; i++)
                temp = temp.Next;
            task.Next = temp.Next;
            temp.Next = task;
        }
    }

    public void RemoveTaskById()
    {
        Console.WriteLine("Enter Task Id");
        int id = Convert.ToInt32(Console.ReadLine());
        if (Head == null) {
            Console.WriteLine("No Task available in scheduler");
            return;
        }
        if (Head.TaskId == id)
        {
            TaskNode temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;
            temp.Next = Head.Next;
            temp = Head;
            Head = Head.Next;

            temp.Next = null;
        }
        else
        {
            TaskNode prev = null, temp = Head;
            while (temp.Next != Head && temp.TaskId != id)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (prev != null && temp != null && temp.TaskId == id)
            {
                prev.Next = temp.Next;
                temp.Next = null;
            }
            else
            {
                Console.WriteLine($"Task With Id {id} Not Found");
            }
        }
    }

    public void Display()
    {
        if (Head == null)
        {
            Console.WriteLine("List is Empty");
            return;
        }
        TaskNode temp = Head;
        do
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        } while (temp != Head);
    }

    public void SearchByPriority()
    {
        if (Head == null)
        {
            Console.WriteLine("No task found");
            return;
        }
        Console.WriteLine("Enter Priority");
        int priority = Convert.ToInt32(Console.ReadLine());
        TaskNode temp = Head;
        bool found = false;
        do
        {
            if (temp.Priority == priority){
                found = true;
                Console.WriteLine(temp);
            }
            temp = temp.Next;
        } while (temp != Head);

        if (!found)
            Console.WriteLine($"Task With Priority {priority} Not Found");
    }
    public void ViewCurrentMoveToNextTask()
    {
        if (Head == null)
        {
            Console.WriteLine("No task found");
            return;
        }
        Console.WriteLine(Head);
        TaskNode temp = Head;
        while (temp.Next != Head)
        {
            temp = temp.Next;
        }
        temp.Next = Head.Next;
        temp = Head;
        Head = Head.Next;
        temp.Next = null;

    }
}

class TaskScheduler
{
    static void Main()
    {
        CircularLinkedList cll = new CircularLinkedList();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1.Add Task");
            Console.WriteLine("2.Add Task At Beginning");
            Console.WriteLine("3.Add Task At Any Position");
            Console.WriteLine("4.Remove Task By Id");
            Console.WriteLine("5.Display All Tasks");
            Console.WriteLine("6.Search By Priority");
            Console.WriteLine("7.View Current And Move To Next Task");
            Console.WriteLine("8.Exit");
            Console.Write("Enter Your Choice ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----Processing-----");
            switch (choice)
            {
                case 1:
                    cll.AddTask();
                    break;
                case 2:
                    cll.AddTaskAtBeginning();
                    break;
                case 3:
                    cll.AddTaskAtAnyPosition();
                    break;
                case 4:
                    cll.RemoveTaskById();
                    break;
                case 5:
                    cll.Display();
                    break;
                case 6:
                    cll.SearchByPriority();
                    break;
                case 7:
                    cll.ViewCurrentMoveToNextTask();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Wrong Choice");
                    return;
            }
        }
    }
}
