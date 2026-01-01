

class LibraryMangement
{
    public string title;
    public string author;
    public readonly int isbn;
    private static string libraryname = "ABC";

    LibraryMangement(string title,string author,int isbn)
    {
        this.title=title;
        this.author=author;
        this.isbn=isbn;
    }
    public static void DisplayLibraryName()
    {
        Console.WriteLine(libraryname);
    }

    public void display()
    {
        Console.WriteLine("Title : "+title);
        Console.WriteLine("Author : "+author);
        Console.WriteLine("ISBN : "+isbn);
    }

    static void Main()
    {
        LibraryMangement.DisplayLibraryName();
        LibraryMangement l1=new LibraryMangement("C#","XYZ",234567890);
        if(l1 is LibraryMangement)
            l1.display();
    }
}
