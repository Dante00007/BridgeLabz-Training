


class Book
{
    private string title;
    private int publicationYear;
    public Book(string title, int publicationYear)
    {
        SetTitle(title);
        SetPublicationYear(publicationYear);
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetPublicationYear(int year)
    {
        if (year > 0)
            publicationYear = year;
        else
            Console.WriteLine("Invalid year");
    }
    public string GetTitle()
    {
        return title;
    }
    public int GetPublicationYear()
    {
        return publicationYear;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}, Year: {publicationYear}");
    }
}
class Author : Book
{
    private string name;
    private string bio;
    public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
    {
        SetName(name);
        SetBio(bio);
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetBio(string bio)
    {
        this.bio = bio;
    }
    public string GetName()
    {
        return name;
    }
    public string GetBio()
    {
        return bio;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("\n\nAuthor Details");
        Console.WriteLine($"Name:{GetName()}\nBio:{GetBio()}");
        Console.WriteLine($"Title:{base.GetTitle()}\nYear:{base.GetPublicationYear()}\n");
    }
}

class BookSystem
{
    static void Main()
    {
        Book author = new Author("The Great Gatsby", 2009, "F. Scott Fitzgerald", "American novelist");
        author.DisplayInfo();
    }
}