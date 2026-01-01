
class Product
{
    private static int totalProducts = 10;
    private double price;
    private string productName;

    public Product(string productName,double price)
    {
        this.productName = productName;
        this.price = price;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name : "+productName);
        Console.WriteLine("Product Price : "+price);
    }
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products : "+totalProducts);
    }
    public static void Main(String[] args)
    {
        Product.DisplayTotalProducts();
        Product p1=new Product("Laptop",56789.23);
        p1.DisplayProductDetails();
    } 
}