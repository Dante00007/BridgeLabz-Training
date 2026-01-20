
abstract class Category
{
    private string name;

    public Category(string name )
    {
        this.name = name;
    }

    public string Name { get => name; set => name = value; }
    public override string ToString()
    {
        return $"Name: {Name}";
    }

}

class BookCategory : Category
{
    public BookCategory(string name) : base(name)
    {
    }
}

class ClothingCategory : Category
{
    public ClothingCategory(string name) : base(name)
    {
    }
}

class Product<T> where T : Category
{
    T category;
    private string name;
    private int price;
    public Product(T category, string name, int price)
    {
        this.category = category;
        this.name = name;
        this.price = price;
    }

    public T Category { get => category; set => category = value; }
    public string Name { get => name; set => name = value; }
    public int Price { get => price; set => price = value; }
   
}

class MarketManager
{
    public void ApplyDiscount<T> (Product<T> product, int discountPercentage) where T : Category
    {
        product.Price -= (product.Price * discountPercentage) / 100;
    }
}

class DynamicOnlineMarket
{
    static void Main(string[] args)
    {
        MarketManager marketManager = new MarketManager();
        Product<BookCategory> book = new Product<BookCategory>(new BookCategory("Book"), "Great Expectations", 100);
        Product<ClothingCategory> clothing = new Product<ClothingCategory>(new ClothingCategory("Clothing"), "Shirt", 200);

        marketManager.ApplyDiscount(book, 10);
        marketManager.ApplyDiscount(clothing, 10);

        Console.WriteLine(book.Price);
        Console.WriteLine(clothing.Price);
    }
}