

class Cart
{
    private static int discount = 10;
    public readonly int productId;
    public string productName;
    public double price;
    public int quantity ;

    public Cart(string name,double price,int quantity,int productId)
    {
        this.productName=productName;
        this.price=price;
        this.quantity=quantity;
        this.productId=productId;
    }
    public static void UpdateDiscount(int newDiscount)
    {
        discount = newDiscount;
    }
    public void Display()
    {
        Console.WriteLine("Product Name : "+productName);
        Console.WriteLine("Price : "+price);
        Console.WriteLine("Quantity : "+quantity);
    }
    static void Main()
    {
        Cart c=new Cart("Apple",25.67,3,1);
        if(c is Cart)
            c.Display();
    }
}