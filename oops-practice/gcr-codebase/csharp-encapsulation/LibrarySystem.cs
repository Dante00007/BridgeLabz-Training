using System;

public interface IReservable
{
    void ReserveItem(string user);
    bool CheckAvailability();
}

public abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    public string ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public LibraryItem(string id, string title, string author)
    {
        this.itemId = id;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public string GetItemDetails()
    {
        return "ID: " + itemId + " | Title: " + title + " | Author: " + author;
    }
}

public class Book : LibraryItem, IReservable
{
    private string borrowerName;
    private bool isReserved;

    public Book(string id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 21; 
    }

    public void ReserveItem(string user)
    {
        this.borrowerName = user;
        this.isReserved = true;
        Console.WriteLine("Book '" + Title + "' reserved for " + borrowerName);
    }

    public bool CheckAvailability()
    {
        return !isReserved;
    }
}

public class Magazine : LibraryItem
{
    public Magazine(string id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7;
    }
}

public class DVD : LibraryItem, IReservable
{
    private bool isReserved;

    public DVD(string id, string title, string author) : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem(string user)
    {
        this.isReserved = true;
        Console.WriteLine("DVD '" + Title + "' is now on hold.");
    }

    public bool CheckAvailability()
    {
        return !isReserved;
    }
}
class LibrarySystem
{
    static void Main()
    {
        LibraryItem[] library = new LibraryItem[3];

        library[0] = new Book("B001", "C# Programming", "Microsoft Press");
        library[1] = new Magazine("M002", "Tech Today", "Global Media");
        library[2] = new DVD("D003", "Intro to OOP", "EduCorp");

        for (int i = 0; i < library.Length; i++)
        {
            LibraryItem item = library[i];
            
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

            if (item is IReservable reservableItem)
            {
                if (reservableItem.CheckAvailability())
                {
                    Console.WriteLine("Status: Available for reservation.");
                    reservableItem.ReserveItem("John Doe");
                }
                else
                {
                    Console.WriteLine("Status: Already Reserved.");
                }
            }
            else
            {
                Console.WriteLine("Status: Reference Only (Cannot Reserve).");
            }
            
            Console.WriteLine("------------------------------------------");
        }
    }
}