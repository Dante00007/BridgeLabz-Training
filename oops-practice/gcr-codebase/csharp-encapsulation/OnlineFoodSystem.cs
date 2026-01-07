using System;

public interface IDiscountable
{
    double ApplyDiscount(double total);
    string GetDiscountDetails();
}

public abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public FoodItem(string name, double price, int qty)
    {
        this.itemName = name;
        this.price = price;
        this.quantity = qty;
    }

    public abstract double CalculateTotalPrice();

    public string GetItemDetails()
    {
        return "Item: " + itemName + " | Quantity: " + quantity + " | Unit Price: $" + price;
    }
}
public class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int qty) : base(name, price, qty) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public double ApplyDiscount(double total)
    {
        return total * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "10% Green Discount Applied";
    }
}

public class NonVegItem : FoodItem, IDiscountable
{
    private double packagingCharge = 5.0;

    public NonVegItem(string name, double price, int qty) : base(name, price, qty) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + packagingCharge;
    }

    public double ApplyDiscount(double total)
    {
        return total * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "5% Non-Veg Promo Discount Applied";
    }
}
 class OnlineFoodSystem
{
    static void Main()
    {
        FoodItem[] order = new FoodItem[2];

        order[0] = new VegItem("Paneer Tikka", 12.0, 2);
        order[1] = new NonVegItem("Chicken Burger", 15.0, 1);

        Console.WriteLine("--- Order Summary ---");
        Console.WriteLine();

        for (int i = 0; i < order.Length; i++)
        {
            FoodItem item = order[i];
            double subTotal = item.CalculateTotalPrice();
            double discountAmount = 0;

            Console.WriteLine(item.GetItemDetails());

            if (item is IDiscountable discountableItem)
            {
                discountAmount = discountableItem.ApplyDiscount(subTotal);
                Console.WriteLine("Discount: " + discountableItem.GetDiscountDetails() + " (-$" + discountAmount + ")");
            }

            double finalItemTotal = subTotal - discountAmount;
            Console.WriteLine("Final Price for " + item.ItemName + ": $" + finalItemTotal);
            Console.WriteLine("------------------------------------------");
        }
    }
}