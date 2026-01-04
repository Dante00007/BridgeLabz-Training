

class Order {
    private int orderId;
    private DateTime OrderDate;
    public Order(int id) {
        SetOrderId(id);
        SetOrderDate(DateTime.Now);
    }
    public void SetOrderId(int id)
    {
        this.orderId = id;
    }
     public void SetOrderDate(DateTime date)
    {
        this.OrderDate = date;
    }
    public int GetOrderId()
    {
        return this.orderId;
    }
    public DateTime GetOrderDate()
    {
        return this.OrderDate;
    }
    public virtual string GetOrderStatus(){
        return "Pending";
    }
}
class ShippedOrder : Order{
    private string trackingNumber; 
    public ShippedOrder(int id,string trackingNumber):base(id){
        this.trackingNumber=trackingNumber;
    }
    public string GetTrackingNumber(){
        return this.trackingNumber;
    }
    public override string GetOrderStatus(){
        return "Shipped";
    }
}
class DeliveredOrder : ShippedOrder{
    private DateTime deliveryDate;
    public DeliveredOrder(int id,string trackingNumber,DateTime deliveryDate):base(id,trackingNumber){
        this.deliveryDate=deliveryDate;
    }
    public DateTime GetDeliveryDate(){
        return this.deliveryDate;
    }
    public override string GetOrderStatus(){
        return "Delivered";
    }
}
class OnlineRetailOrder{
    static void Main(){
        Order o1=new Order(20);
        Console.WriteLine(o1.GetOrderId());
        Console.WriteLine(o1.GetOrderDate());
        Console.WriteLine(o1.GetOrderStatus()); 
        ShippedOrder o2=new ShippedOrder(30,"12345");
        Console.WriteLine(o2.GetOrderId());
        Console.WriteLine(o2.GetOrderDate());
        Console.WriteLine(o2.GetTrackingNumber());
        Console.WriteLine(o2.GetOrderStatus());
        DeliveredOrder o3=new DeliveredOrder(40,"6789",new DateTime(2023, 10, 1));
        Console.WriteLine(o3.GetOrderId());
        Console.WriteLine(o3.GetOrderDate());
        Console.WriteLine(o3.GetTrackingNumber());
        Console.WriteLine(o3.GetDeliveryDate().ToString("dd-MM-yyyy"));
        Console.WriteLine(o3.GetOrderStatus());
    }
}

