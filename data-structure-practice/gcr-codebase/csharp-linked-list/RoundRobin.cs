using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnaroundTime;
    public ProcessNode? Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        Next = this; // Circular reference to self
    }

    public override string ToString()
    {
        return $"[PID: {ProcessId} | Burst: {BurstTime} | Priority: {Priority}]";
    }
}

class CircularLinkedList
{
    private ProcessNode? Head { get; set; }
    private int processCount = 0;

    public void AddProcess()
    {
        Console.Write("Enter Process Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Burst Time: ");
        int burst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Priority: ");
        int priority = Convert.ToInt32(Console.ReadLine());

        ProcessNode newNode = new ProcessNode(id, burst, priority);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            ProcessNode temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next!;
            }
            temp.Next = newNode;
            newNode.Next = Head;
        }
        processCount++;
        Console.WriteLine("Process added successfully.");
    }

    public void RemoveProcessById(int id)
    {
        if (Head == null) return;

        if (Head.ProcessId == id && Head.Next == Head)
        {
            Head = null;
        }
        else
        {
            ProcessNode? prev = null, curr = Head;
            do
            {
                if (curr.ProcessId == id)
                {
                    if (curr == Head)
                    {
                        ProcessNode last = Head;
                        while (last.Next != Head) last = last.Next!;
                        Head = Head.Next;
                        last.Next = Head;
                    }
                    else
                    {
                        prev!.Next = curr.Next;
                    }
                    processCount--;
                    return;
                }
                prev = curr;
                curr = curr.Next!;
            } while (curr != Head);
        }
    }

    public void SimulateRoundRobin()
    {
        if (Head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        Console.Write("Enter Time Quantum: ");
        int quantum = Convert.ToInt32(Console.ReadLine());

        int currentTime = 0;
        double totalWaitTime = 0;
        double totalTurnAroundTime = 0;
        int completedProcesses = 0;
        int initialCount = processCount;

        ProcessNode? current = Head;

        while (processCount > 0)
        {
            Console.WriteLine($"\n--- Time: {currentTime}ms | Executing {current!.ProcessId} ---");

            if (current.RemainingTime <= quantum)
            {
                currentTime += current.RemainingTime;
                current.RemainingTime = 0;
                
                // Process Completed
                current.TurnaroundTime = currentTime;
                current.WaitingTime = current.TurnaroundTime - current.BurstTime;
                
                totalWaitTime += current.WaitingTime;
                totalTurnAroundTime += current.TurnaroundTime;
                
                Console.WriteLine($"Process {current.ProcessId} FINISHED at {currentTime}ms");
                
                int idToRemove = current.ProcessId;
                current = current.Next; // Move pointer before removing
                RemoveProcessById(idToRemove);
            }
            else
            {
                currentTime += quantum;
                current.RemainingTime -= quantum;
                Console.WriteLine($"Process {current.ProcessId} paused. Remaining: {current.RemainingTime}ms");
                current = current.Next;
            }

            if (processCount > 0) Display();
        }

        Console.WriteLine("\n--- Scheduling Results ---");
        Console.WriteLine($"Average Waiting Time: {totalWaitTime / initialCount}ms");
        Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / initialCount}ms");
    }

    public void Display()
    {
        if (Head == null)
        {
            Console.WriteLine("Process queue is empty.");
            return;
        }
        ProcessNode temp = Head;
        Console.Write("Queue: ");
        do
        {
            Console.Write($"{temp.ProcessId}({temp.RemainingTime}) -> ");
            temp = temp.Next!;
        } while (temp != Head);
        Console.WriteLine("(Back to Head)");
    }
}

class RounRobin
{
    static void Main()
    {
        CircularLinkedList scheduler = new CircularLinkedList();
        while (true)
        {
            Console.WriteLine("\n--- Round Robin CPU Scheduler ---");
            Console.WriteLine("1. Add Process");
            Console.WriteLine("2. Display Queue");
            Console.WriteLine("3. Start Round Robin Simulation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----Processing-----");
            switch (choice)
            {
                case 1:
                    scheduler.AddProcess();
                    break;
                case 2:
                    scheduler.Display();
                    break;
                case 3:
                    scheduler.SimulateRoundRobin();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}