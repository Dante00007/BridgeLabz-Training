
class LibraryBook
{
    public string title ;
    public string author ;
    public double price ;
    public bool isAvailable ;

    public LibraryBook(string title, string author, double price, bool isAvailable)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available for borrowing.");
        }
    }

    static void Main()
    {
        LibraryBook book1 = new LibraryBook("C#","James",20.5f,true);
        book1.BorrowBook();
    }
}