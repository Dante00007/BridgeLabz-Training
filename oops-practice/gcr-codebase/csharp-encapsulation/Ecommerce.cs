using System;
using System.Collections.Generic;

public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

public abstract class Product
{
    private string name;
    private double price;
    public int ProductId { get; set; }

 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { if (value >= 0) price = value; }
    }

    public Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();
}

public class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => Price * 0.10; // 10% off
    public double CalculateTax() => Price * 0.15;              // 15% tax
    public string GetTaxDetails() => "15% Electronics VAT";
}

public class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount(){ 
        return Price * 0.20; 
    }
    public double CalculateTax() { return Price * 0.05;}             
    public string GetTaxDetails() => "5% Apparel Tax";
}

public class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() {
        return  0;
    } 
}

public class Ecommerce
{
    public static void Main()
    {
        Product[] cart = new Product[3];
        cart[0]=new Electronics(101, "Laptop", 1000);
        cart[1]=new Clothing(202, "Jeans", 50);
        cart[2]=new Groceries(303, "Bread", 2);

    
        foreach (Product p in cart)
        {
            double discount = p.CalculateDiscount();
            double tax = 0;
            string taxInfo = "Tax Exempt";

            if (p is ITaxable taxableProduct)
            {
                tax = taxableProduct.CalculateTax();
                taxInfo = taxableProduct.GetTaxDetails();
            }

            double finalPrice = p.Price + tax - discount;

            Console.WriteLine($"Product: {p.Name}");
            Console.WriteLine($" - Base Price: ${p.Price}");
            Console.WriteLine($" - Discount: -${discount}");
            Console.WriteLine($" - Tax: +${tax} ({taxInfo})");
            Console.WriteLine($" - Final Total: ${finalPrice}");
            Console.WriteLine("---------------------------");
        
    }
}
}