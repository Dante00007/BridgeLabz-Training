using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    public TaskInfo(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "Alice")]
    public void ProcessOrder()
    {
        Console.WriteLine("Processing order...");
    }
}

class Task
{
    static void Main(string[] args)
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("ProcessOrder");

        if (method != null)
        {
            TaskInfo attr = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));

            if (attr != null)
            {
                Console.WriteLine($"Method: {method.Name}");
                Console.WriteLine($"Priority: {attr.Priority}");
                Console.WriteLine($"Assigned To: {attr.AssignedTo}");
              
            }
        }
    }
}