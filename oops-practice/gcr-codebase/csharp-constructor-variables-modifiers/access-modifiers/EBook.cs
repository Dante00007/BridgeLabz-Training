

class Book
{
    public string ISBN ;
    protected string title;
    private string author ;

    public Book(string ISBN,string title,string author)
    {
        this.title=title;
        this.author=author;
        this.ISBN =ISBN;
    }
     
}

class EBook : Book
{
    public EBook(string ISBN, string title,string author) : base(ISBN,title, author){
    }
    public void display()
    {
        Console.WriteLine("Title: "+this.title);
        Console.WriteLine("ISBN: "+this.ISBN);
    }
    static void Main(string[] args)
    {
        EBook book1=new EBook("The Alchemist","Paulo Coelho", "9780547236456");
        book1.display();
    }
}