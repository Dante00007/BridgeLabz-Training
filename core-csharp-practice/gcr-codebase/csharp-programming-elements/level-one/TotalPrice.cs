
class TotalPrice
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the unit price");
        int unitPrice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the quantity");
        int quantity = Convert.ToInt32(Console.ReadLine());
        int totalPrice = unitPrice * quantity;
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}