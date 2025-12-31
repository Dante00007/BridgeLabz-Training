using System;
using System.Text.RegularExpressions;

class LibraryManagement
{
    private const string LibrarianId = "Bhanu";
    private const string LibrarianPassword = "bhanu@123";
    
    // Data Storage
    private static string[,] students;
    private static string[] bookTitle;
    private static string[] authorName;
    private static DateTime[] issuedAt;
    private static int[,] isIssuedTo; // [StudentIndex, BookSlot]
    private static int[] quantity;

    private int studentId = -1;

    static LibraryManagement()
    {
        bookTitle = new string[20];
        authorName = new string[20];
        issuedAt = new DateTime[20];
        quantity = new int[20];
        students = new string[20, 2];
        isIssuedTo = new int[20, 3];

        for (int i = 0; i < 20; i++)
            for (int j = 0; j < 3; j++)
                isIssuedTo[i, j] = -1;

  
        string[] titles = { "The Great Gatsby", "1984", "C# in Depth", "The Hobbit", "Clean Code", 
                            "Hamlet", "The Alchemist", "Inferno", "Dune", "Dracula" };
        string[] authors = { "F. Scott Fitzgerald", "George Orwell", "Jon Skeet", "J.R.R. Tolkien", "Robert Martin", 
                             "Shakespeare", "Paulo Coelho", "Dan Brown", "Frank Herbert", "Bram Stoker" };
        
        for (int i = 0; i < 10; i++)
        {
            bookTitle[i] = titles[i];
            authorName[i] = authors[i];
            quantity[i] = 5;
        }
    }


    private static string LibraryMenu()
    {
        Console.WriteLine("\nSelect an option:\n1. View All Books\n2. Add New Book\n3. Logout");
        return Console.ReadLine();
    }
    public void LibrarianUtil()
    {
        Console.Write("Enter Librarian ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        if (id != LibrarianId || pass != LibrarianPassword)
        {
            Console.WriteLine("Invalid credentials!");
            return;
        }

        switch (LibraryMenu())
        {
            case "1": 
                    DisplayAllBooks(); 
                    break;
            case "2": 
                    AddBook(); 
                    break;
            default:
                Console.WriteLine("Logging out...");
                return;
        }
    }

    private void DisplayAllBooks()
    {
        Console.WriteLine("\nID | Title | Author | Qty");
        for (int i = 0; i < bookTitle.Length; i++)
        {
            if (bookTitle[i] != null)
                Console.WriteLine($"{i} | {bookTitle[i]} | {authorName[i]} | {quantity[i]}");
        }
    }

    private void AddBook()
    {
        for (int i = 0; i < bookTitle.Length; i++)
        {
            if (bookTitle[i] == null)
            {
                Console.Write("Enter Title: "); bookTitle[i] = Console.ReadLine();
                Console.Write("Enter Author: "); authorName[i] = Console.ReadLine();
                Console.Write("Enter Quantity: "); quantity[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Book added successfully!");
                return;
            }
        }
    }

    private static int StudentMenu()
    {
        Console.WriteLine("\nSelect an option:\n1. Search & Issue Book\n2. Display My Issued Books\n3. Logout");
        if (int.TryParse(Console.ReadLine(), out int choice)) return choice;
        return -1;
    }

    private void SearchBook()
    {
        Console.Write("Enter book title to search: ");
        string title = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookTitle.Length; i++)
        {
            if (bookTitle[i] != null && bookTitle[i].ToLower().Contains(title.ToLower()))
            {
                found = true;
                Console.WriteLine($"Found: {bookTitle[i]} by {authorName[i]} (Available: {quantity[i]})");
                Console.Write("Issue this book? (Y/N): ");
                if (Console.ReadLine().ToUpper() == "Y") RequestIssue(this.studentId, i);
                return;
            }
        }
        if (!found) Console.WriteLine("Book not found or out of stock.");
    }

    private void RequestIssue(int sId, int bId)
    {
        if (quantity[bId] <= 0)
        {
            Console.WriteLine("Error: Out of stock.");
            return;
        }

        bool slotFound = false;
        for (int j = 0; j < 3; j++) 
        {
            if (isIssuedTo[sId, j] == -1)
            {
                isIssuedTo[sId, j] = bId;
                quantity[bId]--;
                issuedAt[bId] = DateTime.Now;
                Console.WriteLine($"Success! '{bookTitle[bId]}' issued.");
                slotFound = true;
                break;
            }
        }
        if (!slotFound) Console.WriteLine("Limit Reached! You can only issue 3 books.");
    }

    private void DisplayIssuedBooks()
    {
        Console.WriteLine("\n--- Your Issued Books ---");
        bool empty = true;
        for (int j = 0; j < 3; j++)
        {
            int bId = isIssuedTo[this.studentId, j];
            if (bId != -1)
            {
                empty = false;
                Console.WriteLine($"- {bookTitle[bId]} by {authorName[bId]} (Date: {issuedAt[bId]})");
            }
        }
        if (empty) Console.WriteLine("You have no issued books.");
    }

    public int StudentUtil()
    {
        Console.Write("Enter Name: "); string name = Console.ReadLine();
        Console.Write("Enter Roll No: "); string roll = Console.ReadLine();

        for (int i = 0; i < 20; i++)
        {
            if (students[i, 1] == roll) { this.studentId = i; break; }
            if (students[i, 0] == null) { students[i, 0] = name; students[i, 1] = roll; this.studentId = i; break; }
        }

        switch(StudentMenu()){
            case 1: SearchBook();
                    break;
            case 2: DisplayIssuedBooks(); 
                    break;
            default: return -1;
        }
       

        return this.studentId;
    }

    public void Library()
    {
        Console.WriteLine("======= ZARA LIBRARY SYSTEM =======");
        Console.WriteLine("Select Login Type:\n1. Student\n2. Staff (Librarian)");
        string authLevel = Console.ReadLine();

        if (authLevel == "2") LibrarianUtil();
        else StudentUtil();
    }

    static void Main()
    {
        LibraryManagement obj = new LibraryManagement();
        while (true) // Keep system running
        {
            obj.Library();
            Console.WriteLine("\nPress any key to return to main screen...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}