using System;

class BookNode
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string BookID { get; set; }
    public string Availability { get; set; }
    public BookNode? Next { get; set; }
    public BookNode? Prev { get; set; }
}

class DoublyLinkedList
{
    private BookNode? Head { get; set; }
    private BookNode? Tail { get; set; }

    public void AddBookAtBeginning()
    {
        Console.WriteLine("Enter Book Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Genre: ");
        string genre = Console.ReadLine();
        Console.Write("Book ID: ");
        string id = Console.ReadLine();
        Console.Write("Availability (Available/Checked Out): ");
        string status = Console.ReadLine();

        BookNode newNode = new BookNode { Title = title, Author = author, Genre = genre, BookID = id, Availability = status };

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }
        Console.WriteLine("Book added at the beginning.");
    }

    public void AddBookAtEnd()
    {
        Console.WriteLine("Enter Book Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Genre: ");
        string genre = Console.ReadLine();
        Console.Write("Book ID: ");
        string id = Console.ReadLine();
        Console.Write("Availability: ");
        string status = Console.ReadLine();

        BookNode newNode = new BookNode { Title = title, Author = author, Genre = genre, BookID = id, Availability = status };

        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
        Console.WriteLine("Book added at the end.");
    }

    public void AddBookAtPosition()
    {
        Console.Write("Enter Position: ");
        int position = int.Parse(Console.ReadLine());

        if (position == 1)
        {
            AddBookAtBeginning();
            return;
        }

        Console.WriteLine("Enter Book Details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Genre: ");
        string genre = Console.ReadLine();
        Console.Write("Book ID: ");
        string id = Console.ReadLine();
        Console.Write("Availability: ");
        string status = Console.ReadLine();

        BookNode newNode = new BookNode { Title = title, Author = author, Genre = genre, BookID = id, Availability = status };
        BookNode? temp = Head;

        for (int i = 1; temp != null && i < position; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            AddBookAtEnd();
        }
        else
        {
            newNode.Prev = temp.Prev;
            newNode.Next = temp;
            if (temp.Prev != null) temp.Prev.Next = newNode;
            temp.Prev = newNode;
        }
    }

    public void RemoveBookByID()
    {
        Console.Write("Enter Book ID to remove: ");
        string id = Console.ReadLine();
        BookNode? current = Head;

        while (current != null)
        {
            if (current.BookID == id)
            {
                if (current.Prev != null) current.Prev.Next = current.Next;
                else Head = current.Next;

                if (current.Next != null) current.Next.Prev = current.Prev;
                else Tail = current.Prev;

                Console.WriteLine($"Book ID '{id}' removed successfully.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void SearchBookByTitleOrAuthor()
    {
        Console.Write("Enter Title or Author to search: ");
        string searchTerm = Console.ReadLine();
        BookNode? current = Head;
        bool found = false;

        while (current != null)
        {
            if (current.Title.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                current.Author.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ID: {current.BookID} | Title: {current.Title} | Author: {current.Author} | Status: {current.Availability}");
                found = true;
            }
            current = current.Next;
        }
        if (!found) Console.WriteLine("No matches found.");
    }

    public void DisplayForward()
    {
        BookNode? current = Head;
        if (current == null) Console.WriteLine("Library is empty.");
        while (current != null)
        {
            Console.WriteLine($"[{current.BookID}] {current.Title} by {current.Author} ({current.Genre}) - {current.Availability}");
            current = current.Next;
        }
    }

    public void DisplayReverse()
    {
        BookNode? current = Tail;
        if (current == null) Console.WriteLine("Library is empty.");
        while (current != null)
        {
            Console.WriteLine($"[{current.BookID}] {current.Title} by {current.Author} ({current.Genre}) - {current.Availability}");
            current = current.Prev;
        }
    }

    public void UpdateAvailability()
    {
        Console.Write("Enter Book ID to update status: ");
        string id = Console.ReadLine();
        BookNode? current = Head;
        while (current != null)
        {
            if (current.BookID == id)
            {
                Console.Write("Enter New Status (Available/Checked Out): ");
                current.Availability = Console.ReadLine();
                Console.WriteLine("Status updated successfully.");
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void CountBooks()
    {
        int count = 0;
        BookNode? current = Head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        Console.WriteLine($"Total books in library: {count}");
    }
}

class LibraryManagement
{
    static void Main()
    {
        DoublyLinkedList library = new DoublyLinkedList();
        while (true)
        {
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Add Book (End)");
            Console.WriteLine("2. Add Book at Beginning");
            Console.WriteLine("3. Add Book at Position");
            Console.WriteLine("4. Remove Book by ID");
            Console.WriteLine("5. Search by Title/Author");
            Console.WriteLine("6. Display All (Forward)");
            Console.WriteLine("7. Display All (Reverse)");
            Console.WriteLine("8. Update Availability");
            Console.WriteLine("9. Count Total Books");
            Console.WriteLine("10. Exit");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------Processing-------\n");
            switch (choice)
            {
                case 1: library.AddBookAtEnd(); 
                        break;
                case 2: library.AddBookAtBeginning(); 
                    break;
                case 3: library.AddBookAtPosition(); 
                    break;
                case 4: library.RemoveBookByID(); break;
                case 5: library.SearchBookByTitleOrAuthor(); 
                    break;
                case 6: library.DisplayForward();
                 break;
                case 7: library.DisplayReverse();
                 break;
                case 8: library.UpdateAvailability(); 
                break;
                case 9: library.CountBooks(); 
                break;
                case 10: return;
                default: Console.WriteLine("Invalid Choice!"); 
                break;
            }
        }
    }
}