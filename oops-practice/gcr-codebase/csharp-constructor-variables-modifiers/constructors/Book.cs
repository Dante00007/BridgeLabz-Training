class Book{
    private string title;
    private string author;
    private float price;
    public Book(){}
    public Book(string title,string author,float price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display(){
        Console.WriteLine("Title : "+title);
        Console.WriteLine("Author : "+author);
        Console.WriteLine("Price : "+price);
    }

    public static void Main(String[] args){
        Book book1 = new Book("C#","James",20.5f);
        book1.Display();
    }
}