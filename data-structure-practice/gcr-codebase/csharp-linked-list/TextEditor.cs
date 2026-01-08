using System;

class TextStateNode
{
    public string Content { get; set; }
    public TextStateNode? Next { get; set; }
    public TextStateNode? Prev { get; set; }
}

class UndoRedoManager
{
    private TextStateNode? Head { get; set; }
    private TextStateNode? Tail { get; set; }
    private TextStateNode? CurrentState { get; set; }
    private int count = 0;
    private const int MaxHistory = 10;

    public void AddState()
    {
        Console.Write("Enter text to save in history: ");
        string text = Console.ReadLine() ?? "";

        // If we are in the middle of undo/redo and perform a new action, 
        // we must clear the "redo" path (everything after current)
        if (CurrentState != null && CurrentState.Next != null)
        {
            CurrentState.Next = null;
            Tail = CurrentState;
            UpdateCount();
        }

        TextStateNode newNode = new TextStateNode { Content = text };

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            CurrentState = newNode;
            count = 1;
        }
        else
        {
            newNode.Prev = Tail;
            Tail!.Next = newNode;
            Tail = newNode;
            CurrentState = newNode;
            count++;

            // Maintain history limit of 10
            if (count > MaxHistory)
            {
                Head = Head.Next;
                Head!.Prev = null;
                count--;
            }
        }
        Console.WriteLine("Action saved.");
    }

    public void Undo()
    {
        if (CurrentState == null || CurrentState.Prev == null)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        CurrentState = CurrentState.Prev;
        Console.WriteLine("Undo successful.");
    }

    public void Redo()
    {
        if (CurrentState == null || CurrentState.Next == null)
        {
            Console.WriteLine("Nothing to redo.");
            return;
        }

        CurrentState = CurrentState.Next;
        Console.WriteLine("Redo successful.");
    }

    public void DisplayCurrentState()
    {
        if (CurrentState == null)
        {
            Console.WriteLine("Editor is empty.");
        }
        else
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Current Text: " + CurrentState.Content);
            Console.WriteLine("----------------------------");
        }
    }

    private void UpdateCount()
    {
        int newCount = 0;
        TextStateNode? temp = Head;
        while (temp != null)
        {
            newCount++;
            temp = temp.Next;
        }
        count = newCount;
    }
}

class TextEditor
{
    static void Main()
    {
        UndoRedoManager editor = new UndoRedoManager();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Type (New State)");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. Display Current Text");
            Console.WriteLine("5. Exit");
            Console.Write("Choice: ");
            
            string input = int.Parse(Console.ReadLine());
            Console.WriteLine("------Processing------");
            switch (choice)
            {
                case 1:
                    editor.AddState();
                    break;
                case 2:
                    editor.Undo();
                    break;
                case 3:
                    editor.Redo();
                    break;
                case 4:
                    editor.DisplayCurrentState();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}